using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyRunner.UI
{
    internal class Choice
    {
        public bool isChosen { get; set; }
        public string label { get; set; }
        public Choice(string label)
        {
            this.label = label;
        }
    }
}
