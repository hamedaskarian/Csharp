using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     public static class Utility
    {
        /// <summary>
        /// این متد ، آی پی را بعنوان پارامتر ورودی دریافت کرده و عدد منتاظر آن را محاسبه و چاپ می کند
        /// </summary>
        /// <param name="ip"></param>
        public static void ConvertIpToNumber(string ip)
        {
            string[] parts = ip.Split('.');
            Int32.TryParse(parts[0], out int part01); // converts ip's first part number from string to int
            Int32.TryParse(parts[1], out int part02); // converts ip's second part number from string to int
            Int32.TryParse(parts[2], out int part03); // converts ip's third part number from string to int
            Int32.TryParse(parts[3], out int part04); // converts ip's fourth part number from string to int

            ///<summary>
            ///اعداد آی پی را به صورت مجزا چاپ میکند . صرفا جهت رویت و اطلاع از صحت آی پی 
            /// </summary>
            //Console.WriteLine("your ip parts are : ");
           // Console.WriteLine(parts[0]);
           // Console.WriteLine(parts[1]);
            //Console.WriteLine(parts[2]);
            //Console.WriteLine(parts[3]);


            Int64 power3 = 16777216;// 256 ^ 3 توان 3 عدد256 که همان توان 24 عدد 2 است را داخل متغیر می ریزد 
            Int64 power2 = 65536;// 256 ^ 2  توان 2 عدد 265 که همان توان 16 عدد 2 است را داخل متغیر می ریزد
            Int64 power1 = 256; // 256 ^ 1   عدد 256 که توان 8 عدد 2 است را داخل متغیر می ریزد 
            Int64 numberPart01 = part01 * power3;
            Int64 numberPart02 = part02 * power2;
            Int64 numberPart03 = part03 * power1;
            Int64 numberFinal = numberPart01 + numberPart02 + numberPart03 + part04; // اعداد بدست آمده را باهم جمع می کند و به حاصل نهایی می رسد 
            Console.WriteLine($"The number is: { numberFinal }"); // حاصل نهایی را چاپ می کند 
            
        }

        public static void ConvertNumberToIP  (Int64 ip)
        {


            ///<summary>
            ///توضیح اینکه در حقیقت هر آی پی ، شامل 4 قسمت 8 بیتی است. 
            ///ما در هر مرحله یکی از این قسمت های 8 بیتی را به اندازه ای به سمت راست شیفت می دهیم که در بایت اول قرار بگیرد و در دسترس ما باشد
            ///سپس آن را با یک بایت کامل پر 11111111 اند بایتی می کنیم که خود آن عدد 8 بیتی به ما برگردد
            ///بایت کامل 11111111 معادل عدد دسیمال 255 میباشد 
            ///به همین دلیل آن را به راحتی با 255 اند می کنیم 
            /// </summary>
            Int64 byte01 = (ip >> 24) & 255; // قسمت اول - سمت چپ - آی پی را به اندازه 24 بیت به سمت راست شیفت می دهیم و با 255 اند بایتی می کنیم که خود آن عدد به ما برگردد
            Int64 byte02 = (ip >> 16) & 255; // قسمت دوم آی پی را به میزان 16 بیت به سمت راست شیفت می دهیم که به بایت اول برود. سپس آن را با 255 اند بایتی می کنیم که خود آن عدد به ما برگردد
            Int64 byte03 = (ip >> 8) & 255; // قسمت سوم آی پی در بایت دوم قرار دارد . آن را یک بایت به سمت راست شیفت می دهیم که در بایت اول قرار بگیرد . سپس با 255 اند بایتی می کنیم که خود عدد به ما برگردد 
            Int64 byte04 = ip & 255; // آی پی را با 255 یا همان 11111111 اند بایتی میکنیم که عدد بیت اول را به ما برگرداند
            
            Console.Write("your ip is : ");
            Console.WriteLine($"{ byte01 }.{ byte02 }.{ byte03 }.{ byte04 }");// اعداد بدست آمده را به ترتیب و با گذاشتن "." بین آنها چاپ میکند که همان آی پی مورد نظر میشود

        }
    }
}
