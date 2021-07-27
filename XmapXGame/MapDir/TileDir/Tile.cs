using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Tile
    {

        private Point location; // e.g. (0,1)
        public Point Location { get => location; set => location = value; }

        private int size; // e.g. 50
        public int Size { get => size; set => size = value; }

        private Ground ground;
        public Ground Ground { get => ground; set => ground = value; }

        private Object objct;
        public Object Objct { get => objct; set => objct = value; }

        public Tile generateTile(Point location, int size, Ground ground, Object objct)
        {

            return new Tile { location = location, size = size, ground = ground, objct = objct };

        }

        public Tile generateTileRandom(Point location, int size)
        {

            return generateTile(new Point(/*1 +*/ (location.X - 1) * size, /*1 +*/ (location.Y - 1) * size), size, new Ground().generateRandomGround(), objct);

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