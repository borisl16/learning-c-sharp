﻿using System;
            // Declare some basic value type variables


            var i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // TODO: Declare an array of values
                int[] vals = new int[5];
                string[] strs = {"one", "two", "three"};

            // TODO: Print the values using a Formatting String
            // Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i,c,b,str,f,d,x);

            // TODO: "null" means "no value"
            object obj = null;
            Console.WriteLine(obj);

            // TODO: Implicit conversion between types
                long bignum;
                bignum =i;

            // TODO: Explicit conversions
            float i_to_f = (float)i;
            Console.WriteLine(i_to_f);

            int f_to_i = (int)f;
            Console.WriteLine(f_to_i);
