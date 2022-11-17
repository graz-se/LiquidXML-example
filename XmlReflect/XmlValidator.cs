using System.Xml.Linq;
using System.Xml.Schema;

namespace Graz.XmlReflect
{
	static class XmlValidator
	{
		public static List<string> Validate(XmlSchema schema, XDocument document)
		{
			List<string> events = new();

			XmlSchemaSet schemaSet = new XmlSchemaSet();
			schemaSet.Add(schema);
			document.Validate(schemaSet, ValidationEventHandler);

			return events;

			void ValidationEventHandler(object? sender, ValidationEventArgs e)
			{
				string entry = $"{e.Severity}: {e.Message}";
				events.Add(entry);
			}
		}
	}
}