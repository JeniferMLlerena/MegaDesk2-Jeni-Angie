using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2_Jeni_Angie
{
    //change class to struct for MegaDesk2
    public struct Desk
    {
        public enum Desktop
        {
            Laminate,
            Oak,
            Pine,
            Rosewood,
            Veneer
        }

        public decimal width { get; set; }

        public decimal depth { get; set; }

        public int numOfDrawers { get; set; }

        public Desktop DesktopMaterial { get; set; }
    }
}
