﻿using System;

namespace NonPrimitiveTypes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi! My name is " + FirstName + " " + LastName);
        }
    }
}
