using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz\nAdmin İçin 1'e\nMüşteri İçin 2'ye Basınız");
            string secim = Console.ReadLine();
            string şifre = "12";
            string[] ürünler = {"Kola = 10 TL", "Bisküvi = 3 TL", "Çikolata = 2 TL"}; 
            if (secim == "1")
            {
                Console.WriteLine("Şifrenizi Giriniz");
                string sfr = Console.ReadLine();
                if (sfr == şifre) 
                {
                    Console.WriteLine("Kola = 10 TL\nBisküvi = 3 TL\nÇikolata = 2 TL");
                    Console.WriteLine("Ürün Değiştrmek İçin 1'e\nFiyat Değiştirmek İçin 2'ye Basınız");
                    string secim1 = Console.ReadLine();
                    if (secim1 == "1")
                    {
                        Console.WriteLine("Yeni Ürün İsimlerini Ve Fiyatlarını Giriniz:");
                        Array.Clear(ürünler, 0, ürünler.Length);
                        Array.Resize(ref ürünler, 5);
                        ürünler[3] = Console.ReadLine();
                        ürünler[4] = Console.ReadLine();
                        ürünler[5] = Console.ReadLine();
                        foreach (string item in ürünler)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Yeni Ürünler" + ürünler);
                    }
                    else if (secim1 =="2")
                    {
                        Console.WriteLine("Ürün İsimleri Ve Yeni Fiyat Bilgileri Giriniz:");
                        Array.Clear(ürünler, 0, ürünler.Length);
                        Array.Resize(ref ürünler, 2);
                        ürünler[3] = Console.ReadLine();
                        ürünler[4] = Console.ReadLine();
                        ürünler[5] = Console.ReadLine();
                        foreach (string item in ürünler)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatlalı Tuşlama Yaptınız");
                    }
                }
                else 
                {
                    Console.WriteLine("Hatalı Şifre");
              
                }
              

              
            }
            else if (secim == "2")
            {
                Console.WriteLine("Kola = 10 TL\nBisküvi= 3 TL\nÇikolata = 2 TL");
                Console.WriteLine("Alacağınız Ürünün İsmini Giriniz");
                string ürün_ismi = Console.ReadLine();

                if (ürün_ismi == "kola")
                {
                    Console.WriteLine("Yatıracağınız Miktarı Giriz");
                    int fiyat = 10;
                    int paran = Convert.ToInt32(Console.ReadLine());
                    if (fiyat == paran)
                    {
                        Console.WriteLine("Ürününüzü Alınız");
                    }
                    else if (fiyat < paran)
                    { 
                        paran -= fiyat;
                        Console.WriteLine("Paranızın Üstü:{0}", paran);
                    }
                    else 
                    {
                        paran -= fiyat;
                        Console.WriteLine("Paranız Eksik:{0}", paran);
                    }

                }
                else if (ürün_ismi == "biskivü")
                {
                    Console.WriteLine("Yatıracağınız Miktarı Giriz");
                    int fiyat = 3;
                    int paran = Convert.ToInt32(Console.ReadLine());
                    if (fiyat == paran)
                    {
                        Console.WriteLine("Ürününüzü Alınız");
                    }
                    else if (fiyat < paran)
                    {
                        paran -= fiyat;
                        Console.WriteLine("Paranızın Üstü:{0}", paran);
                    }
                    else
                    {
                        paran -= fiyat;
                        Console.WriteLine("Paranız Eksik:{0}", paran);
                    }
                }
                else if (ürün_ismi == "çikolata")
                {
                    Console.WriteLine("Yatıracağınız Miktarı Giriz");
                    int fiyat = 2;
                    int paran = Convert.ToInt32(Console.ReadLine());
                    if (fiyat == paran)
                    {
                        Console.WriteLine("Ürününüzü Alınız");
                    }
                    else if (fiyat < paran)
                    {
                        paran -= fiyat;
                        Console.WriteLine("Paranızın Üstü:{0}", paran);
                    }
                    else
                    {
                        paran -= fiyat;
                        Console.WriteLine("Paranız Eksik:{0}", paran);
                    }

                }
                else
                {
                    Console.WriteLine("Hatalı İsim Girdiniz");
                }
            }
            else
            {
                Console.WriteLine("Hatalı Giriş");
            }






            Console.ReadLine();
        }
    }
}
