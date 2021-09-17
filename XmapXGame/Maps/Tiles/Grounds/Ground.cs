using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Ground
    {

        public Ground() { }

        private Ground _type = null;
        public Ground _Type { get => _type; set => _type = value; }

        private Image _picture = null;
        public Image _Picture { get => _picture; set => _picture = value; }

        private enum grounds { Dirt, Grass, Sand, Water };

        public Ground generateRandomGround()
        {

            grounds groundRandom = (grounds)new Random().Next(0, System.Enum.GetValues(typeof(grounds)).Length);

            switch (groundRandom)
            {
                case grounds.Dirt:
                    return new Ground { _type = (Ground)new Dirt(), _picture = new Dirt()._Image };
                case grounds.Grass:
                    return new Ground { _type = (Ground)new Grass(), _picture = new Grass()._Image };
                case grounds.Sand:
                    return new Ground { _type = (Ground)new Sand(), _picture = new Sand()._Image };
                case grounds.Water:
                    return new Ground { _type = (Ground)new Water(), _picture = new Water()._Image };
            }
            return new Ground { _type = null, _picture = null };

        }

    }
}
