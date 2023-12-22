using EnergyRunner.UI;

namespace EnergyRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("\u2022; \u2606; \u2605; \u2B50; \u2302");
            List<string> names = new List<string>{ "Option 1", "Option 2", "OPtion3"};
            Menu menu = new Menu(names);
            menu.DisplayMenu();
        }
    }
    class Player
    {
        public int health { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Player(int health=100)
        {
            this.health = health;
            x = 0;
            y = 0;
        }
    }
}
