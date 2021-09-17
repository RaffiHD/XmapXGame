using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Tile
    {

        public Tile() { }

        private Point _location; // e.g. (0,1)
        public Point _Location { get => _location; set => _location = value; }

        private int _size; // e.g. 50
        public int _Size { get => _size; set => _size = value; }

        private Ground _ground;
        public Ground _Ground { get => _ground; set => _ground = value; }

        private Object _objct;
        public Object _Objct { get => _objct; set => _objct = value; }

        public Tile generateTile(Point location, int size, Ground ground, Object objct = null)
        {

            return new Tile { _location = location, _size = size, _ground = ground, _objct = objct };

        }

    }
}

/*
 * size 50
 * 1,1 = 1,1
 * 2,1 = 51,1
 * 3,1 = 101,0
 * 
 * 
 * */