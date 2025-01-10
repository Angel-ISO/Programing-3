using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week1Laboratorie.models
{
    public class DataTypes
    {
          public short ConvertIntToShort(int number)
        {
            return (short)number;
        }

        public long ConvertIntToLong(int number)
        {
            return (long)number;
        }

        public int ConvertFloatToInt(float floatNumber)
        {
            return (int)floatNumber;
        }

        public float ConvertIntToFloat(int number)
        {
            return (float)number;
        }

        public double ConvertIntToDouble(int number)
        {
            return (double)number;
        }

        public string ConvertBoolToString(bool booleanValue)
        {
            return booleanValue.ToString();
        }

        public int ConvertStringToInt (string stringValue)
        {
            return int.Parse(stringValue);
        }

        public object Boxing(int number)
        {
            return number; 
        }

        public int Unboxing(object boxedObject)
        {
            return (int)boxedObject;  
        }
    }

        
}
