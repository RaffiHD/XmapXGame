using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Map
    {
        public List<List<Tile>> map
        {
            get => map; set => map = value;
        }

        public Map()
        {
            map = new List<List<Tile>>();
        }


        public void generateMap(int tilesX = 10, int tilesY = 10)
        {
            Tile tile = new Tile();

            List<List<Tile>> newMap = new List<List<Tile>>();

            for (int y = 0; y < tilesY; y++)
            {
                List<Tile> newTileRow = new List<Tile>();

                for (int x = 0; x < tilesX; x++)
                {
                    newTileRow.Add(tile.generateTileRandom(new Point(x, y)));
                }

                newMap.Add(newTileRow);
            }

            map = newMap;
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
