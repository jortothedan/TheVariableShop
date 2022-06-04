using System;

namespace TheVariableShop
{
    class Program
    {
        static void Main(string[] args)
        {
            byte aByte = 255;
            short aShort = 30_000;
            int anInt = 2_000_000;
            long aLong = 9_000_000_000_000_000_000;
            sbyte signedByte = 127;
            ushort unsignedShort = 60_000;
            uint unsignedInt = 4_000_000_000;
            ulong unsignedLong = 18_000_000_000_000_000_000;
            float aFloat = 1.1234567F;
            double aDouble = 1.12345678901234;
            decimal aDecimal = 1.123455678901234567890M;
            bool aBoolean = true;

            aBoolean = false;

            Console.WriteLine("Here's all our variables:");
            Console.WriteLine("A Byte: " + aByte);
            Console.WriteLine("A Short: " + aShort);
            Console.WriteLine("An Int: " + anInt);
            Console.WriteLine("A Long: " + aLong);
            Console.WriteLine("A signed Byte: " + signedByte);
            Console.WriteLine("An unsigned Short: " + unsignedShort);
            Console.WriteLine("An unsigned Int: " + unsignedInt);
            Console.WriteLine("An unsigned Long: " + unsignedLong);
            Console.WriteLine("A Float: " + aFloat);
            Console.WriteLine("A Double: " + aDouble);
            Console.WriteLine("A Decimal: " + aDecimal);
            Console.WriteLine("A Boolean: " + aBoolean);
            Console.WriteLine("Choose any one you need!");
        }
    }
}
