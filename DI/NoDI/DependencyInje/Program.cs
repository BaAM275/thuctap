using System;

namespace DependencyInje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horn horn = new Horn(10);     // Khởi tạo với Horn với tham số level
            horn.Beep();
        }
    
    }
}
