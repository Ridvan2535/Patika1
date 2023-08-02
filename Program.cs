using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; //1 byte
            sbyte c = 5; //1 byte

            short s = 5;    //2 byte
            ushort us = 5;  //2 byte

            Int16 i16 = 2;  //2 byte
            int i = 2;      //4 byte
            Int32 i32 = 2;  //4 byte
            Int64 i64 = 2;  //8 byte

            uint ıi = 2;    //4 byte
            long L = 4;     //8 byte
            ulong ul = 4;   //8 byte

            //reel sayılar
            float f = 5;    //4 byte
            double d = 5;   //8 byte
            decimal de = 5; //16 byte

            char ch = '2';  //2 byte
            string str = "ridvan";  //sınırsız

            bool b1=true;
            bool b2=false;

            DateTime dt= DateTime.Now;  //Çalıştığı anın tarih ve saati gelir.
            
            object o1 = "x";
            object o2 = 's';
            object o3 = 3;
            object o4 = 4.2;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "ridvan";
            string ad = "ridvan";
            string soyad = "hakkioglu";
            string tamisim = ad + " " + soyad;

            //Integer tanımlama şekilleri
            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;

            //boolean
            bool bol1 = 10 < 2;

            //degisken dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yenideger= str20+int20.ToString();
            Console.WriteLine(yenideger);


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20); //çıktısı 40
            //parse stringden dönüşüm için kullanılır


            //date Time
            string dateTime= DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);
            
            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            Console.ReadLine();
        }
    }
}
