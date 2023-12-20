using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyRunner.UI
{
    internal class Menu
    {
        public List<Choice> Choices { get; set; }
        public Menu(List<string> names)
        {
            foreach (string name in names)
            {
                Choice choice = new Choice(name);
                Choices.Add(choice);
                
            }
            Choices[0].isChosen = true;
        }
        public void DisplayMenu()
        {
            Console.WriteLine();
            foreach (Choice choice in Choices)
            {
                if (choice.isChosen)
                {
                    Console.Write($"\t[{SpecialSigns.Player}] ");
                }
                else
                {
                    Console.Write("\t[ ] ");
                }
                Console.WriteLine(choice.label);
            }
            Console.WriteLine();
        }

    }
}
