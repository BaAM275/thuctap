using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInje
{
   /*

    public class Car
    {
        public void Beep()
        {
            // chức năng Beep xây dựng có định với Horn
            // tự tạo đối tượng horn (new) và dùng nó
            Horn horn = new Horn();
            horn.Beep();
        }
    }
   */

    // khi sua horn
    public class Horn
    {
        int level; // độ lớn của còi xe
        public Horn(int level) => this.level = level; // thêm khởi tạo level
        public void Beep() => Console.WriteLine($"(level {level}) Beep - beep - beep ...");
    }
    
}
