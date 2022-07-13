using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDI
{
    public class Horn
    {
        public void Beep() => Console.WriteLine("Beep - beep - beep ...");
    }

    public class Car
    {
        // horn là một Dependecy của Car
        Horn horn;

        // dependency Horn được đưa vào Car qua hàm khởi tạo
        public Car(Horn horn) => this.horn = horn;

        public void Beep()
        {
            // Sử dụng Dependecy đã được Inject
            horn.Beep();
        }


        //sua horn
        /*
         * public class Horn {
           int level; // thêm độ lớn còi xe
           public Horn (int level) => this.level = level; // thêm khởi tạo level

           public void Beep () => Console.WriteLine ("Beep - beep - beep ...");
}
         */

    }
}
