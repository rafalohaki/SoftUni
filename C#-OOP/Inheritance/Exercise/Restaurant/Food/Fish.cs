﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food
{
    public class Fish : MainDish
    {
        private const double fishGrams = 22;

        public Fish(string name, decimal price)
            : base(name, price, fishGrams)
        {

        }
    }
}
