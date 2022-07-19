using XML;
using System.Xml;
using System.Xml.Linq;

// XML - eXtensible Markup Language
// - selfexplaining
// - we can use SQL query or XPath
// - rival to JSON
// - used for data exchange between desktop app or web app on server

// XML in .NET
// - continuous access SAX parser and object access DOM

// SAX - SIMPLE API for XML
// - advantages are high speed and memory modest
// - disadvantages 


// Test Users
List<User> users = new List<User>();
users.Add(new User("Pavel Slavík", 22, new DateTime(2000, 3, 21)));
users.Add(new User("Jan Novák", 31, new DateTime(2012, 10, 30)));
users.Add(new User("Tomáš Marný", 16, new DateTime(2011, 1, 12)));

/// <summary>
/// XML - SAX access
/// </summary>

// XML Settings
XmlWriterSettings settings = new XmlWriterSettings();
settings.Indent = true; // Indentation is not default setting!

/// <summary>
/// XML WRITER
/// </summary>
using (XmlWriter xmlWriter = XmlWriter.Create("users.xml", settings))
{
    // XML HEADER
    xmlWriter.WriteStartDocument();
    // START ROOT ELEMENT
    xmlWriter.WriteStartElement("users");

    foreach (var user in users)
    {
        // OPEN ELEMENT
        xmlWriter.WriteStartElement("user");

        // WRITE ATTRIBUTES
        xmlWriter.WriteAttributeString("name", user.Name);
        // OPTION 1: element and value
        xmlWriter.WriteStartElement("name");    // start - name of the element
        xmlWriter.WriteValue(user.Name);        // value
        xmlWriter.WriteEndElement();            // end
        // OPTION 2: element with value
        xmlWriter.WriteElementString("age", user.Age.ToString());
        xmlWriter.WriteElementString("registration", user.Registration.ToShortDateString());
        
        // CLOSE ELEMENT
        xmlWriter.WriteEndElement();
    }

    // END ROOT ELEMENT
    xmlWriter.WriteEndElement();
    // XML HEADER END
    xmlWriter.WriteEndDocument();

    // FLUSH - empty the buffer
    xmlWriter.Flush();
}

/// <summary>
/// XML READER
/// </summary>
List<User> usersLoad = new List<User>();

using (XmlReader xmlReader = XmlReader.Create("users.xml"))
{
    string name = "";
    int age = 0;
    DateTime registration = DateTime.Now;
    string element = "";

    // Reading the XML document
    while (xmlReader.Read())
    {
        // XmlReader has attribute XmlNodeType
        if (xmlReader.NodeType == XmlNodeType.Element)
        {
            element = xmlReader.Name;
            /*if (element == "user")
                    name = xmlReader.GetAttribute("name");*/
        }
        else if (xmlReader.NodeType == XmlNodeType.Text)
        {
            switch (element)
            {
                case "name":
                    name = xmlReader.Value;
                    break;
                case "age":
                    age = int.Parse(xmlReader.Value);
                    break;
                case "registration":
                    registration = DateTime.Parse(xmlReader.Value);
                    break;
                default:
                    break;
            }
        }
        else if (xmlReader.NodeType == XmlNodeType.EndElement && (xmlReader.Name == "user"))
            usersLoad.Add(new User(name, age, registration));
    }
}

foreach (var user in usersLoad)
{
    Console.WriteLine(user);
}

/// <summary>
/// DOM - Document Object Model
/// </summary>

// LOAD XML with DOM

// Create document reader and load xml
XmlDocument xmlDoc = new XmlDocument();
xmlDoc.Load("users.xml");

// Create root node
XmlNode? root = xmlDoc.DocumentElement;

// Iterate throught child nodes
foreach (XmlNode node in root.ChildNodes)
{
    if (node.Name == "user")
    {
        XmlElement user = (XmlElement)node;
        int age = int.Parse(user.GetElementsByTagName("age")[0].InnerText);
        string name = user.GetElementsByTagName("name")[0].InnerText;
        DateTime registration = DateTime.Parse(user.GetElementsByTagName("registration")[0].InnerText);
        User userLoaded = new User(name, age, registration);
        Console.WriteLine(userLoaded);
    }
}

// CREATE XML with DOM

// Create document "worker"
XmlDocument xmlDocument = new XmlDocument();

// Create declaration and add it into the document
XmlDeclaration declaration = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null);
xmlDocument.AppendChild(declaration);

// Create root element
XmlElement rootOut = xmlDocument.CreateElement("users");

foreach (var user in users)
{
    XmlElement userTmp = xmlDocument.CreateElement("user");

    // Attribut
    userTmp.SetAttribute("age", user.Age.ToString());

    // Name
    XmlElement name = xmlDocument.CreateElement("name");
    name.InnerText = user.Name;
    userTmp.AppendChild(name);

    // Registration
    XmlElement registration = xmlDocument.CreateElement("registration");
    registration.InnerText = user.Registration.ToShortDateString();
    userTmp.AppendChild(registration);
    
    // Add user element to root childs
    rootOut.AppendChild(userTmp);
}

// Add end of root?
xmlDocument.AppendChild(rootOut);
xmlDocument.Save("soubor.xml");

/// <summary>
/// LINQ to XML WRITE
/// </summary>

// Create new document
XDocument document = new XDocument(
    new XDeclaration("1.0", "UTF-8", null),
    new XElement("users",
        users.Select(x => new XElement("user",
                            new XAttribute("age", 22),
                            new XElement("name", "Jan Novak"),
                            new XElement("registration", "30.10.2012")
            )
        )
    )
);
document.Save("linq.xml");

/// <summary>
/// LINQ to XML READ
/// </summary>

// Create new document
XDocument loadDocument = XDocument.Load("linq.xml");
foreach (XElement user in loadDocument.Element("users").Elements("user"))
{
    Console.WriteLine(user.Element("name").Value);
}

/// <summary>
/// LINQ to XML EDIT
/// </summary>

// Create new document
XDocument readDoc = XDocument.Load("linq.xml");

var query = from user in readDoc.Element("users").Elements("user")
            where user.Element("name").Value.StartsWith("Jan")
            select user;

foreach (XElement xElement in query)
{
    xElement.Attribute("age").Value = "31";
}
readDoc.Save("linq.xml");

/// <summary>
/// LINQ to XML DELETE
/// </summary>

// Create new document
XDocument deleteDoc = XDocument.Load("linq.xml");
(from u in deleteDoc.Element("users").Elements("user")
where int.Parse(u.Attribute("age").Value) <= 31
select u).Remove();
deleteDoc.Save("linq.xml");