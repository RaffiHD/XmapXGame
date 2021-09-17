using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XmapXGame
{
    class Person : Object
    {

        public Person() { }

        private string _name = "Player";
        public string _Name { get => _name; set => _name = value; }

        private Person _personType;
        public Person _PersonType { get => _personType; set => _personType = value; }

    }
}
