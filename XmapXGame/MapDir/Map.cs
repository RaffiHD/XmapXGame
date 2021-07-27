using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Map
    {

        public List<List<Tile>> generateMap(int tilesX, int tilesY, int size)
        {
            Tile tile = new Tile();

            List<List<Tile>> newMap = new List<List<Tile>>();

            for (int y = 0; y < tilesY; y++)
            {
                List<Tile> newTileRow = new List<Tile>();

                for (int x = 0; x < tilesX; x++)
                {
                    newTileRow.Add(tile.generateTileRandom(new Point(x+1, y+1), size));
                }

                newMap.Add(newTileRow);
            }

            return newMap;
        }

        public void loadMap()
        {
            // map = ...
        }

        public void saveMap()
        {
            // ... = map
        }

    }
}
