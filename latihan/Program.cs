using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace latihan
{
    class Program
    {

        static void BelajarInput()
        {
            // belajar memasukan inputan
            Console.WriteLine("==============APLIKASI KEREN=====================");
            Console.Write("MASUKAN NAMA ANDA : ");
            string hai = Console.ReadLine();
            Console.WriteLine("SELAMAT DATANG , {0}", hai);
        }

        static void LuasLingkaran()
        {
            //menentukan luas lingkaran
            
             const double pi = 3.14;
             double radius;

            Console.Write("Masukan Jari - jari lingkaran: ");
             radius = Convert.ToDouble(Console.ReadLine());
             double circle = pi * radius * radius;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Luas Lingkaran tersebut adalah, {0}", circle);
        }


        static void Kalkulator()
        {
            //membuat kalkulator sederhana
            Console.WriteLine("<================KALKULATOR===================>");
            Console.Write("Masukan Angka Pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Ke dua: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukan Operator: ");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("5. %");
            Console.WriteLine("<-------------------------------------------->");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("<-------------------------------------------->");
            int hasil;

            switch (opt)
            {
                case 1:
                    hasil = a + b;
                    Console.WriteLine("Hasilnya adalah");
                    Console.WriteLine(hasil);
                    break;
                case 2:
                    hasil = a - b;
                    Console.WriteLine("Hasilnya adalah");
                    Console.WriteLine(hasil);
                    break;
                case 3:
                    hasil = a * b;
                    Console.WriteLine("Hasilnya adalah");
                    Console.WriteLine(hasil);
                    break;
                case 4:
                    hasil = a / b;
                    Console.WriteLine("Hasilnya adalah");
                    Console.WriteLine(hasil);
                    break;
                case 5:
                    hasil = a % b;
                    Console.WriteLine("Hasilnya adalah");
                    Console.WriteLine(hasil);
                    break;
            }

            Console.WriteLine("--------------------------------------------");
          
        }

        static void BilPrima()
        {
            //menentukan sebuah bilangan termasuk prima atau tidak
            Console.WriteLine("<================Cek Bilangan prima===================>");


            Console.Write("Masukan Angka: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int hitung = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {

                    hitung++;
                }
            }

            if (hitung == 2)
            {
                Console.WriteLine("Bilangan Prima");
            }
            else
            {
                Console.WriteLine("Bukan Bilangan Prima");
            }
            
        }

        static void Pitagoras()
        {
            Console.WriteLine("<================BILANGAN PITAGORAS===================>");

            Console.Write("Masukan Angka Pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan Angka Kedua: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan Angka Ketiga: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double tinggi = Math.Pow(a,2);
            double alas = Math.Pow(b, 2);
            double miring = Math.Pow(c, 2);

            double pitagoras = tinggi + alas;
            Console.WriteLine("--------------------------------------------");
            if (pitagoras == miring)
            {
                Console.WriteLine("Ini PITAGORAS");
            } else {
                Console.WriteLine("Bukan Pitagoras");
            }  
        }


        static void ContohModul1()
        {
           
            Console.Write("Masukan Angka: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double hasil = a % 15;

            Console.WriteLine(hasil);
        }

        static void ContohModul2()
        {
            
            Console.Write("Masukan Angka: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double hasil = a % 15;

            Console.WriteLine(hasil);
        }

        static void ContohModul3()
        {
            
            int age = 42;
            string msg;
            msg = (age >= 18) ? "Welcome" : "Sorry";
            Console.WriteLine(msg);
        }

        static void ContohModul4()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }

        


        static void Main(string[] args)
        {
          
            Console.WriteLine("============================APLIKASI SUPER==================================");
            Console.WriteLine("1. Belajar Input");
            Console.WriteLine("2. Luas Lingkaran");
            Console.WriteLine("3. Kalkulator");
            Console.WriteLine("4. Bilangan Prima");
            Console.WriteLine("5. Bilangan Pitagoras");
            Console.WriteLine("6. Contoh Modul 1");
            Console.WriteLine("7. Contoh Modul 2");
            Console.WriteLine("8. Contoh Modul 3");
            Console.WriteLine("9. Contoh Modul 4");
            Console.Write("Silahkan Pilih Menu: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("<-------------------------------------------->");
            switch (pilihan)
            {
                case 1:
                    BelajarInput();
                    break;


                case 2:
                    LuasLingkaran();
                    break;

                case 3:
                    Kalkulator();
                    break;

                case 4:
                    BilPrima();
                    break;

                case 5:
                    Pitagoras();
                    break;

                case 6:
                    ContohModul1();
                    break;

                case 7:
                    ContohModul2();
                    break;

                case 8:
                    ContohModul3();
                    break;

                case 9:
                    ContohModul4();
                    break;
            }
            


        }



    }
}