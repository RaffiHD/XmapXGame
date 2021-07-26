using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Groundtype
    {

        public Image image { get => image; set => image = value; }

        public Groundtype[] getGroundtypes()
        {

            return new Groundtype[] { (Groundtype)new Dirt(), (Groundtype)new Grass(), (Groundtype)new Sand(), (Groundtype)new Water() };


        }

    }
}
