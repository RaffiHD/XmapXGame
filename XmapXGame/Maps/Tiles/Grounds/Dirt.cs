using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Dirt : Ground
    {

        public Dirt() { }

        private string _name = "Dirt";
        public string _Name { get => _name; }

        private Image _image = Properties.Resources.dirt_50x50;
        public Image _Image { get => _image; set => _image = value; }
    }
}
