using System.Numerics;

byte[] byteArray = { 2, 255};
BigInteger newBigInt = new BigInteger(byteArray);
Console.WriteLine("The value of newBigInt is {0} (or 0x{0:x}).", newBigInt);
Console.WriteLine($"hex {Int64.MaxValue ^ 7}.");