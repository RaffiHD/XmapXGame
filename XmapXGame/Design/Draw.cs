using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XmapXGame
{
    class Draw
    {

        FormGame formGame;

        public Draw(FormGame form)
        {
            formGame = form;
        }

        public FormGame drawMap(Map map)
        {

            if (map._Map.Count > 0)
            {

                foreach (List<Tile> tileRow in map._Map)
                {

                    foreach (Tile tile in tileRow)
                    {

                        drawTile(tile);
                    }
                }
            }

            return formGame;

        }

        public void drawTile(Tile tile)
        {

            if (tile._Ground != null)
            {
                formGame.drawImage(tile._Location, tile._Ground._Picture); // draw ground

            }

            if (tile._Objct != null)
            {
                formGame.drawImage(tile._Location, tile._Objct._Picture); // draw object

            }


        }

    }
}
