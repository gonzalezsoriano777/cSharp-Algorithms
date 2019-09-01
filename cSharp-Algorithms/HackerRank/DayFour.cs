﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Class V Instance .. Object Oriented Concept
 * Created 3 Methods that will check if the age is validated
 * Whether there young, a teenager or is old
 * Incrementes the age to represent each year, age going up 1
*/

namespace cSharp_Algorithms.HackerRank
{
    public class DayFour
    {
  
        public int age;

        public void Age(int initialAge)
        {
            if(initialAge > 0)
            {
                age = initialAge;
            }
                else
                {
                    Console.WriteLine("Age is not acceptable. Setting age to 0.");
                }   
        }

        public void amIOld()
        {

            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
                if (age >= 13 && age < 18)
                {
                    Console.WriteLine("You are a teenager.");
                }
                    if (age >= 18)
                    {
                        Console.WriteLine("You are old");
                    }

        }

        public void yearPassing()
        {
            age++;
        }
    }
}