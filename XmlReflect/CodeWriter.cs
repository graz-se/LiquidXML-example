namespace Graz.XmlReflect
{
	class CodeWriter
	{
		private readonly Stack<object?> _stack = new();
		private readonly TextWriter _writer;

		public CodeWriter(string rootObjectPath, TextWriter? writer = null)
		{
			_stack.Push(rootObjectPath);
			_writer = writer ?? Console.Out;
		}

		public void Replay(string logFilename)
		{
			int lineNo = 0;

			try
			{
				foreach (var line in File.ReadLines(logFilename))
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

		private void Write(string output)
		{
			_writer.WriteLine(output);
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

		int _objCounter = 0;

		string GetObjName(string typeName)
		{
			var clsName = typeName.Split('.').Last();
			return $"{clsName}{++_objCounter:00}";
		}

		void CreateObject(string typeName)
		{
			var objName = GetObjName(typeName);
			var code = $"var {objName} = new {typeName}();";
			Write(code);
			_stack.Push(objName);
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
				"string" => $"\"{valueString}\"",
				"number" => $"new BigDecimal({valueString}m)",
				"date" => $"LxDateTime.ParseXSDDateTime(\"{valueString}\")",
				"bool" => valueString.ToLowerInvariant(),
				"enum" => ParseEnum(valueString),
				_ => throw new Exception("Unknown type: " + typeName),
			};

			_stack.Push(value);

			object? ParseEnum(string str)
			{
				var args = str.Split(' ');
				return $"{args[0]}.{args[1]}";
			}
		}

		void Set(string propertyPath)
		{
			var value = _stack.Pop();
			object instance = _stack.Peek() ?? throw new Exception("Null target for set operation");
			object? propValue = instance;

			var code = $"{instance}.{propertyPath} = {value};";
			Write(code);
		}

		void Add()
		{
			var value = _stack.Pop();
			var list = _stack.Peek() ?? throw new Exception("Null target for add operation");

			var code = $"{list}.Add({value});";
			Write(code);
		}

		void Enter(string propertyPath)
		{
			var instance = _stack.Peek() ?? throw new Exception("Null target for enter operation");
			_stack.Push($"{instance}.{propertyPath}");
		}

		void Exit()
		{
			_stack.Pop();
		}
	}
}
