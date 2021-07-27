using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Grass : Groundtype
    {

        private string name = "Grass";
        public string Name { get => name; set => name = value; }

        private Image image = Properties.Resources.grass_50x50;

        public Image Image { get => image; set => image = value; }
    }
}
