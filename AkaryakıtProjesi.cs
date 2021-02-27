using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akaryakıt
{
    class Program
    {
        static void Main(string[] args)
        {
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismiktari = 0;
            char anamenusecım = '0', altmenusecim = '0', akaryakitfiyatguncelle = '0', akaryakitsatistipi = '0';
        MENU:
            Console.WriteLine("Akaryakıt Satış Takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1-Birim Fiyat Göster");
            Console.WriteLine("2-Birim Fiyat Güncelle");
            Console.WriteLine("3-Akaryakıt Satışı Yap");
            Console.WriteLine("4-Depo Durumunu Göster");
            Console.WriteLine("5-Toplam Satışları Göster");
            Console.WriteLine("6-Çıkış");

            Console.Write("Seçiminizi Yapınız [1,2,3,4,5,6]:");
            anamenusecım = Convert.ToChar(Console.ReadLine());
            if (anamenusecım == '1')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:1");
                Console.WriteLine("---Birim Fiyat Listesi---");
                Console.WriteLine("Dizel(D) :{0} TL/Litre", dizel);
                Console.WriteLine("Benzin(B) :{0} TL/Litre", benzin);
                Console.WriteLine("LPG(L) :{0} TL/Litre", lpg);
            ALTMENU:
                Console.Write("Seçiminizi Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecım == '2')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:2");
                Console.WriteLine("---Birim Fiyat Güncelleme---");
            AKARYAKITTIPI:
                Console.WriteLine("Akaryakıt Tipini Seçiniz [D,B,L]:");
                akaryakitfiyatguncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitfiyatguncelle == 'D' || akaryakitfiyatguncelle == 'd')
                {
                    Console.WriteLine("Dizel(D):{0} TL/Litre", dizel);
                    Console.Write("Dizel Yakıt İçin Yeni Fiyat Giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Dizel(D):{0} TL/Litre", dizel);
                }
                else if (akaryakitfiyatguncelle == 'B' || akaryakitfiyatguncelle == 'b')
                {
                    Console.WriteLine("Benzin(B):{0} TL/Litre", benzin);
                    Console.Write("Benzin Yakıt İçin Yeni Fiyat Giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Benzin(B):{0} TL/Litre", benzin);
                }
                else if (akaryakitfiyatguncelle == 'D' || akaryakitfiyatguncelle == 'd')
                {
                    Console.WriteLine("LPG(L):{0} TL/Litre", lpg);
                    Console.Write("LPG Yakıt İçin Yeni Fiyat Giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("LPG(L):{0} TL/Litre", lpg);
                }
                else
                {
                    Console.WriteLine("[D,B,L] dışında hatalı seçim yaptınız.");
                    goto AKARYAKITTIPI;
                }
            ALTMENU:
                Console.Write("Seçimini Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 seçenekleri dışında yanlış seçim yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecım == '3')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:3");
                Console.WriteLine("---Akaryakıt Satış İşlemleri---");
            AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt Tipini Seçiniz [D,B,L]:");
                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitsatistipi == 'D' || akaryakitsatistipi == 'd')
                {
                    if (dizeltank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç dizel yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Ne kadar dizel yakıt alacaksınız:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre dizel yakıt vardır!İşlem yapılamadı!", dizeltank);
                            goto MENU;
                        }
                        else if (satismiktari <= dizeltank)
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} litre dizel yakıt kaldı.", dizeltank);
                        }
                    }
                }
                if (akaryakitsatistipi == 'B' || akaryakitsatistipi == 'b')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç benzin yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Ne kadar benzin yakıt alacaksınız:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre benzin yakıt vardır!İşlem yapılamadı!", benzintank);
                            goto MENU;
                        }
                        else if (satismiktari <= benzintank)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} litre benzin yakıt kaldı.", benzintank);
                        }
                    }
                }
                if (akaryakitsatistipi == 'L' || akaryakitsatistipi == 'l')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç LPG yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Ne kadar LPG yakıt alacaksınız:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (lpgtank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre LPG yakıt vardır!İşlem yapılamadı!", lpgtank);
                            goto MENU;
                        }
                        else if (satismiktari <= lpgtank)
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} litre LPG yakıt kaldı.", lpgtank);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("[D,B,L] dışında hatalı seçim yaptınız.");
                    goto AKARYAKITSATISI;
                }
            ALTMENU:
                Console.Write("Seçimini Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 seçenekleri dışında yanlış seçim yaptınız!");
                    goto ALTMENU;
                }
            }
            else if(anamenusecım=='4')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:4");
                Console.WriteLine("---Depo Durumu---");
                Console.WriteLine("Dizel Yakıt Tankı %{0} doludur.", (dizeltank / 10));
                Console.WriteLine("Benzin Yakıt Tankı %{0} doludur.", (benzintank / 10));
                Console.WriteLine("LPG Yakıt Tankı %{0} doludur.", (lpgtank / 10));
                ALTMENU:
                Console.Write("Seçimini Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 seçenekleri dışında yanlış seçim yaptınız!");
                    goto ALTMENU;
                }
            }
            else if(anamenusecım=='5')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:5");
                Console.WriteLine("---Toplam Satış Durumu---");
                Console.WriteLine("Satılan Toplam Dizel Yakıt:{0}", 1000 - dizeltank);
                Console.WriteLine("Dizel Yakıt Tutarı:{0}",(1000 - dizeltank) * dizel);
                Console.WriteLine("Satılan Toplam Benzin Yakıt:{0}", 1000 - benzintank);
                Console.WriteLine("Benzin Yakıt Tutarı:{0}", (1000 - benzintank) * benzin);
                Console.WriteLine("Satılan Toplam LPG Yakıtı:{0}", 1000 - lpgtank);
                Console.WriteLine("LPG Yakıt Tutarı:{0}", (1000 - lpgtank) * lpg);
                Console.WriteLine("________________________________");
                Console.WriteLine("Toplam Tutar:{0}",((1000-dizeltank)*dizel)+((1000-benzintank)*benzin)+ ((1000-lpgtank)*lpg));
            ALTMENU:
                Console.Write("Seçimini Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 seçenekleri dışında yanlış seçim yaptınız!");
                    goto ALTMENU;
                }
            }
            Console.ReadKey();





        }
    }
}
