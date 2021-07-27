using System;
using System.Collections.Generic;
using System.Text;

namespace XmapXGame
{
    class Ground
    {

        private Groundtype type;
        public Groundtype Type { get => type; set => type = value; }

        public Ground generateRandomGround()
        {
            List<Groundtype> groundtypes = new Groundtype().getGroundtypes();
            int number = new Random().Next(0, groundtypes.Count);

            return new Ground { Type = new Groundtype { Type = groundtypes[number].Type, Picture = groundtypes[number].Picture } };

        }

    }
}
