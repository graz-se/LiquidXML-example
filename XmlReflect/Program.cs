using LiquidTechnologies.XmlObjects;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Xml;
using System.Reflection;

namespace Graz.XmlReflect
{
	internal class Program
	{
		static string OutputFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Output";

		static void Main(string[] args)
		{
			int iterations = 20;
			if (args.Length > 0)
			{
				iterations = int.Parse(args[0]);
			}
			try
			{
				GenerateCSharp("Data/OpLog.txt");

				var schema = LoadSchema("Data/camt.053.001.02.xsd");

				foreach (var n in Enumerable.Range(1, iterations))
				{
					var output = Recreate("Data/OpLog.txt");
					var issues = XmlValidator.Validate(schema, output.Doc);

					Console.ForegroundColor = issues.Any() ? ConsoleColor.Red : ConsoleColor.Green;
					Console.WriteLine($"#{n:00}: {output.Hash}");

					StoreOutput(output.Hash, output.Doc);
				}
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex);
			}
		}

		static void GenerateCSharp(string logFilename)
		{
			string csFilename = Path.Combine(OutputFolder, "CS Code.txt");

			using var csWriter = File.CreateText(csFilename);
			csWriter.WriteLine("static void Fill(Messages.ISO.CAMTx053x001x02.Tns.DocumentElm document)");
			csWriter.WriteLine("{");

			var codeGen = new CodeWriter("document.Seq.BkToCstmrStmt", csWriter);
			codeGen.Replay(logFilename);

			csWriter.WriteLine("}");
		}

		static void StoreOutput(string hash, XDocument document)
		{
			string path = Path.Combine(OutputFolder, $"HASH_{hash}.xml");

			if (!File.Exists(path))
			{
				var settings = new XmlWriterSettings
				{
					Indent = true,
					IndentChars = "\t",
				};

				using var writer = XmlWriter.Create(path, settings);
				document.WriteTo(writer);
			}
		}

		static XmlSchema LoadSchema(string filename)
		{
			using var schemaFile = File.OpenRead(filename);
			return XmlSchema.Read(schemaFile, null) ?? throw new Exception("Unable to read schema");
		}

		static (XDocument Doc, string Hash) Recreate(string logFilename)
		{
			var document = new Messages.ISO.CAMTx053x001x02.Tns.DocumentElm();
			var writer = new DataWriter(document.Seq.BkToCstmrStmt);
			writer.Replay(logFilename);

			using var xmlBuffer = new MemoryStream();
			Serialize(document, xmlBuffer);

			xmlBuffer.Position = 0;
			var hash = HashStream(xmlBuffer);

			xmlBuffer.Position = 0;
			var xDoc = XDocument.Load(xmlBuffer);

			return (xDoc, hash);
		}

		private static void Serialize<T>(T document, Stream stream)
			where T : class
		{
			var serializer = new LxSerializer<T>();
			LxWriterSettings settings = new LxWriterSettings
			{
				ErrorHandler = ErrorHandler,
				WriteBannerComment = false,
			};

			serializer.Serialize(stream, document, settings);

			void ErrorHandler(string msg, LxErrorSeverity severity, LxErrorCode errorCode, object? targetObject)
			{
				Console.WriteLine($"{severity}:{errorCode} {msg}");

				if (severity == LxErrorSeverity.Error)
				{
					throw new LxSerializationException(msg, severity, errorCode, null, targetObject);
				}
			}
		}

		public static string HashStream(Stream stream)
		{
			var sha = System.Security.Cryptography.SHA256.Create();
			byte[] hash = sha.ComputeHash(stream);
			return BitConverter.ToString(hash).Replace("-", string.Empty);
		}
	}
}
