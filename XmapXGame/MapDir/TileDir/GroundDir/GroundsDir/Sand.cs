using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Sand : Groundtype
    {

        private string name = "Sand";
        public string Name { get => name; set => name = value; }

        private Image image = Properties.Resources.sand_50x50;

        public Image Image { get => image; set => image = value; }
    }
}
