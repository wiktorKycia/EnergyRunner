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
        private int IndexOfTheChosenOne = 0;
        public Menu(List<string> names)
        {
            Choices = new List<Choice> { };
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
        private void ResetChosenOne()
        {
            foreach (Choice choice in Choices)
            {
                choice.isChosen = false;
            }
            Choices[IndexOfTheChosenOne].isChosen = true;
        }
        public void GoUp()
        {
            if(IndexOfTheChosenOne + 1 < Choices.Count)
            {
                IndexOfTheChosenOne++;
                ResetChosenOne();
            }
        }
        public void GoDown()
        {
            if (IndexOfTheChosenOne - 1 < 0)
            {
                IndexOfTheChosenOne--;
                ResetChosenOne();
            }
        }
    }
}
