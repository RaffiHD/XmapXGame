using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Water : Ground
    {

        public Water() { }

        private string name = "Water";
        public string Name { get => name; }

        private Image _image = Properties.Resources.water_50x50;

        public Image _Image { get => _image; set => _image = value; }
    }
}
