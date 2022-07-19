namespace OOP_Hello_World
{
    /// <summary>
    /// This class represents Grret object which is greeting people
    /// </summary>
    internal class Greet
    {
        /// <summary>
        /// Greetings text 
        /// </summary>
        public string? text;
        /// <summary>
        /// Greets the user with greeting text and by his/her name
        /// </summary>
        /// <param name="name">Name of the user</param>
        /// <returns>Text with greetings</returns>
        public string SayHello(string name)
        {
            return string.Format(text + " " + name);
            // return String.Format("{0} {1}", text, name); 
        }
    }
}
