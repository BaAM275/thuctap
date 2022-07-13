using System;

namespace UseDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horn horn = new Horn();

            var car = new Car(horn); // horn inject vào car
            car.Beep(); // Beep - beep - beep ...
        }
    }
}
