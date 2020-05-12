/***************************************************************************
**					      SAKARYA ÜNİVERSİTESİ                            **
**			   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                  **
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                        **
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ                       **
**					   2019-2020 BAHAR DÖNEMİ                             **
**                                                                     	  **
**		                                                                  **		
**				ÖĞRENCİ ADI............: Alihan SARAÇ                     **
**				ÖĞRENCİ NUMARASI.......: G191210057                       **
**              DERSİN ALINDIĞI GRUP...: 2A                               **
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atikToplamaOyunu.Class
{
    public class CamAtik : IAtikKutusu
    {
        public int BosaltmaPuani => 600;

        public int Kapasite => 2200;

        public int DoluHacim { get; set; }

        public int DolulukOrani { get; set; }

        public bool Ekle(Atik atik)
        {
            if (atik.Hacim + DoluHacim <= Kapasite)
            {
                DoluHacim += atik.Hacim;
                DolulukOrani = Convert.ToInt32(Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite) * 100);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                DoluHacim = 0;
                DolulukOrani = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
