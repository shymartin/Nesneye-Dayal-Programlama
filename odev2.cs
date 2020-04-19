/***************************************************************************
**					      SAKARYA ÜNÝVERSÝTESÝ                            **
**			   BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ                  **
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ                        **
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ                       **
**					   2019-2020 BAHAR DÖNEMÝ                             **
**                                                                     	  **
**		                                                                  **		
**				ÖÐRENCÝ ADI............: Alihan SARAÇ                     **
**				ÖÐRENCÝ NUMARASI.......: G191210057                       **
**              DERSÝN ALINDIÐI GRUP...: 2A                               **
****************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace g191210057ArkadasMi
{
    static class Program
    {
        public class Form1 : Form
        {
            private System.Windows.Forms.Button  Arkadasmi_button;
            private System.Windows.Forms.Button  Cikis_button2;
            private System.Windows.Forms.Label   x_label1;
            private System.Windows.Forms.Label   y_label1;
            private System.Windows.Forms.Label   label3;
            private System.Windows.Forms.TextBox X_textBox1;
            private System.Windows.Forms.TextBox Y_textBox2;
            private System.Windows.Forms.TextBox ToplamX_txtbx;
            private System.Windows.Forms.TextBox ToplamY_txtbx;
            private System.Windows.Forms.ListBox Xcarpanlari_listbx;
            private System.Windows.Forms.ListBox Ycarpanlari_listbx;

            public Form1()//kurucu fonksiyon
            {
                Arkadasmi_button = new System.Windows.Forms.Button();
                Cikis_button2 = new System.Windows.Forms.Button();
                x_label1 = new System.Windows.Forms.Label();
                y_label1 = new System.Windows.Forms.Label();
                label3 = new System.Windows.Forms.Label();
                X_textBox1 = new System.Windows.Forms.TextBox();
                Y_textBox2 = new System.Windows.Forms.TextBox();
                ToplamX_txtbx = new System.Windows.Forms.TextBox();//arkadas mi butonuna birkac kere basilmak istenirse elementlerin degismesi icin burada belirtilmistir
                ToplamY_txtbx = new System.Windows.Forms.TextBox();
                Xcarpanlari_listbx = new System.Windows.Forms.ListBox();
                Ycarpanlari_listbx = new System.Windows.Forms.ListBox();
                SuspendLayout();

                Arkadasmi_button.Location = new System.Drawing.Point(20, 90);// Arkadasmi_button kurucusu
                Arkadasmi_button.Name = "Arkadasmi_button";
                Arkadasmi_button.Size = new System.Drawing.Size(70, 23);
                Arkadasmi_button.TabIndex = 0;
                Arkadasmi_button.Text = "&Arkadas mi?";
                Arkadasmi_button.UseVisualStyleBackColor = true;
                Arkadasmi_button.Click += new System.EventHandler(Arkadasmi_button_Click);

                Cikis_button2.Location = new System.Drawing.Point(110, 90);// Cikis_button2 kurucusu
                Cikis_button2.Name = "Cikis_button2";
                Cikis_button2.Size = new System.Drawing.Size(75, 23);
                Cikis_button2.TabIndex = 1;
                Cikis_button2.Text = "&Son";
                Cikis_button2.UseVisualStyleBackColor = true;
                Cikis_button2.Click += new System.EventHandler(Cikis_button2_Click);

                x_label1.AutoSize = true;// x_label1 kurucusu
                x_label1.Location = new System.Drawing.Point(32, 23);
                x_label1.Name = "x_label1";
                x_label1.Size = new System.Drawing.Size(14, 13);
                x_label1.TabIndex = 2;
                x_label1.Text = "X";

                y_label1.AutoSize = true; // y_label1 kurucusu
                y_label1.Location = new System.Drawing.Point(32, 57);
                y_label1.Name = "y_label1";
                y_label1.Size = new System.Drawing.Size(14, 13);
                y_label1.TabIndex = 3;
                y_label1.Text = "Y";

                label3.AutoSize = true; // label3 kurucusu
                label3.Location = new System.Drawing.Point(20, 120);
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(30, 30);
                label3.TabIndex = 10;
                label3.Text = "                      ";


                X_textBox1.Location = new System.Drawing.Point(63, 20); // X_textBox1 kurucusu
                X_textBox1.Name = "X_textBox1";
                X_textBox1.Size = new System.Drawing.Size(69, 20);
                X_textBox1.TabIndex = 4;

                Y_textBox2.Location = new System.Drawing.Point(63, 57);// Y_textBox2 kurucusu
                Y_textBox2.Name = "Y_textBox2";
                Y_textBox2.Size = new System.Drawing.Size(71, 20);
                Y_textBox2.TabIndex = 5;

                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);// Form1 kurucusu
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoSize = true;
                ClientSize = new System.Drawing.Size(246, 196);
                Controls.Add(Y_textBox2);
                Controls.Add(X_textBox1);
                Controls.Add(y_label1);
                Controls.Add(x_label1);
                Controls.Add(label3);
                Controls.Add(Cikis_button2);
                Controls.Add(Arkadasmi_button);
                Name = "Form1";
                AutoSizeChanged += new System.EventHandler(Arkadasmi_button_Click);
                ResumeLayout(false);
                PerformLayout();
            }

            private void Arkadasmi_button_Click(object sender, EventArgs e)
            {
                var x_label2 = new Label();//x_label2 çarpanlarinin ustundeki x_label2 labeli 
                x_label2.Top = 20;
                x_label2.Left = 245;
                x_label2.Text = "X";
                x_label2.Size = new System.Drawing.Size(10, 16);
                Controls.Add(x_label2);

                var y_label2 = new Label();//y_label2 çarpanlarinin ustundeki y_label2 labeli 
                y_label2.Top = 20;
                y_label2.Left = 245 + 72;
                y_label2.Text = "Y";
                y_label2.Size = new System.Drawing.Size(10, 16);
                Controls.Add(y_label2);

                label3.Text = "                ";  
               
                Xcarpanlari_listbx.Top = 40;//x carpanlarinin listboxinin olusturulmasi
                Xcarpanlari_listbx.Left = 228;
                Xcarpanlari_listbx.Size = new System.Drawing.Size(50, 100);
                Controls.Add(Xcarpanlari_listbx);
                Xcarpanlari_listbx.Items.Clear();
               
                Ycarpanlari_listbx.Top = 40;//y carpanlarinin listboxinin olusturulmasi
                Ycarpanlari_listbx.Left = 300;
                Ycarpanlari_listbx.Size = new System.Drawing.Size(50, 100);
                Controls.Add(Ycarpanlari_listbx);
                Ycarpanlari_listbx.Items.Clear();

                var toplam = new Label();//carpanlarin toplami labeli
                toplam.Top = 160;
                toplam.Left = 140;
                toplam.Text = "Toplam :";
                toplam.Size = new System.Drawing.Size(50, 16);
                Controls.Add(toplam);
           
                ToplamX_txtbx.Top = 160;//x carpanlarinin toplami textboxi
                ToplamX_txtbx.Left = 230;
                ToplamX_txtbx.Size = new System.Drawing.Size(50, 16);
                Controls.Add(ToplamX_txtbx);
                ToplamX_txtbx.Clear();
              
                ToplamY_txtbx.Top = 160;//y carpanlarinin toplami textboxi
                ToplamY_txtbx.Left = 300;
                ToplamY_txtbx.Size = new System.Drawing.Size(50, 16);
                Controls.Add(ToplamY_txtbx);
                ToplamY_txtbx.Clear();

                int xDegeri, yDegeri;//texte gitilen sayilar
                while (!int.TryParse(X_textBox1.Text, out xDegeri) || !int.TryParse(Y_textBox2.Text, out yDegeri))//sadece sayi girisi yapilmasini saglar ve texte girilen sayilari degiskenlere atar
                {
                    label3.BackColor = Color.Yellow; label3.Text="HATA" ; MessageBox.Show("Sadece sayi giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return;//uyari mesaji
                }
                int XCarpanSayisi = 0; int[] xcarpanlarý = new int[100];// x in carpan sayýsý ve dizisi
                int YCarpanSayisi = 0; int[] ycarpanlarý = new int[100];//y nin carpan sayýsý ve dizisi

                for (int i = 1; i < xDegeri; i++)//çarpanlarýný bulmak için hangi sayýlara bölünebildiðini bulur
                {
                    if (xDegeri % i == 0)
                    {
                        xcarpanlarý[XCarpanSayisi] = i;
                        XCarpanSayisi++;
                    }
                }
                for (int i = 1; i < yDegeri; i++)//çarpanlarýný bulmak için hangi sayýlara bölünebildiðini bulur
                {
                    if (yDegeri % i == 0)
                    {
                        ycarpanlarý[YCarpanSayisi] = i;
                        YCarpanSayisi++;
                    }
                }

                for (int i = 0; i < XCarpanSayisi; i++)//listboxa çarpanlarý ekle
                    Xcarpanlari_listbx.Items.Add(xcarpanlarý[i]);
                for (int i = 0; i < YCarpanSayisi; i++)//listboxa çarpanlarý ekle
                    Ycarpanlari_listbx.Items.Add(ycarpanlarý[i]);

                int Xtoplam = 0, Ytoplam = 0;
                for (int i = 0; i < XCarpanSayisi; i++)//x çarpan toplamlarýný bulmak
                    Xtoplam += xcarpanlarý[i];
                for (int i = 0; i < YCarpanSayisi; i++)//x çarpan toplamlarýný bulmak
                    Ytoplam += ycarpanlarý[i];

                ToplamX_txtbx.Text = Convert.ToString(Xtoplam);//toplamlarý texte yazdýrýr
                ToplamY_txtbx.Text = Convert.ToString(Ytoplam);

                if (Xtoplam == yDegeri && Ytoplam == xDegeri)//bilgilendirme mesaji
                {
                    label3.BackColor = Color.Green;//arkadasmi butonunun alti yesil olur
                    MessageBox.Show("X ve Y arkadas sayidir.", "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    label3.BackColor = Color.Red;//arkadasmi butonunun alti kirmizi olur
                    MessageBox.Show("X ve Y arkadas sayi degildir.", "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult sonuc = MessageBox.Show("Tekrardan islem yapmak istiyormusunuz", "islem", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc != DialogResult.Yes)
                {
                    Arkadasmi_button.Enabled = false;



                }
            }

            private void Cikis_button2_Click(object sender, EventArgs e)
            {
                Close();//programý kapatir
            }

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.Run(new Form1());
            }
        }
    }
}
