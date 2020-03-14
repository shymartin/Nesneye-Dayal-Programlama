/***************************************************************************
**					SAKARYA ÜNİVERSİTESİ                                  **
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                 **
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                        **
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ                       **
**					2019-2020 BAHAR DÖNEMİ                                **
**                                                                     	  **
**		                                                                  **		
**				ÖĞRENCİ ADI............: Alihan SARAÇ                     **
**				ÖĞRENCİ NUMARASI.......: G191210057                       **
**              DERSİN ALINDIĞI GRUP...: 2A                               **
****************************************************************************/

using System;
using System.IO;

namespace csOdev
{
    class Program
    {
        class ogrenci
        {
            public string ad;
            public string soyad;
            public string ogrenciNo;
            public int odev1;
            public int odev2;
            public int vize;
            public int final;
            static public int aa = 0, ba = 0, bb = 0, cb = 0, cc = 0, dc = 0, dd = 0, fd = 0, ff = 0;

            public ogrenci()//default kurucu
            {
                ad = "ad"; soyad = "soyad"; ogrenciNo = "ogrenciNo"; ogrsayisi++; odev1 = 101; odev2 = 101; vize = 101; final = 101;
            }
            public ogrenci(string ad, string soyad,string ogrenciNo,int odev1,int odev2,int vize,int final )//değişkenli kurucu
            {
                this.ad = ad; this.soyad = soyad; this.ogrenciNo = ogrenciNo; this.odev1 =odev1; this.odev2 = odev2; this.vize = vize; this.final = final;
            }

           public void DosyaYaz()//txt oluşturma ve icini doldurmak icin fonk.
            {
                string[] isimler = { "ali", "veli", "hamza", "cemal", "cemil", "eren", "merve", "nida", "aslı", "ayse" };
                string[] soyisimler = { "kara", "sarac", "sefer", "demir", "guclu", "mert", "yılmaz", "guzel", "mavi", "ozturk" };
                int ogrNo;
                Random rastgele = new Random();
                string dosyayolu = @"isimleri.txt";
                FileStream fs = new FileStream(dosyayolu, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(10 + "      " + 10 + "      " + 30 + "      " + 50);
                for(int i=0;i<100;i++)
                {
                    sw.WriteLine(isimler[rastgele.Next(0, 10)] + " " + soyisimler[rastgele.Next(0, 10)] + " " + rastgele.Next(0, 2000) + " " + rastgele.Next(0, 101) + " " + rastgele.Next(0, 101) + " " + rastgele.Next(0, 101) + " " + rastgele.Next(0, 101));
                }
                sw.Close();
            }
            public void oku()
            {   
                FileStream fs = new FileStream("isimleri.txt", FileMode.Open, FileAccess.ReadWrite);
                StreamReader sw = new StreamReader(fs);
                StreamWriter sw2 = new StreamWriter(fs);
                ogrenci[] sinif = new ogrenci[100];//ogrenci dizisi olusturur
                       
                    ogrenci gecici = new ogrenci();
                sw.ReadLine();//ilk satiri okuyarak bilgi kirliliğini onler
                    for(int ogr=0;ogr<100;ogr++)//yazıyı ogrenci sinifina atar
                    {
                    
                        string satir = sw.ReadLine();//satırları okur
                        if (satir != null)
                        {
                            string[] bilgi = new string[7];
                            bilgi = satir.Split(" ");//satiri parcalar

                            gecici.ad = bilgi[0];
                            gecici.soyad = bilgi[1];
                            gecici.ogrenciNo = bilgi[2];
                            gecici.odev1 = int.Parse(bilgi[3]);
                            gecici.odev2 = int.Parse(bilgi[4]);
                            gecici.vize = int.Parse(bilgi[5]);
                            gecici.final = int.Parse(bilgi[6]);
                            
                        }sinif[ogr] = gecici;                    
                    

                    if (sinif[ogr] != null)
                    {
                        int ortalama = sinif[ogr].odev1 * 10 / 100 + sinif[ogr].odev2 * 10 / 100 + sinif[ogr].vize * 30 / 100 + sinif[ogr].final * 50 / 100;
                        
                        if (ortalama > 90)//HARF SAYISI HESAPLAMA
                            aa++;
                        else if (ortalama < 90 && ortalama >= 85)
                            ba++;
                        else if (ortalama < 85 && ortalama >= 80)
                            bb++;
                        else if (ortalama < 80 && ortalama >= 75)
                            cb++;
                        else if (ortalama < 75 && ortalama >= 65)
                            cc++;
                        else if (ortalama < 65 && ortalama >= 58)
                            dc++;
                        else if (ortalama < 58 && ortalama >= 50)
                            dd++;
                        else if (ortalama < 50 && ortalama >= 40)
                            fd++;
                        else if (ortalama < 50 && ortalama >= 0)
                            ff++;
                    }
                    }

            }

            public void SonucYaz()//sonuclar.txt yazdirir
            {
                string dosyayolu = @"sonuclar.txt";
                FileStream fs = new FileStream(dosyayolu, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("AA\t" + aa);
                sw.WriteLine("BA\t" + ba);
                sw.WriteLine("CB\t" + cb);
                sw.WriteLine("CC\t" + cc);
                sw.WriteLine("DC\t" + dc);
                sw.WriteLine("DD\t" + dd);
                sw.WriteLine("FD\t" + fd);
                sw.WriteLine("FF\t" + ff+"\n");
                sw.WriteLine("Gecen ogrenci sayisi\t" + (aa+ba+bb+cb+cc+dc+dd));
                sw.WriteLine("Kalan ogrenci sayisi\t" + (fd + ff));
                sw.Close();
            }
        }
        static void Main(string[] args)
        {
            ogrenci o = new ogrenci();
            string cevap;
            Console.WriteLine("Hesaplama yapmak icin E tusuna basiniz\a");
            cevap = Console.ReadLine();
            if (cevap == "e" || cevap == "E")
            {
                o.DosyaYaz();
                o.oku();
                o.SonucYaz();
            }
            
            
            Console.ReadKey();
        }
    }
}
