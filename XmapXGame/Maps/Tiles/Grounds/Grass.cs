using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Grass : Ground
    {
        public Grass() { }

        private string name = "Grass";
        public string Name { get => name; }

        private Image _image = Properties.Resources.grass_50x50;
        public Image _Image { get => _image; set => _image = value; }
    }
}
