using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Water : Groundtype
    {

        private string name = "Water";
        public string Name { get => name; set => name = value; }

        private Image image = Properties.Resources.water_50x50;

        public Image Image { get => image; set => image = value; }
    }
}
