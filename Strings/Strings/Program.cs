// String

// StartsWith(), EndsWith(), Contains()
string s = "Krokonosohroch";
Console.WriteLine(s.StartsWith("krok"));
Console.WriteLine(s.EndsWith("hroch"));
Console.WriteLine(s.Contains("nos"));
Console.WriteLine(s.Contains("roh") + "\n");

// ToUpper(), ToLower()
string config = "Fullscreen shaDows autosave";
config = config.ToLower();
Console.WriteLine("Pobezi hra ve fullscreenu?");
Console.WriteLine(config.Contains("fullscreen"));
Console.WriteLine("Budou zapnute stiny?");
Console.WriteLine(config.Contains("shadows"));
Console.WriteLine("Preje si hrac vypnout zvuk?");
Console.WriteLine(config.Contains("sound"));
Console.WriteLine("Preje si mit hrac zapnuty autosave?");
Console.WriteLine(config.Contains("autosave"));

// Trim(), TrimStart(), TrimEnd()    ---  Parse functions trim user input automatically!!!
Console.WriteLine("Zadejte cislo: ");
string? input = Console.ReadLine();
Console.WriteLine("Zadal jste text: " + input);
int number = int.Parse(input);
Console.WriteLine("Prevedl jsem zadany text na cislo parsovanim, zadali jste: " + number);
Console.WriteLine("Text po funkci trim: " + input.Trim());

// Replace()
string retezec = "Java je nejlepsi!";
retezec = retezec.Replace("Java", "C#");
Console.WriteLine(retezec);

// Format()
int x = 1;
int y = 2;
string retezec2 = string.Format("Kdyz secteme {0} a {1}, dostaneme {2}", x, y, x + y);
Console.WriteLine(retezec2);
Console.WriteLine("Kydz secteme {0} a {1}, dostaneme {2}", x, y, x + y);

// String Interpolation
Console.WriteLine($"Kdyz secteme {x} a {y}, dostaneme {x + y}");

// PadLeft(), PadRight()
// used to create space in console, so we can create tables
// PadleRight inserts spaces after and PadleLeft insert spaces before

// Length property
Console.WriteLine("Zadejte vase jmeno: ");
string? name = Console.ReadLine();
if (name is not null)
    Console.WriteLine($"Delka vaseho jmena je: {name.Length}");

// Strings are arrays of chars, but read only, we can't change specific character to another, e.g. string[0] = '1' WILL NOT WORK!

// Caesar's cipher
string? hiddenMessage = "MynicknameisLazik";
string? cipher = "";
foreach (var item in hiddenMessage)
{
    cipher += (char)((int)item + 5);
}
Console.WriteLine(cipher);

foreach(var item in cipher)
{
    Console.Write((char)((int)item - 5));
}
Console.WriteLine();

string? sampleText = "This is a sample text!";

// First()
Console.WriteLine(sampleText.First());

// Last()
Console.WriteLine(sampleText.Last());

// IndexOf()
Console.WriteLine(sampleText.IndexOf('a'));

// Insert() - This doesn't alter the original string!
Console.WriteLine(sampleText.Insert(8, "not "));
Console.WriteLine(sampleText);

// Remove() - This doesn't alter the original string!
Console.WriteLine(sampleText.Remove(sampleText.Length - 3)); // second parameter is number of characters from that position
Console.WriteLine(sampleText);

// Substring()
Console.WriteLine(sampleText.Substring(1, 4));

// CompareTo()
Console.WriteLine("Compare To: Argentina vs Brazil - return {0}", "Argentina".CompareTo("Brazil"));
Console.WriteLine("Comapre To: Brazil vs Brazil - return {0}", "Brazil".CompareTo("Brazil"));
Console.WriteLine("Compare To: Brazil vs Argentina - return {0}", "Brazil".CompareTo("Argentina"));

// Split() and Join() - Morse code
string[] strings = { "Lazik", "Marek", "Ondra" };
string joinedString = string.Join(' ', strings);
Console.WriteLine(joinedString);

string morseCodeMessage = ".-.. . --- -. .- .-. -.. ---";
Console.WriteLine("Original ciphered message in Morse Code: {0}", morseCodeMessage);
string decipheredMorseCode = "";

string alphabetCharacters = "abcdefghijklmnopqrstuvwxyz";
string[] morseCharacters = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
"..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
"...-", ".--", "-..-", "-.--", "--.."};

string[] morseCodeCharacters = morseCodeMessage.Split(' ');

foreach (var item in morseCodeCharacters)
{
    int position = Array.IndexOf(morseCharacters, item);

    if (position >= 0)
        decipheredMorseCode += alphabetCharacters[position];
}
Console.WriteLine(decipheredMorseCode);

string messageToCode = "Hi this is Lazik please help me";
string codedMessage = "";
foreach (var item in messageToCode.ToLower())
{
    int position = alphabetCharacters.IndexOf(item);
    //int position = Array.IndexOf(alphabetCharacters.ToArray(), item);

    if (position >= 0)
        codedMessage += (morseCharacters[position] + "/");
    else if (item == ' ')
        codedMessage += " ";
}
Console.WriteLine(codedMessage);

// StringSplitOptions - splits string ignoring multiple whitespaces from source string 
string originalSentence = "  This is my    test case!";
string[] words = originalSentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
foreach (var word in words)
{
    Console.WriteLine(word);
}

// Special characters and escape sequence
Console.WriteLine("\\");
Console.WriteLine("\u1234");
Console.WriteLine("\u0007"); // Beep

// Escape sequence modifier
Console.WriteLine(@"C:\Lazik\Hry\Legends of Runeterra.exe");

string vyuka = "abeceda:\nzačíná na \"A\"";
Console.Write(vyuka.IndexOf('A'));

// Reverse string with Array class
string Reverse(string text)
{
    if (text == null) 
        return null;

    // this was posted by petebob as well 
    char[] array = text.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}

public static string ReverseXor(string s)
{
    if (s == null) return null;
    char[] charArray = s.ToCharArray();
    int len = s.Length - 1;

    for (int i = 0; i < len; i++, len--)
    {
        charArray[i] ^= charArray[len];
        charArray[len] ^= charArray[i];
        charArray[i] ^= charArray[len];
    }

    return new string(charArray);
}