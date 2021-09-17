using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class House : Building
    {

        public House() { }

        private Image image = Properties.Resources.sand_50x50; // !
        public Image Image { get => image; set => image = value; }

    }
}
