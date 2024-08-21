using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Object Veri Türü Nedir

            ////Her tür object türünden doğar
            ////Object içindeki verinin türünüde tutar

            //int sayi = 45;
            //object veri = 45;

            //veri = "Murtaza";
            //veri = sayi;

            ////veri += 45; //çalışmaz

            //Console.WriteLine("int = " + sayi);
            //Console.WriteLine("onject = " + veri);


            #endregion

            #region Boxing UnBoxing

            //int sayi = 45; // cast yapamayız

            //object obj = sayi;//Herhangi bir türdeki verinin object türündeki değişkene atılması olayına Boxing denir.

            //int sayi2 = (int)obj; //Object içerisindei verinini kendi türünde çıkartılmasına UnBoxing denir.

            //string strsayi2 = (string)obj;//InvalidCastException

            //string strsayi3 = Convert.ToString(obj);

            //Console.WriteLine(sayi2 + 2);

            //Console.WriteLine(strsayi3);

            //Console.WriteLine(strsayi2);

            #endregion

            #region typeOf ve getType

            int sayi = 15;

            Console.WriteLine(sayi.GetType());

            object obj = sayi;
            Console.WriteLine(obj.GetType());

            object obj2 = "Murtaza";
            Console.WriteLine(obj2.GetType());

            obj2 = obj;
            Console.WriteLine(obj2.GetType());

            Turbo tb = new Turbo();
            tb.marka = "Fiat";
            tb.hacim = "45";
            obj2 = tb;

            //string veri = (string)obj2;
            
            if(obj2.GetType() == typeof(string))
            {
                string str = (string)obj2;
                Console.WriteLine(str);
            }
            else if(obj2.GetType() == typeof(int))
            {
                int sayi3 =(int)obj2;
                sayi3 += 45;
                Console.WriteLine(sayi3);
            }
            else if (obj2.GetType() == typeof(Turbo))
            {
                Turbo tt = (Turbo)obj2;
                Console.WriteLine(tt.marka);
                Console.WriteLine(tt.hacim);
            }
            #endregion


        }
    }
    public class Turbo
    {
        public string marka;
        public string hacim;
    }
}
