﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CreatingConstructors
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age)
            :this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            :this(age)
        {
            this.Name = name;
        }
    }
}
