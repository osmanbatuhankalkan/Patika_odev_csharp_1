using System;
namespace patika.net_çalışması
{
    class program
    {
        public static void Main(string[] args)
        {
            int deger =2;
            Console.WriteLine(deger);
            
            int deger2 = 10;
            int deger3 = deger2 * deger;
            Console.WriteLine(deger3);

            bool sonuc = deger > 10; 
            Console.WriteLine(sonuc);

            float a = 5.4f;
            Console.WriteLine(a);

            decimal b = 9.99m;
            Console.WriteLine(b);

            char ch = '2';
            Console.WriteLine(ch);

            string str = "Kalkan";
            Console.WriteLine(str);
            
            DateTime dt = DateTime.Now; 
            Console.WriteLine(dt);

            object o1 = "o";
            object o2 = "s";
            object o3 = "m";
            object o4 = "a";
            object o5 = "n";
            string k= o1 + " " + o2 + " " + o3 + " " + o4 + " " + o5;
            Console.WriteLine(k);

            object o6 = 5;
            object o7 = 9;
            object o8 = 7;
            object o9 = 11;
            string l = o6 +" "+ o7 + o8 + o9;
            Console.WriteLine(l);
            
            string b1 = "Osman";
            string  b2 = "Batuhan";
            string  b3 = "Kalkan";
            string ad = b1 + " " + b2;
            string soyad = "kalkan";
            string tamIsim = ad + " " + soyad;
            Console.WriteLine(tamIsim);
            
            int integer1 = 34;
            int integer2 = 654;
            int integer3 = integer1 * integer2;
            Console.WriteLine(integer3);
            
            
            string str99 = "99";
            int int33 = 33;
            string yeniDeger = str99 + int33.ToString();
            Console.WriteLine(yeniDeger);
            
            int int44 = int33 + Convert.ToInt32(str99);
            Console.WriteLine(int44);

            int int22 = int33 + int.Parse(str99);
            Console.WriteLine(int22);






        }
    }
}