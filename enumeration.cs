using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    internal class enumeration
    {
        
        public enum days
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }
        public void day_count()
        {
            foreach(string day in Enum.GetNames(typeof(days)))
            {
                Console.WriteLine(day);
            }
            //int a = (int)days.monday;
            //Console.WriteLine(a);
        }



    }
}

    

