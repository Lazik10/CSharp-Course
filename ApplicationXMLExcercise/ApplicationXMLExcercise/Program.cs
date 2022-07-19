using ApplicationXMLExcercise;
using System.Xml;

// Class object to be saved in xml
Settings settings = new Settings(DateTime.Now, true, @"C:\Lazik",
                                    @"C:\Users\Lazik\Documents", "Hi There");

// Settings for XML
XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
xmlWriterSettings.Indent = true;

// Creating xml reader with SAX
using (XmlWriter xmlWriter = XmlWriter.Create("settings.xml", xmlWriterSettings))
{
    // Start document
    xmlWriter.WriteStartDocument();

    // start root element
    xmlWriter.WriteStartElement("settings");

    // last run date
    xmlWriter.WriteStartElement("last-run-date");
    xmlWriter.WriteValue(settings.LastRunDate.ToShortDateString());
    xmlWriter.WriteEndElement();

    // run on startup
    xmlWriter.WriteElementString("run-on-startup", settings.RunOnStartup.ToString());

    // paths
    xmlWriter.WriteStartElement("paths");
    xmlWriter.WriteElementString("app-path", settings.ApplicationPath);
    xmlWriter.WriteElementString("doc-path", settings.DocumentsPath);
    xmlWriter.WriteEndElement();
    // end paths

    // message
    xmlWriter.WriteStartElement("message");
    xmlWriter.WriteValue(settings.Message);
    xmlWriter.WriteEndElement();

    // end root element
    xmlWriter.WriteEndElement();

    // End document
    xmlWriter.WriteEndDocument();
}

