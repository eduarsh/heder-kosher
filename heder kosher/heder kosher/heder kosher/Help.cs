using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public static class Help
    {
        public static int RandomNumber(int len)
        {
            Random random = new Random();
            return random.Next((int)Math.Pow(10, len - 1),(int) Math.Pow(10, len) - 1);//generating numbers in the length recieved
        }


    }
}
