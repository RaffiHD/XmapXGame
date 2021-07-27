using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XmapXGame
{
    class Draw
    {

        XmapXGame.FormGame formGame;

        public Draw(XmapXGame.FormGame form)
        {
            formGame = form;
        }

        public void drawMap(List<List<Tile>> map)
        {

            if (map.Count > 0)
            {

                foreach (List<Tile> tileRow in map)
                {

                    foreach (Tile tile in tileRow)
                    {

                        drawTile(tile.Location, tile.Ground.Type.Picture);
                    }
                }
            }
        }

        public void drawTile(Point location, Image image)
        {
            formGame.drawImage(location, image);
        }

    }
}
