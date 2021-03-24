using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablo.Olusturma
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Kaç öğrenci kayıt etmek istiyorsunuz?");
            byte mevcut = byte.Parse(Console.ReadLine());

            string[,] oğrenciler = new string[mevcut + 1, 6];
            oğrenciler[0, 0] = "Ad";
            oğrenciler[0, 1] = "Soyad";
            oğrenciler[0,2] = "Vize";
            oğrenciler[0, 3] = "Final";
            oğrenciler[0, 4] = "Ortalama";
            oğrenciler[0, 5] = "Harf";

            for (int i = 1; i < oğrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < oğrenciler.GetLength(1); j++)
                {
                    switch (j)
                    {

                        case 0:
                            Console.WriteLine("Ad giriniz:");
                            break;
                        case 1:
                            Console.WriteLine("Soyad giriniz:");
                            break;
                        case 2:
                            Console.Write("Vize notunu giriniz:");
                            break;
                        case 3:
                            Console.Write("Final notunu giriniz:"); 
                            break;
                        case 4:
                            Console.Write("Ortalamayı giriniz:");
                            break;
                        case 5:
                            Console.Write("Harf notunu giriniz:");
                            break;
                        default:
                            break;
                    }
                    oğrenciler[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < oğrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < oğrenciler.GetLength(1); j++)
                {
                    Console.Write(oğrenciler[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
