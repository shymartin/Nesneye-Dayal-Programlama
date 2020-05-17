/***************************************************************************
**					      SAKARYA ÜNİVERSİTESİ                            **
**			   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                  **
**				    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                **
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ                       **
**					   2019-2020 BAHAR DÖNEMİ                             **
**                                                                     	  **
**		                                                                  **		
**				ÖĞRENCİ ADI............: Muhammet Onur Işık               **
**				ÖĞRENCİ NUMARASI.......: B191200056                       **
**              DERSİN ALINDIĞI GRUP...: A                                **
****************************************************************************/
using atikToplamaOyunu.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atikToplamaOyunu
{
    public partial class atikToplamaOyunu : Form
    {
        private List<Atik> _Atiks;
        private Atik _aktifAtik;

        private OrganikAtik _organikAtikKutusu;
        private MetalAtik _metalAtikKutusu;
        private CamAtik _camAtikKutusu;
        private KagitAtik _KagitAtikKutusu;

        public atikToplamaOyunu()
        {
            InitializeComponent();
        }

        private void YeniOyunBaslat()
        {
            _organikAtikKutusu = new OrganikAtik();
            _metalAtikKutusu = new MetalAtik();
            _camAtikKutusu = new CamAtik();
            _KagitAtikKutusu = new KagitAtik();

            btnOrganikAtikEkle.Enabled = true;
            btnOrganikAtikBosalt.Enabled = true;
            prgOrganikAtik.Value = 0;
            lstOrganikAtiklar.Items.Clear();

            btnKagitAtikEkle.Enabled = true;
            btnKagitAtikBosalt.Enabled = true;
            prgKagitAtik.Value = 0;
            lstKagitAtiklar.Items.Clear();

            btnCamAtikEkle.Enabled = true;
            btnCamAtikBosalt.Enabled = true;
            prgCamAtik.Value = 0;
            lstCamAtiklar.Items.Clear();

            btnMetalAtikEkle.Enabled = true;
            btnMetalAtikBosalt.Enabled = true;
            prgMetalAtik.Value = 0;
            lstMetalAtiklar.Items.Clear();

            lblPuan.Text = "0";
            lblOyunSuresi.Text = "60";

            btnYeniOyun.Enabled = false;

            AtikListesiOlustur();
            RastgeleAtikGoster();

            timerGameTime.Enabled = true;
        }

        private void OyunBitti()
        {
            timerGameTime.Enabled = false;

            picAtikImage.InitialImage = null;

            btnOrganikAtikEkle.Enabled = false;
            btnOrganikAtikBosalt.Enabled = false;

            btnKagitAtikEkle.Enabled = false;
            btnKagitAtikBosalt.Enabled = false;

            btnCamAtikEkle.Enabled = false;
            btnCamAtikBosalt.Enabled = false;

            btnMetalAtikEkle.Enabled = false;
            btnMetalAtikBosalt.Enabled = false;

            btnYeniOyun.Enabled = true;
        }

        private void ZamaniYaz(int saniye)
        {
            int aktifZaman = int.Parse(lblOyunSuresi.Text);
            int Yenizaman = aktifZaman + saniye;

            if (Yenizaman == 0)
                OyunBitti();

            lblOyunSuresi.Text = Yenizaman.ToString();
        }

        private void AtikListesiOlustur()
        {
            string imgPath = Application.StartupPath + "\\Images\\";
            _Atiks = new List<Atik>();
            _Atiks.Add(new Atik(600, Image.FromFile(imgPath + "camsise.jpg"), "Cam Şişe", AtikTipi.Glass));
            _Atiks.Add(new Atik(250, Image.FromFile(imgPath + "bardak.jpg"), "Bardak", AtikTipi.Glass));
            _Atiks.Add(new Atik(250, Image.FromFile(imgPath + "gazete.jpg"), "Gazete", AtikTipi.Paper));
            _Atiks.Add(new Atik(200, Image.FromFile(imgPath + "dergi.jpg"), "Dergi", AtikTipi.Paper));
            _Atiks.Add(new Atik(150, Image.FromFile(imgPath + "domates.jpg"), "Domates", AtikTipi.Organic));
            _Atiks.Add(new Atik(120, Image.FromFile(imgPath + "salatalik.jpg"), "Salatalık", AtikTipi.Organic));
            _Atiks.Add(new Atik(350, Image.FromFile(imgPath + "kolakutusu.jpg"), "Kola Kutusu", AtikTipi.Iron));
            _Atiks.Add(new Atik(350, Image.FromFile(imgPath + "salcakutusu.jpg"), "Salça Kutusu", AtikTipi.Iron));
        }

        private void RastgeleAtikGoster()
        {
            Random rnd = new Random();
            int AtikOrder = rnd.Next(0, 7);
            _aktifAtik = _Atiks[AtikOrder];
            picAtikImage.Image = _aktifAtik.Image;
        }

        private void PuanEkle(int point)
        {
            int currentPoint = int.Parse(lblPuan.Text);
            int newPoint = currentPoint + point;
            lblPuan.Text = newPoint.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void timerOyunZamani_Tick(object sender, EventArgs e)
        {
            ZamaniYaz(-1);
        }

        private void btnAddOrganicAtik_Click(object sender, EventArgs e)
        {
            if (_aktifAtik.Tip == AtikTipi.Organic)
            {
                if (_organikAtikKutusu.Ekle(_aktifAtik))
                {
                    lstOrganikAtiklar.Items.Add(_aktifAtik.Isim + " (" + _aktifAtik.Hacim.ToString() + ")");
                    PuanEkle(_aktifAtik.Hacim);
                    prgOrganikAtik.Value = _organikAtikKutusu.DolulukOrani;
                    RastgeleAtikGoster();
                }
            }
        }

        private void btnKagitAtikEkle_Click(object sender, EventArgs e)
        {
            if (_aktifAtik.Tip == AtikTipi.Paper)
            {
                if (_KagitAtikKutusu.Ekle(_aktifAtik))
                {
                    lstKagitAtiklar.Items.Add(_aktifAtik.Isim + " (" + _aktifAtik.Hacim.ToString() + ")");
                    PuanEkle(_aktifAtik.Hacim);
                    prgKagitAtik.Value = _KagitAtikKutusu.DolulukOrani;
                    RastgeleAtikGoster();
                }
            }
        }

        private void btnCamAtikEkle_Click(object sender, EventArgs e)
        {
            if (_aktifAtik.Tip == AtikTipi.Glass)
            {
                if (_camAtikKutusu.Ekle(_aktifAtik))
                {
                    lstCamAtiklar.Items.Add(_aktifAtik.Isim + " (" + _aktifAtik.Hacim.ToString() + ")");
                    PuanEkle(_aktifAtik.Hacim);
                    prgCamAtik.Value = _camAtikKutusu.DolulukOrani;
                    RastgeleAtikGoster();
                }
            }
        }

        private void btnMetalAtikEkle_Click(object sender, EventArgs e)
        {
            if (_aktifAtik.Tip == AtikTipi.Iron)
            {
                if (_metalAtikKutusu.Ekle(_aktifAtik))
                {
                    lstMetalAtiklar.Items.Add(_aktifAtik.Isim + " (" + _aktifAtik.Hacim.ToString() + ")");
                    PuanEkle(_aktifAtik.Hacim);
                    prgMetalAtik.Value = _metalAtikKutusu.DolulukOrani;
                    RastgeleAtikGoster();
                }
            }
        }

        private void btnOrganikAtikBosalt_Click(object sender, EventArgs e)
        {
            if (_organikAtikKutusu.Bosalt())
            {
                lstOrganikAtiklar.Items.Clear();
                prgOrganikAtik.Value = 0;
                PuanEkle(_organikAtikKutusu.BosaltmaPuani);
                ZamaniYaz(3);
            }
        }

        private void btnKagitAtikBosalt_Click(object sender, EventArgs e)
        {
            if (_KagitAtikKutusu.Bosalt())
            {
                lstKagitAtiklar.Items.Clear();
                prgKagitAtik.Value = 0;
                PuanEkle(_KagitAtikKutusu.BosaltmaPuani);
                ZamaniYaz(3);
            }
        }

        private void btnCamAtikBosalt_Click(object sender, EventArgs e)
        {
            if (_camAtikKutusu.Bosalt())
            {
                lstCamAtiklar.Items.Clear();
                prgCamAtik.Value = 0;
                PuanEkle(_camAtikKutusu.BosaltmaPuani);
                ZamaniYaz(3);
            }
        }

        private void btnMetalAtikBosalt_Click(object sender, EventArgs e)
        {
            if (_metalAtikKutusu.Bosalt())
            {
                lstMetalAtiklar.Items.Clear();
                prgMetalAtik.Value = 0;
                PuanEkle(_metalAtikKutusu.BosaltmaPuani);
                ZamaniYaz(3);
            }
        }

        private void lstOrganikAtiklar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
