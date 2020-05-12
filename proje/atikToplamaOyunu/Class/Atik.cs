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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atikToplamaOyunu
{
    public enum AtikTipi
    {
        Organic = 1,
        Glass = 2,
        Iron = 3,
        Paper = 4
    }

    public class Atik : IAtik
    {
        private readonly int _hacim;
        private readonly Image _resim;
        private readonly string _isim;
        private readonly AtikTipi _tip;

        public Atik(
            int hacim,
            Image resim,
            string isim,
            AtikTipi tip
            )
        {
            _hacim = hacim;
            _resim = resim;
            _isim = isim;
            _tip = tip;
        }

        public int Hacim => _hacim;

        public Image Image => _resim;

        public string Isim => _isim;

        public AtikTipi Tip => _tip;
    }
}
