using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Tile
    {

        public Point location { get => location; set => location = value; } // e.g. (0,1)

        public int size { get => size; set => size = value; } // e.g. 50

        public Ground ground { get => ground; set => ground = value; }

        public Object objct { get => objct; set => objct = value; }



        public Tile generateTile(Point location, int size, Ground ground, Object objct)
        {

            return new Tile { location = location, size = size, ground = ground, objct = objct };

        }

        public Tile generateTileRandom(Point location, int size = 50)
        {

            return generateTile(location, size, new Ground().generateRandomGround(), objct);

        }


    }
}
