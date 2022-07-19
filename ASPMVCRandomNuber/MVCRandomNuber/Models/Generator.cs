namespace MVCRandomNuber.Models
{
    public class Generator
    {
        private static Random _random = new Random();

        public int GetNumber()
        {
            return _random.Next();
        }
    }
}
