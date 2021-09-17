using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Map
    {
        public Map() { }

        private List<List<Tile>> _map = new List<List<Tile>>();
        public List<List<Tile>> _Map { get => _map; set => _map = value; }

        public Map generateMap(int tilesX, int tilesY, int size)
        {
            Tile tile = new Tile();

            List<List<Tile>> newMap = new List<List<Tile>>();

            for (int y = 0; y < tilesY; y++)
            {
                List<Tile> newTileRow = new List<Tile>();

                for (int x = 0; x < tilesX; x++)
                {
                    newTileRow.Add(tile.generateTile(new Point(x * size, y * size), size, new Ground().generateRandomGround()));
                }

                newMap.Add(newTileRow);
            }

            _Map = newMap;

            return this;
        }

        public void loadMap()
        {
            // return = ...
        }

        public void saveMap(Map map)
        {
            // ...
        }

    }
}
