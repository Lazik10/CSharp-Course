///
/// FILES
///

// Create()
FileStream stream = File.Create("lazik.txt");
stream.Close();
var s = File.Create("lazik.doc");
s.Close();
var ss = File.Create("lazik");
ss.Close();

// Copy()
File.Copy("lazik.txt", "lazik1.txt", true); // override? true/false
// Move()
File.Move("lazik", "laska", true);
// Delete()
File.Delete("lazik");

// FileAttributes
/*
Normal
ReadOnly
Hidden
System
Directory
Archive
Temporary
Compressed
Offline
Encrypted
*/
File.SetAttributes("laska", FileAttributes.Directory);
Console.WriteLine(File.GetAttributes("laska"));

// File Times - and set them with corresponding Set Methods
File.GetCreationTime("laska");
File.GetLastAccessTime("laska");
File.GetLastWriteTime("laska");
File.SetCreationTime("laska", DateTime.Now);

///
/// FILE INFO - similar to File class, but we create specific instance for a specific file and then work with it
/// 
FileInfo fInfo = new FileInfo("laska");

// Fields - CreationTime, LastAccessTime, LastWriteTime
bool exists = fInfo.Exists;
string name = fInfo.Name;
string fullName = fInfo.FullName;
string extension = fInfo.Extension;
DirectoryInfo? directory = fInfo.Directory;
string? directoryName = fInfo.DirectoryName;
bool isReadOnly = fInfo.IsReadOnly;
long length = fInfo.Length;

// Methods

// CopyTo
fInfo.CopyTo("file");

// Delete
// fInfo.Delete();

// MoveTo
// fInfo.MoveTo("new path");

// Refresh
// fInfo.Refresh();