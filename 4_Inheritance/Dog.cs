﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpStarttoFinish._4_Inheritance
{
    class Dog :Animal
    {
        
        public string Sound2 { get; set; } = "Grrrrr";

        // You can overwrite methods by adding new
        /*
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        */

        // Add override so that the correct method
        // is called when a Dog is created as an
        // Animal type
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }


        // Create a constructor that has the base 
        // constructor initialize everything except 
        // Sound2
        public Dog(string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No Sound 2")
            : base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}
