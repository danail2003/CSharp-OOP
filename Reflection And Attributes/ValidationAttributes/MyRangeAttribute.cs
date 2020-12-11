﻿using System;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            int value = (int)obj;

            if(value >= minValue && value <= maxValue)
            {
                return true;
            }

            return false;
        }
    }
}
