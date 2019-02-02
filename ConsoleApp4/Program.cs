using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility.ConvertIpToNumber(ip: "192.168.3.40");//این متد از کلاس استاتیک فراخوانی شده و آی پی را بعنوان پارامتر ورودی به صورت الزامی دریافت می کند 
            Utility.ConvertNumberToIP(ip: 3232236328); // این متد 

            Console.WriteLine("Press [ ENTER ] To Exit ... ");
            Console.ReadLine();
        }
    }
}
