using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Groundtype
    {

        private string type;
        public string Type { get => type; set => type = value; }

        private Image picture;
        public Image Picture { get => picture; set => picture = value; }

        public List<Groundtype> getGroundtypes()
        {

            Dirt dirt = new Dirt();
            Grass grass = new Grass();
            Sand sand = new Sand();
            Water water = new Water();

            return new List<Groundtype> { new Groundtype { type = dirt.Name, picture = dirt.Image }, new Groundtype { type = grass.Name, picture = grass.Image }, new Groundtype { type = sand.Name, picture = water.Image }, new Groundtype { type = water.Name, picture = water.Image } };

        }

    }
}
