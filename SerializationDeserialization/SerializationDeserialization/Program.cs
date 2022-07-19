namespace SerializationDeserialization
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            // If we want to serialize our object that object HAS TO have parameterless constructor!!!
        }
    }
}