﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender)
            : base(name, age, gender)
        {
            base.Gender = "Male";
        }
        
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
