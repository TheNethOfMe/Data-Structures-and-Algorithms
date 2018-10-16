using System;
using System.Collections.Generic;
using System.Text;

namespace linkedList.Classes
{
    public class Cereal
    {
        public string Value { get; set; }
        public Cereal Next { get; set; }

        public Cereal(string value)
        {
            Value = value;
        }
    }
}
