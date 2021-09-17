using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Sand : Ground
    {
        public Sand(){}

        private string name = "Sand";
        public string Name { get => name; }

        private Image _image = Properties.Resources.sand_50x50;

        public Image _Image { get => _image; set => _image = value; }
    }
}
