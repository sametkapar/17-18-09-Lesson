using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik m = new Matematik();
            m.sayi1 = 45;
            m.sayi2 = 15;
            int toplam = m.sayi1 + m.sayi2;
            Console.WriteLine(toplam);

            Fizik<int> f = new Fizik<int>();
            f.sayi1 = 45;
            f.sayi2 = 15;
            int toplam2 = f.sayi1 + f.sayi2;
            Console.WriteLine(toplam2);

            Fizik<double> f2 = new Fizik<double>();
            f2.sayi1 = 45.3;
            f2.sayi2 = 15.6;
            double toplam3 = f2.sayi1 + f2.sayi2;
            Console.WriteLine(toplam3);

            Kimya<string,int> molekul = new Kimya<string,int>();
            molekul.s1 = "Hidrojen";
            molekul.s2 = 1;

            Kimya<double, string> molekul2= new Kimya<double, string>();
            molekul2.s1 = 1.3;
            molekul2.s2 = "Murtazarmiyum";
        }
    }
    class Matematik
    {
        public int sayi1;
        public int sayi2;
    }
    class Fizik<T>
    {
        public T sayi1;
        public T sayi2;
        public double sayi3;
    }
    class Kimya<K, T>
    {
        public K s1;
        public T s2;

        //public void Topla()
        //{
        //    s1 + s2;
        //}

        //public void Topla(T s3, K s4)
        //{
        //    s3 + s4;
        //}
    }
}
