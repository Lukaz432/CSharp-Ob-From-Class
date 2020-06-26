using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class GameClasses
    {

        public class Thing
        {

            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            private string _description;

            public string Description
            {
                get { return _description; }
                set { _description = value; }
            }

            public Thing(string aName, string aDescription)
            {
                _name = aName;
                _description = aDescription;
            }
        }

        public class Treasure : Thing
        {
            private double _value;

            public double Value
            {
                get { return _value; }
                set { _value = value; }
            }

            public Treasure(string aName, string aDescription, double aValue)
                : base(aName, aDescription)
            {
                _value = aValue;
            }
        }
    }
}
