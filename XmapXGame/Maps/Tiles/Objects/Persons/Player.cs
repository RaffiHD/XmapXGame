using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Player : Person
    {

        public Player() { }

        private int _level = 1;
        public int _Level { get => _level; set => _level = value; }

        private Image _image = Properties.Resources.character_50x50_transparent;
        public Image _Image { get => _image; set => _image = value; }
    }

}
