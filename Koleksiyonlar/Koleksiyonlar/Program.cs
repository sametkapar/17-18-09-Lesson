using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //using.system.collecitons namespace'i içerisinde bulunurlar

            #endregion

            #region ArrayList

            //ArrayList liste = new ArrayList();

            //liste.Add(45);
            //liste.Add(85);
            //liste.Add(21);
            //liste.Add(-5);
            //liste.Add(111);
            //liste.Add(15.8);

            ////liste.Add("Sam");

            ////Urun u = new Urun();
            ////u.Marka = "Faber Castel";
            ////u.Model = "Kurşun 0,5";
            ////u.Fiyat = 250;

            ////liste.Add(u);

            //liste.AddRange(new int[] { 1, 19, -8, 45, 23, 67, 54 });
            //liste.Insert(2, 96); //2. index e 96 yı ekle

            //liste.TrimToSize(); // dolu olmayan indexleri siler
            //liste.Add(44); // ekleme

            //liste.Remove(21); //ilk bulduğu nesneyi siler
            //liste.Remove(1500); 
            //liste.RemoveAt(2); //girilen index numarasını siler
            //liste.RemoveRange(2, 3); //2. indexten başla (2 dahil) 3 tane sil
            //liste.Sort(); // sıralama
            //liste.Reverse(); // terse çevirme



            //Console.WriteLine("44 nerede? =" + liste.IndexOf(44)); // bulunduğu ilk index
            //Console.WriteLine("1500 nerede? = " + liste.IndexOf(1500)); //-1

            //Console.WriteLine("45 nerede? =" + liste.LastIndexOf(45)); // bulunduğu son index
            //liste.Clear();


            //Console.WriteLine("Listenin eleman sayısı = " +  liste.Count );
            //Console.WriteLine("Listenin kapasitesi = " + liste.Capacity);



            //for (int i = 0; i < liste.Count; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}


            #endregion

            #region Urun İle ArrayList

            //ArrayList liste = new ArrayList();

            //Urun u = new Urun();
            //u.Marka = "Faber Castel";
            //u.Model = "Kurşun 0,5";
            //u.Fiyat = 250;

            //liste.Add(u);

            //for (int i = 0; i < liste.Count; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}


            #endregion

            #region Dictionary Koleksiyonu

            //Dictionary<string, int> kodlama = new Dictionary<string, int>();
            //kodlama.Add("Araba", 45);
            //kodlama.Add("Sucuk", 13);
            //Console.WriteLine(kodlama["Araba"]);

            #endregion

            #region List <3

            //List<int> sayilar = new List<int>();
            //sayilar.Add(45);
            //sayilar.Add(25);
            //sayilar.Add(158);

            //Console.WriteLine("Eleman sayisi = " + sayilar.Count);
            //Console.WriteLine("Kapasite = " + sayilar.Capacity);


            //bool varmi = sayilar.Contains(55);
            //Console.WriteLine("55 varmı = " + varmi);

            #endregion

            #region nesne ile Koleksiyonlar

            //List<Urun> urunler = new List<Urun>();

            //Urun u = new Urun();
            //u.Marka = "Faber Castel";
            //u.Model = "Kurşun 0,5";
            //u.Fiyat = 250;
            //urunler.Add(u);

            //urunler.Add(new Urun() { Marka="Pelikan", Model="PM8",Fiyat =52});

            //urunler[1].Fiyat = 40;

            ////bool varmi = urunler.Contains(u);

            //for (int i = 0; i < urunler.Count; i++)
            //{
            //    Console.WriteLine(urunler[i].Model + " " + urunler[i].Fiyat + 50);
            //}




            #endregion

        }
    }
}
