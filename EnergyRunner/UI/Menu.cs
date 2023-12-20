﻿using System;
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
        }
        public void DisplayMenu()
        {

        }

    }
}
