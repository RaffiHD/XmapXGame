using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XmapXGame
{
    class Draw : Form
    {

        private Graphics graphics;

        public Draw()
        {

        }

        public Graphics Graphics { get => graphics; set => graphics = value; }

        public void drawMap()
        {

            List<List<Tile>> map = new Map().map;
            if (map.Count == 0)
            {
                return;
            }

            foreach (List<Tile> tileRow in map)
            {

                foreach (Tile tile in tileRow)
                {

                    drawTile(tile.location, tile.ground.type.image);
                }
            }

        }

        public void drawTile(Point location, Image image)
        {
            graphics.DrawImage(image, location);

        }

    }
}
