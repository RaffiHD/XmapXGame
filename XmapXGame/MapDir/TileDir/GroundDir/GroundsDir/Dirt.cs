using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Dirt : Groundtype
    {

        private string name = "Dirt";
        public string Name { get => name; set => name = value; }


        private Image image = Properties.Resources.dirt_50x50;

        public Image Image { get => image; set => image = value; }
    }
}
