using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Object : Tile
    {

        public Object() { }

        private Object _category;
        public Object _Category { get => _category; set => _category = value; }

        private Image _picture = null;
        public Image _Picture { get => _picture; set => _picture = value; }
    }
}
