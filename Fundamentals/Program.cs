﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class AudiCar
    {
        public AudiCar(int loc, int make, int model)

        // Learned to create strings that can be called through the console, must be outside of the Main func. to be properly called

        // Private strings that can only be used in this class
        private string location;
        private string make;
        private string model;

        
        // Used GET and SET on both location and model to get both of them and assign them to a value assigned
        // This method is called encapsulation

        public string Location
        {
            get => location; set => location = value;
        }

        public string Model
        {
            get => model; set => model = value;
        }

        public string Make 
        {
            get => make; set => make = value;
        }

        static void Main(string[] args)
        {

            // New AudiCar object
            AudiCar myAudi = new AudiCar();
            
            Console.WriteLine("Welcome to your new and improved Audi, sent and made from Germany!");

        }

        // Following code are all public classes



    }
}
