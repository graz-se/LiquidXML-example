using LiquidTechnologies.XmlObjects;
using System.Reflection;

namespace Graz.XmlReflect
{
	class DataWriter
	{
		private readonly Stack<object?> _stack = new();
		private readonly string _assemblyName;

		public DataWriter(object rootObject)
		{
			_assemblyName = rootObject.GetType().Assembly.GetName().Name ?? throw new Exception("Assembly name missing");
			_stack.Push(rootObject);
		}

		public void Replay(string filename)
		{
			int lineNo = 0;

			try
			{
				foreach (var line in File.ReadLines(filename))
				{
					lineNo++;
					ProcCmd(line);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Line #{lineNo} {ex.Message}");
			}
		}

		private void ProcCmd(string cmd)
		{
			if (cmd.StartsWith("CREATE"))
			{
				var args = cmd.Split(' ');
				CreateObject(args[1]);
			}
			else if (cmd.StartsWith("VALUE"))
			{
				cmd = cmd[6..];
				var idx = cmd.IndexOf(' ');
				var typeName = cmd[..idx];
				var valueString = cmd[(idx + 1)..];

				CreateValue(typeName, valueString);
			}
			else if (cmd.StartsWith("ENTER"))
			{
				var arg = cmd[6..];
				Enter(arg);
			}
			else if (cmd.StartsWith("EXIT"))
			{
				Exit();
			}
			else if (cmd.StartsWith("ADD"))
			{
				Add();
			}
			else if (cmd.StartsWith("SET"))
			{
				Set(cmd[4..]);
			}
			else
			{
				throw new Exception("Unknown command: " + cmd);
			}
		}

		void CreateObject(string typeName)
		{
			var instance = Activator.CreateInstance(_assemblyName, typeName)?.Unwrap() ?? throw new Exception($"Unable to create {typeName} ({_assemblyName})");
			_stack.Push(instance);
		}

		void CreateValue(string typeName, string valueString)
		{
			if (valueString.StartsWith("NULL"))
			{
				_stack.Push(null);
				return;
			}

			object? value = typeName switch
			{
				"string" => valueString,
				"number" => BigDecimal.Parse(valueString),
				"date" => ParseDateTime(valueString),
				"bool" => bool.Parse(valueString),
				"enum" => ParseEnum(valueString),
				_ => throw new Exception("Unknown type: " + typeName),
			};

			_stack.Push(value);

			object? ParseEnum(string str)
			{
				var args = str.Split(' ');
				var obj = Activator.CreateInstance(_assemblyName, args[0])?.Unwrap() ?? throw new Exception("Bad enum");
				return obj != null ? Enum.Parse(obj.GetType(), args[1]) : null;
			}

			object ParseDateTime(string str)
			{
				var dateTime = DateTime.Parse(str);
				return new LxDateTime(dateTime);
			}
		}

		void Set(string propertyPath)
		{
			var value = _stack.Pop();
			object instance = _stack.Peek() ?? throw new Exception("Null target for set operation");
			object? propValue = instance;

			PropertyInfo? property = null;
			foreach (var propertyName in propertyPath.Split('.'))
			{
				instance = propValue ?? throw new Exception();
				property = instance.GetType().GetProperty(propertyName) ?? throw new Exception("Bad property: " + propertyName);
				propValue = property.GetValue(propValue);
			}

			if (property != null)
			{
				property.SetValue(instance, value);
			}
			else
			{
				throw new Exception("Bad property: " + propertyPath);
			}

			// Verify that we do not assign values to multiple properties in a choice group
			if (propertyPath.Contains("Chc."))
			{
				object obj = _stack.Peek()!;

				foreach (var propertyName in propertyPath.Split('.'))
				{
					var propInfo = obj.GetType().GetProperty(propertyName)!;
					obj = propInfo.GetValue(obj)!;

					if (propertyName == "Chc")
					{
						int count = 0;
						var choices = obj.GetType().GetProperties();
						foreach (var choice in choices)
						{
							bool isAssigned = choice.GetValue(obj) != null;
							if (isAssigned)
							{
								count++;
							}
						}

						if (count > 1)
						{
							Console.WriteLine("Multiple choices set: " + propertyPath);
						}

						return;
					}
				}
			}
		}

		void Add()
		{
			var value = _stack.Pop();
			var list = _stack.Peek() ?? throw new Exception("Null target for add operation");
			var addMethod = list.GetType().GetMethod("Add") ?? throw new Exception("Add method missing"); ;
			addMethod.Invoke(list, new object?[] { value });
		}

		void Enter(string propertyPath)
		{
			var instance = _stack.Peek() ?? throw new Exception("Null target for enter operation");

			foreach (var propertyName in propertyPath.Split('.'))
			{
				var property = instance?.GetType().GetProperty(propertyName) ?? throw new Exception("Bad property: " + propertyName);
				instance = property.GetValue(instance);
			}

			_stack.Push(instance);
		}

		void Exit()
		{
			_stack.Pop();
		}

		public static void ExtractOpsFromLogFile(string filename)
		{
			using var writer = File.CreateText(filename + ".ops.txt");

			foreach (var line in File.ReadLines(filename))
			{
				if (!line.StartsWith("[Ops]")) continue;

				var end = line.LastIndexOf(" (");
				var cmd = line[6..end];
				writer.WriteLine($"{cmd}");
			}
		}
	}
}
