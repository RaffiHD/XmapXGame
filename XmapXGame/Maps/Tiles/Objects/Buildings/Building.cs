using System;
using System.Collections.Generic;
using System.Text;

namespace XmapXGame
{
    class Building : Object
    {
        public Building() { }

        private object type;
        public Building(House BuildingType) { type = BuildingType; }

        public object GetBuilding() { return type; }

    }
}
