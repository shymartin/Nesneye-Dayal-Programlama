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

namespace atikToplamaOyunu
{
    public interface IDolabilen
    {
        int Kapasite { get; }
        int DoluHacim { get; set; }
        int DolulukOrani { get; set; }
    }
}
