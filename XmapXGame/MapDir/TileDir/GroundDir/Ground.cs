using System;
using System.Collections.Generic;
using System.Text;

namespace XmapXGame
{
    class Ground
    {

        public Groundtype type { get => type; set => type = value; }


        public Ground generateRandomGround()
        {
            Groundtype[] groundtypes = new Groundtype().getGroundtypes();

            return new Ground { type = new Groundtype { image = groundtypes[new Random().Next(0, groundtypes.Length)].image } };
        }

    }
}
