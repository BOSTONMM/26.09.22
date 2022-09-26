using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._09._22
{
    internal class Program
    {
        //private static double alas, tinggi;
        //private static string nama;

        static void Main(string[] args)
        {
            //Program cs = new Program();

            //Console.Write("masukkan alas : ");
            //alas = double.Parse(Console.ReadLine());

            //Console.Write("masukkan tinggi : ");
            //tinggi = double.Parse(Console.ReadLine());

            //Console.WriteLine("");

            //int[]  arr = new int[] { 34,55,200,100 };

            ////built in method. 
            //arr.Max();

            //nama = "alfanny zhandra";

            //Console.WriteLine(nama.ToUpper());


            //Console.WriteLine(); //SPASI. 
            //string kelas = "3B";

            //Console.WriteLine("tampilan kelas adalah : " + kelas);

            //Console.WriteLine(Equals(34,56));

            //call method/ panggil method. 
            Identitas();

            Console.Write("Masukkan nilai a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai b : ");
            int b = int.Parse(Console.ReadLine());

            //penjumlahan
            Console.WriteLine(Penjumlahan(a, b));

            //perkalian

            //pengurangan

            //pembagian

            //pemodulasian.
        }

        //ini static non-void.
        public static int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        //ini static void. => tidak ada return value.
        public static void Identitas()
        {
            string nama = "alfanny zhandra".ToUpper().ToLower();
            Console.WriteLine($"Nama saya {nama}, saya jomblo.\n\n");
        }

        //user define.
        public static double LuasSegitiga(double alas, double tinggi ) 
        {
            var Luas = 0.5 * alas * tinggi;

            return Luas;
        }


    }
}
