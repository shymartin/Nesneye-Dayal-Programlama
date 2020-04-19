
/***************************************************************************
**					      SAKARYA ÜNİVERSİTESİ                            **
**			   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                  **
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                        **
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝİ                      **
**					   2019-2020 BAHAR DÖNEMİ                             **
**                                                                     	  **
**		                                                                  **		
**				ÖĞRENCİ ADI............: Alihan SARAÇ                     **
**				ÖĞRENCİ NUMARASI.......: G191210057                       **
**              DERSİN ALINDIĞI GRUP...: 2A                               **
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_odev3._2
{
    static class Program
    {
        public class Form1 : Form
        {
            private System.Windows.Forms.GroupBox groupBox2;
            private System.Windows.Forms.Label kdvliLabel;
            private System.Windows.Forms.Label urunLabel;
            private System.Windows.Forms.Label kdvliFiyatLabel;
            private System.Windows.Forms.Label labkdvliLabel2el24;
            private System.Windows.Forms.ListBox kdvliFiyatListBox;
            private System.Windows.Forms.ListBox urunListBox;
            private System.Windows.Forms.ListBox adetListBox;
            private System.Windows.Forms.Label adetLabel5;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.NumericUpDown telefonNumericUD;
            private System.Windows.Forms.NumericUpDown laptopNumericUD;
            private System.Windows.Forms.Label label16;
            private System.Windows.Forms.NumericUpDown buzdolabiNumericUD;
            private System.Windows.Forms.Label telefonStokLabel;
            private System.Windows.Forms.Label adetLabel2;
            private System.Windows.Forms.Label stokLabel4;
            private System.Windows.Forms.Label adetLabel3;
            private System.Windows.Forms.Label telefonFiyatLabel;
            private System.Windows.Forms.Label laptopStokLabel;
            private System.Windows.Forms.Label fiyatLabel4;
            private System.Windows.Forms.Label buzdolabiStokLabel;
            private System.Windows.Forms.PictureBox pictureBox4;
            private System.Windows.Forms.Label stokLabel2;
            private System.Windows.Forms.Label stokLabel3;
            private System.Windows.Forms.Label laptopFiyatLabel;
            private System.Windows.Forms.Label buzdolabiFiyatLabel;
            private System.Windows.Forms.Label fiyatLabel2;
            private System.Windows.Forms.Label fiyatLabel3;
            private System.Windows.Forms.PictureBox pictureBox3;
            private System.Windows.Forms.PictureBox pictureBox2;
            private System.Windows.Forms.NumericUpDown tvNumericUD;
            private System.Windows.Forms.Label adetLabel;
            private System.Windows.Forms.Label tvStokLabel;
            private System.Windows.Forms.Label stokLabel;
            private System.Windows.Forms.Label tvFiyatLabel;
            private System.Windows.Forms.Label fiyatLabel;
            private System.Windows.Forms.PictureBox tvPictureBox;
            private System.Windows.Forms.Button sepetiTemizleButton;
            public Form1()
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                this.groupBox2 = new System.Windows.Forms.GroupBox();
                this.kdvliLabel = new System.Windows.Forms.Label();
                this.urunLabel = new System.Windows.Forms.Label();
                this.kdvliFiyatLabel = new System.Windows.Forms.Label();
                this.labkdvliLabel2el24 = new System.Windows.Forms.Label();
                this.kdvliFiyatListBox = new System.Windows.Forms.ListBox();
                this.urunListBox = new System.Windows.Forms.ListBox();
                this.adetListBox = new System.Windows.Forms.ListBox();
                this.adetLabel5 = new System.Windows.Forms.Label();
                this.button1 = new System.Windows.Forms.Button();
                this.groupBox1 = new System.Windows.Forms.GroupBox();
                this.telefonNumericUD = new System.Windows.Forms.NumericUpDown();
                this.laptopNumericUD = new System.Windows.Forms.NumericUpDown();
                this.label16 = new System.Windows.Forms.Label();
                this.buzdolabiNumericUD = new System.Windows.Forms.NumericUpDown();
                this.telefonStokLabel = new System.Windows.Forms.Label();
                this.adetLabel2 = new System.Windows.Forms.Label();
                this.stokLabel4 = new System.Windows.Forms.Label();
                this.adetLabel3 = new System.Windows.Forms.Label();
                this.telefonFiyatLabel = new System.Windows.Forms.Label();
                this.laptopStokLabel = new System.Windows.Forms.Label();
                this.fiyatLabel4 = new System.Windows.Forms.Label();
                this.buzdolabiStokLabel = new System.Windows.Forms.Label();
                this.pictureBox4 = new System.Windows.Forms.PictureBox();
                this.stokLabel2 = new System.Windows.Forms.Label();
                this.stokLabel3 = new System.Windows.Forms.Label();
                this.laptopFiyatLabel = new System.Windows.Forms.Label();
                this.buzdolabiFiyatLabel = new System.Windows.Forms.Label();
                this.fiyatLabel2 = new System.Windows.Forms.Label();
                this.fiyatLabel3 = new System.Windows.Forms.Label();
                this.pictureBox3 = new System.Windows.Forms.PictureBox();
                this.pictureBox2 = new System.Windows.Forms.PictureBox();
                this.tvNumericUD = new System.Windows.Forms.NumericUpDown();
                this.adetLabel = new System.Windows.Forms.Label();
                this.tvStokLabel = new System.Windows.Forms.Label();
                this.stokLabel = new System.Windows.Forms.Label();
                this.tvFiyatLabel = new System.Windows.Forms.Label();
                this.fiyatLabel = new System.Windows.Forms.Label();
                this.tvPictureBox = new System.Windows.Forms.PictureBox();
                this.sepetiTemizleButton = new System.Windows.Forms.Button();
                this.groupBox2.SuspendLayout();
                this.groupBox1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.telefonNumericUD)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.laptopNumericUD)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.buzdolabiNumericUD)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.tvNumericUD)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.tvPictureBox)).BeginInit();
                this.SuspendLayout();
                // 
                // groupBox2
                // 
                this.groupBox2.Controls.Add(this.kdvliLabel);
                this.groupBox2.Controls.Add(this.urunLabel);
                this.groupBox2.Controls.Add(this.kdvliFiyatLabel);
                this.groupBox2.Controls.Add(this.labkdvliLabel2el24);
                this.groupBox2.Controls.Add(this.kdvliFiyatListBox);
                this.groupBox2.Controls.Add(this.urunListBox);
                this.groupBox2.Controls.Add(this.adetListBox);
                this.groupBox2.Controls.Add(this.adetLabel5);
                this.groupBox2.Location = new System.Drawing.Point(345, 12);
                this.groupBox2.Name = "groupBox2";
                this.groupBox2.Size = new System.Drawing.Size(233, 295);
                this.groupBox2.TabIndex = 8;
                this.groupBox2.TabStop = false;
                this.groupBox2.Text = "Sipariş Özeti";
                // 
                // kdvliLabel
                // 
                this.kdvliLabel.AutoSize = true;
                this.kdvliLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.kdvliLabel.Location = new System.Drawing.Point(157, 16);
                this.kdvliLabel.Name = "kdvliLabel";
                this.kdvliLabel.Size = new System.Drawing.Size(57, 13);
                this.kdvliLabel.TabIndex = 9;
                this.kdvliLabel.Text = "Kdv\'li Fiyat";
                // 
                // urunLabel
                // 
                this.urunLabel.AutoSize = true;
                this.urunLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.urunLabel.Location = new System.Drawing.Point(87, 16);
                this.urunLabel.Name = "urunLabel";
                this.urunLabel.Size = new System.Drawing.Size(30, 13);
                this.urunLabel.TabIndex = 8;
                this.urunLabel.Text = "Ürün";
                // 
                // kdvliFiyatLabel
                // 
                this.kdvliFiyatLabel.AutoSize = true;
                this.kdvliFiyatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
                this.kdvliFiyatLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.kdvliFiyatLabel.Location = new System.Drawing.Point(123, 258);
                this.kdvliFiyatLabel.Name = "kdvliFiyatLabel";
                this.kdvliFiyatLabel.Size = new System.Drawing.Size(91, 24);
                this.kdvliFiyatLabel.TabIndex = 7;
                this.kdvliFiyatLabel.Text = "0";
                // 
                // labkdvliLabel2el24
                // 
                this.labkdvliLabel2el24.AutoSize = true;
                this.labkdvliLabel2el24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.labkdvliLabel2el24.Location = new System.Drawing.Point(19, 266);
                this.labkdvliLabel2el24.Name = "labkdvliLabel2el24";
                this.labkdvliLabel2el24.Size = new System.Drawing.Size(98, 13);
                this.labkdvliLabel2el24.TabIndex = 6;
                this.labkdvliLabel2el24.Text = "Kdv\'li Toplam Fiyat:";
                // 
                // kdvliFiyatListBox
                // 
                this.kdvliFiyatListBox.FormattingEnabled = true;
                this.kdvliFiyatListBox.Location = new System.Drawing.Point(156, 35);
                this.kdvliFiyatListBox.Name = "kdvliFiyatListBox";
                this.kdvliFiyatListBox.Size = new System.Drawing.Size(71, 121);
                this.kdvliFiyatListBox.TabIndex = 5;
                // 
                // urunListBox
                // 
                this.urunListBox.FormattingEnabled = true;
                this.urunListBox.Location = new System.Drawing.Point(66, 36);
                this.urunListBox.Name = "urunListBox";
                this.urunListBox.Size = new System.Drawing.Size(71, 121);
                this.urunListBox.TabIndex = 3;
                // 
                // adetListBox
                // 
                this.adetListBox.FormattingEnabled = true;
                this.adetListBox.Location = new System.Drawing.Point(22, 36);
                this.adetListBox.Name = "adetListBox";
                this.adetListBox.Size = new System.Drawing.Size(26, 121);
                this.adetListBox.TabIndex = 1;
                // 
                // adetLabel5
                // 
                this.adetLabel5.AutoSize = true;
                this.adetLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.adetLabel5.Location = new System.Drawing.Point(19, 19);
                this.adetLabel5.Name = "adetLabel5";
                this.adetLabel5.Size = new System.Drawing.Size(29, 13);
                this.adetLabel5.TabIndex = 0;
                this.adetLabel5.Text = "Adet";
                // 
                // button1
                // 
                this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.button1.Location = new System.Drawing.Point(19, 421);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(125, 30);
                this.button1.TabIndex = 6;
                this.button1.Text = "Ürünü Sepete &Ekle";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // groupBox1
                // 
                this.groupBox1.Controls.Add(this.telefonNumericUD);
                this.groupBox1.Controls.Add(this.laptopNumericUD);
                this.groupBox1.Controls.Add(this.label16);
                this.groupBox1.Controls.Add(this.buzdolabiNumericUD);
                this.groupBox1.Controls.Add(this.telefonStokLabel);
                this.groupBox1.Controls.Add(this.adetLabel2);
                this.groupBox1.Controls.Add(this.stokLabel4);
                this.groupBox1.Controls.Add(this.adetLabel3);
                this.groupBox1.Controls.Add(this.telefonFiyatLabel);
                this.groupBox1.Controls.Add(this.laptopStokLabel);
                this.groupBox1.Controls.Add(this.fiyatLabel4);
                this.groupBox1.Controls.Add(this.buzdolabiStokLabel);
                this.groupBox1.Controls.Add(this.pictureBox4);
                this.groupBox1.Controls.Add(this.stokLabel2);
                this.groupBox1.Controls.Add(this.stokLabel3);
                this.groupBox1.Controls.Add(this.laptopFiyatLabel);
                this.groupBox1.Controls.Add(this.buzdolabiFiyatLabel);
                this.groupBox1.Controls.Add(this.fiyatLabel2);
                this.groupBox1.Controls.Add(this.fiyatLabel3);
                this.groupBox1.Controls.Add(this.pictureBox3);
                this.groupBox1.Controls.Add(this.pictureBox2);
                this.groupBox1.Controls.Add(this.tvNumericUD);
                this.groupBox1.Controls.Add(this.adetLabel);
                this.groupBox1.Controls.Add(this.tvStokLabel);
                this.groupBox1.Controls.Add(this.stokLabel);
                this.groupBox1.Controls.Add(this.tvFiyatLabel);
                this.groupBox1.Controls.Add(this.fiyatLabel);
                this.groupBox1.Controls.Add(this.tvPictureBox);
                this.groupBox1.Location = new System.Drawing.Point(12, 12);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Size = new System.Drawing.Size(317, 380);
                this.groupBox1.TabIndex = 5;
                this.groupBox1.TabStop = false;
                this.groupBox1.Text = "Ürünlere ait KDV\'siz fiyatlar";
                // 
                // telefonNumericUD
                // 
                this.telefonNumericUD.Location = new System.Drawing.Point(242, 349);
                this.telefonNumericUD.Name = "telefonNumericUD";
                this.telefonNumericUD.Size = new System.Drawing.Size(38, 20);
                this.telefonNumericUD.TabIndex = 13;
                // 
                // laptopNumericUD
                // 
                this.laptopNumericUD.Location = new System.Drawing.Point(71, 349);
                this.laptopNumericUD.Name = "laptopNumericUD";
                this.laptopNumericUD.Size = new System.Drawing.Size(38, 20);
                this.laptopNumericUD.TabIndex = 13;
                // 
                // label16
                // 
                this.label16.AutoSize = true;
                this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.label16.Location = new System.Drawing.Point(182, 349);
                this.label16.Name = "label16";
                this.label16.Size = new System.Drawing.Size(35, 13);
                this.label16.TabIndex = 12;
                this.label16.Text = "Adet :";
                // 
                // buzdolabiNumericUD
                // 
                this.buzdolabiNumericUD.Location = new System.Drawing.Point(242, 171);
                this.buzdolabiNumericUD.Name = "buzdolabiNumericUD";
                this.buzdolabiNumericUD.Size = new System.Drawing.Size(38, 20);
                this.buzdolabiNumericUD.TabIndex = 13;
                // 
                // telefonStokLabel
                // 
                this.telefonStokLabel.AutoSize = true;
                this.telefonStokLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.telefonStokLabel.Location = new System.Drawing.Point(239, 331);
                this.telefonStokLabel.Name = "telefonStokLabel";
                this.telefonStokLabel.Size = new System.Drawing.Size(19, 13);
                this.telefonStokLabel.TabIndex = 11;
                this.telefonStokLabel.Text = Convert.ToString(c.stokAdedi - c.secilenAdedi);
                // 
                // adetLabel2
                // 
                this.adetLabel2.AutoSize = true;
                this.adetLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.adetLabel2.Location = new System.Drawing.Point(11, 349);
                this.adetLabel2.Name = "adetLabel2";
                this.adetLabel2.Size = new System.Drawing.Size(35, 13);
                this.adetLabel2.TabIndex = 12;
                this.adetLabel2.Text = "Adet :";
                // 
                // stokLabel4
                // 
                this.stokLabel4.AutoSize = true;
                this.stokLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.stokLabel4.Location = new System.Drawing.Point(182, 332);
                this.stokLabel4.Name = "stokLabel4";
                this.stokLabel4.Size = new System.Drawing.Size(35, 13);
                this.stokLabel4.TabIndex = 10;
                this.stokLabel4.Text = "Stok :";
                // 
                // adetLabel3
                // 
                this.adetLabel3.AutoSize = true;
                this.adetLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.adetLabel3.Location = new System.Drawing.Point(182, 171);
                this.adetLabel3.Name = "adetLabel3";
                this.adetLabel3.Size = new System.Drawing.Size(35, 13);
                this.adetLabel3.TabIndex = 12;
                this.adetLabel3.Text = "Adet :";
                // 
                // telefonFiyatLabel
                // 
                this.telefonFiyatLabel.AutoSize = true;
                this.telefonFiyatLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.telefonFiyatLabel.Location = new System.Drawing.Point(239, 309);
                this.telefonFiyatLabel.Name = "telefonFiyatLabel";
                this.telefonFiyatLabel.Size = new System.Drawing.Size(31, 13);
                this.telefonFiyatLabel.TabIndex = 9;
                this.telefonFiyatLabel.Text = Convert.ToString(c.HamFiyat);
                // 
                // laptopStokLabel
                // 
                this.laptopStokLabel.AutoSize = true;
                this.laptopStokLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.laptopStokLabel.Location = new System.Drawing.Point(68, 331);
                this.laptopStokLabel.Name = "laptopStokLabel";
                this.laptopStokLabel.Size = new System.Drawing.Size(19, 13);
                this.laptopStokLabel.TabIndex = 11;
                this.laptopStokLabel.Text = Convert.ToString(l.stokAdedi - l.secilenAdedi);
                // 
                // fiyatLabel4
                // 
                this.fiyatLabel4.AutoSize = true;
                this.fiyatLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.fiyatLabel4.Location = new System.Drawing.Point(182, 310);
                this.fiyatLabel4.Name = "fiyatLabel4";
                this.fiyatLabel4.Size = new System.Drawing.Size(35, 13);
                this.fiyatLabel4.TabIndex = 8;
                this.fiyatLabel4.Text = "Fiyat :";
                // 
                // buzdolabiStokLabel
                // 
                this.buzdolabiStokLabel.AutoSize = true;
                this.buzdolabiStokLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.buzdolabiStokLabel.Location = new System.Drawing.Point(239, 153);
                this.buzdolabiStokLabel.Name = "buzdolabiStokLabel";
                this.buzdolabiStokLabel.Size = new System.Drawing.Size(19, 13);
                this.buzdolabiStokLabel.TabIndex = 11;
                this.buzdolabiStokLabel.Text = Convert.ToString(b.stokAdedi - b.secilenAdedi);
                // 
                // pictureBox4
                // 
                this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
                this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.pictureBox4.Location = new System.Drawing.Point(181, 197);
                this.pictureBox4.Name = "pictureBox4";
                this.pictureBox4.Size = new System.Drawing.Size(126, 106);
                this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pictureBox4.TabIndex = 7;
                this.pictureBox4.TabStop = false;
                // 
                // stokLabel2
                // 
                this.stokLabel2.AutoSize = true;
                this.stokLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.stokLabel2.Location = new System.Drawing.Point(11, 332);
                this.stokLabel2.Name = "stokLabel2";
                this.stokLabel2.Size = new System.Drawing.Size(35, 13);
                this.stokLabel2.TabIndex = 10;
                this.stokLabel2.Text = "Stok :";
                // 
                // stokLabel3
                // 
                this.stokLabel3.AutoSize = true;
                this.stokLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.stokLabel3.Location = new System.Drawing.Point(182, 154);
                this.stokLabel3.Name = "stokLabel3";
                this.stokLabel3.Size = new System.Drawing.Size(35, 13);
                this.stokLabel3.TabIndex = 10;
                this.stokLabel3.Text = "Stok :";
                // 
                // laptopFiyatLabel
                // 
                this.laptopFiyatLabel.AutoSize = true;
                this.laptopFiyatLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.laptopFiyatLabel.Location = new System.Drawing.Point(68, 309);
                this.laptopFiyatLabel.Name = "laptopFiyatLabel";
                this.laptopFiyatLabel.Size = new System.Drawing.Size(31, 13);
                this.laptopFiyatLabel.TabIndex = 9;
                this.laptopFiyatLabel.Text = Convert.ToString(l.HamFiyat);
                // 
                // buzdolabiFiyatLabel
                // 
                this.buzdolabiFiyatLabel.AutoSize = true;
                this.buzdolabiFiyatLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.buzdolabiFiyatLabel.Location = new System.Drawing.Point(239, 131);
                this.buzdolabiFiyatLabel.Name = "buzdolabiFiyatLabel";
                this.buzdolabiFiyatLabel.Size = new System.Drawing.Size(31, 13);
                this.buzdolabiFiyatLabel.TabIndex = 9;
                this.buzdolabiFiyatLabel.Text = Convert.ToString(b.HamFiyat);
                // 
                // fiyatLabel2
                // 
                this.fiyatLabel2.AutoSize = true;
                this.fiyatLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.fiyatLabel2.Location = new System.Drawing.Point(11, 310);
                this.fiyatLabel2.Name = "fiyatLabel2";
                this.fiyatLabel2.Size = new System.Drawing.Size(35, 13);
                this.fiyatLabel2.TabIndex = 8;
                this.fiyatLabel2.Text = "Fiyat :";
                // 
                // fiyatLabel3
                // 
                this.fiyatLabel3.AutoSize = true;
                this.fiyatLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.fiyatLabel3.Location = new System.Drawing.Point(182, 132);
                this.fiyatLabel3.Name = "fiyatLabel3";
                this.fiyatLabel3.Size = new System.Drawing.Size(35, 13);
                this.fiyatLabel3.TabIndex = 8;
                this.fiyatLabel3.Text = "Fiyat :";
                // 
                // pictureBox3
                // 
                this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
                this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.pictureBox3.Location = new System.Drawing.Point(7, 197);
                this.pictureBox3.Name = "pictureBox3";
                this.pictureBox3.Size = new System.Drawing.Size(126, 106);
                this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox3.TabIndex = 7;
                this.pictureBox3.TabStop = false;
                // 
                // pictureBox2
                // 
                this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
                this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.pictureBox2.Location = new System.Drawing.Point(181, 19);
                this.pictureBox2.Name = "pictureBox2";
                this.pictureBox2.Size = new System.Drawing.Size(126, 106);
                this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox2.TabIndex = 7;
                this.pictureBox2.TabStop = false;
                // 
                // tvNumericUD
                // 
                this.tvNumericUD.Location = new System.Drawing.Point(67, 171);
                this.tvNumericUD.Name = "tvNumericUD";
                this.tvNumericUD.Size = new System.Drawing.Size(38, 20);
                this.tvNumericUD.TabIndex = 6;
                // 
                // adetLabel
                // 
                this.adetLabel.AutoSize = true;
                this.adetLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.adetLabel.Location = new System.Drawing.Point(7, 171);
                this.adetLabel.Name = "adetLabel";
                this.adetLabel.Size = new System.Drawing.Size(35, 13);
                this.adetLabel.TabIndex = 5;
                this.adetLabel.Text = "Adet :";
                // 
                // tvStokLabel
                // 
                this.tvStokLabel.AutoSize = true;
                this.tvStokLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.tvStokLabel.Location = new System.Drawing.Point(64, 153);
                this.tvStokLabel.Name = "tvStokLabel";
                this.tvStokLabel.Size = new System.Drawing.Size(19, 13);
                this.tvStokLabel.TabIndex = 4;
                this.tvStokLabel.Text = Convert.ToString(ltv.stokAdedi - ltv.secilenAdedi);
                // 
                // stokLabel
                // 
                this.stokLabel.AutoSize = true;
                this.stokLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.stokLabel.Location = new System.Drawing.Point(7, 154);
                this.stokLabel.Name = "stokLabel";
                this.stokLabel.Size = new System.Drawing.Size(35, 13);
                this.stokLabel.TabIndex = 3;
                this.stokLabel.Text = "Stok :";
                // 
                // tvFiyatLabel
                // 
                this.tvFiyatLabel.AutoSize = true;
                this.tvFiyatLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.tvFiyatLabel.Location = new System.Drawing.Point(64, 131);
                this.tvFiyatLabel.Name = "tvFiyatLabel";
                this.tvFiyatLabel.Size = new System.Drawing.Size(31, 13);
                this.tvFiyatLabel.TabIndex = 2;
                this.tvFiyatLabel.Text = Convert.ToString(ltv.HamFiyat);
                // 
                // fiyatLabel
                // 
                this.fiyatLabel.AutoSize = true;
                this.fiyatLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.fiyatLabel.Location = new System.Drawing.Point(11, 132);
                this.fiyatLabel.Name = "fiyatLabel";
                this.fiyatLabel.Size = new System.Drawing.Size(35, 13);
                this.fiyatLabel.TabIndex = 1;
                this.fiyatLabel.Text = "Fiyat :";
                // 
                // tvPictureBox
                // 
                this.tvPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tvPictureBox.Image")));
                this.tvPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                this.tvPictureBox.Location = new System.Drawing.Point(6, 19);
                this.tvPictureBox.Name = "tvPictureBox";
                this.tvPictureBox.Size = new System.Drawing.Size(126, 106);
                this.tvPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.tvPictureBox.TabIndex = 0;
                this.tvPictureBox.TabStop = false;
                //
                //sepetiSil
                //
                this.sepetiTemizleButton.Location = new System.Drawing.Point(193, 421);
                this.sepetiTemizleButton.Name = "sepetiTemizleButton";
                this.sepetiTemizleButton.Size = new System.Drawing.Size(126, 30);
                this.sepetiTemizleButton.TabIndex = 9;
                this.sepetiTemizleButton.Text = "sepeti &Temizle";
                this.sepetiTemizleButton.UseVisualStyleBackColor = true;
                this.sepetiTemizleButton.Click += new System.EventHandler(this.sepetiTemizleButton_Click);

                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(592, 491);
                this.Controls.Add(this.groupBox2);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.sepetiTemizleButton);
                this.Controls.Add(this.groupBox1);
                this.Name = "Form1";
                this.groupBox2.ResumeLayout(false);
                this.groupBox2.PerformLayout();
                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.telefonNumericUD)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.laptopNumericUD)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.buzdolabiNumericUD)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.tvNumericUD)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.tvPictureBox)).EndInit();
                this.ResumeLayout(false);
            }
            public class Urun
            {
                public string ad;
                public string marka;
                public string ozellik;
                public int stokAdedi;
                public double HamFiyat;
                public int secilenAdedi;
                static Random rastgele = new Random();
                public Urun(string ad, string marka, string ozellik, double HamFiyat, int secilenAdedi)//parametreli kurucu
                {
                    this.ad = ad;
                    this.marka = marka;
                    this.ozellik = ozellik;
                    this.HamFiyat = HamFiyat;
                    this.secilenAdedi = secilenAdedi;
                    stokAdedi = rastgele.Next(1, 100);
                }
                public double KdvUygula(Urun URUN)//verilen urunune gore kdvli ucret dondurur
                {
                    double Kdvli = 0;
                    switch (URUN.ad)
                    {
                        case "Laptop":
                            Kdvli = URUN.HamFiyat * 1.15 * URUN.secilenAdedi;
                            break;
                        case "Buzdolabı":
                            Kdvli = URUN.HamFiyat * 1.05 * URUN.secilenAdedi;
                            break;
                        case "Cep Telefonu":
                            Kdvli = URUN.HamFiyat * 1.20 * URUN.secilenAdedi;
                            break;
                        case "Led TV":
                            Kdvli = URUN.HamFiyat * 1.18 * URUN.secilenAdedi;
                            break;
                    }
                    return Kdvli;
                }
            }
            public class Buzdolabi : Urun
            {
                public int IcHacim;
                public string EnerjiSinifi;
                public Buzdolabi(string ad, string marka, string ozellik, double HamFiyat, int secilenAdedi, int icHacim, string enerjiSinifi) : base(ad, marka, ozellik, HamFiyat, secilenAdedi)
                {
                    this.IcHacim = icHacim; EnerjiSinifi = enerjiSinifi;
                }
            }

            public class LedTv : Urun
            {
                public int EkranBoyutu;
                public string EkranCozunurlugu;
                public LedTv(string ad, string marka, string ozellik, double HamFiyat, int secilenAdedi, int EkranBoyutu, string EkranCozunurlugu) : base(ad, marka, ozellik, HamFiyat, secilenAdedi)
                {
                    this.EkranBoyutu = EkranBoyutu; this.EkranCozunurlugu = EkranCozunurlugu;
                }
            }

            public class CepTel : Urun
            {
                public int DahiliHafiza;
                public int RamKapasitesi;
                public int PilGucu;
                public CepTel(string ad, string marka, string ozellik, double HamFiyat, int secilenAdedi, int DahiliHafiza, int RamKapasitesi, int PilGucu) : base(ad, marka, ozellik, HamFiyat, secilenAdedi)
                {
                    this.PilGucu = PilGucu; this.RamKapasitesi = RamKapasitesi; this.DahiliHafiza = DahiliHafiza;
                }
            }

            public class Laptop : Urun
            {
                public int EkranBoyutu;
                public string EkranCozunurluk;
                public int DahiliHafiza;
                public int RamKapasitesi;
                public int PilGucu;
                public Laptop(string ad, string marka, string ozellik, double HamFiyat, int secilenAdedi, int EkranBoyutu, string EkranCozunurluk, int DahiliHafiza, int RamKapasitesi, int PilGucu) : base(ad, marka, ozellik, HamFiyat, secilenAdedi)
                {
                    this.EkranBoyutu = EkranBoyutu; this.EkranCozunurluk = EkranCozunurluk; this.PilGucu = PilGucu; this.RamKapasitesi = RamKapasitesi; this.DahiliHafiza = DahiliHafiza;
                }
            }

            public class Sepet
            {
                public Laptop LAPTOP;
                public CepTel CEPTEL;
                public LedTv LEDTV;
                public Buzdolabi BUZDOLABI;
                public double toplamFiyat;
                public Sepet(Laptop LAPTOP, CepTel CEPTEL, LedTv LEDTV, Buzdolabi BUZDOLABI)
                {
                    this.LAPTOP = LAPTOP; this.CEPTEL = CEPTEL; this.LEDTV = LEDTV; this.BUZDOLABI = BUZDOLABI;
                }
                public void SepeteUrunEkle(Urun URUN)//urunlere kdv uygular ve son fiyatİ bulur
                {
                    if (URUN.secilenAdedi > URUN.stokAdedi)//stok adedinden fazla istek yaparsanız uyarır
                        MessageBox.Show("Stok adedini aştınız, lütfen stok adedi kadar giriş yapınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toplamFiyat = LAPTOP.KdvUygula(LAPTOP) + CEPTEL.KdvUygula(CEPTEL) + LEDTV.KdvUygula(LEDTV) + BUZDOLABI.KdvUygula(BUZDOLABI);
                }
            }

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            Laptop l = new Laptop("Laptop", "hp", "ssd", 6000, 0, 20, "1200x1600", 500, 16, 10000);// Urun veri girisi
            CepTel c = new CepTel("Cep Telefonu", "samsung", "amoled", 2500, 0, 32, 4, 3500);
            Buzdolabi b = new Buzdolabi("Buzdolabı", "arçelik", "no-frost", 3500, 0, 8, "aa");
            LedTv ltv = new LedTv("Led TV", "lg", "4k", 4000, 0, 124, " x ");
            public void StokYaz()//Sepete eklenince urun stok sayisini gunceller
            {
                tvStokLabel.Text = Convert.ToString(ltv.stokAdedi);
                telefonStokLabel.Text = Convert.ToString(c.stokAdedi);
                buzdolabiStokLabel.Text = Convert.ToString(b.stokAdedi);
                laptopStokLabel.Text = Convert.ToString(l.stokAdedi);
            }
            public void ListeTemizle()//listboxlari temizler
            {
                adetListBox.Items.Clear();
                kdvliFiyatListBox.Items.Clear();
                urunListBox.Items.Clear();
            }
            private void button1_Click(object sender, EventArgs e)
            {
                Sepet sepet1 = new Sepet(l, c, ltv, b);
                ListeTemizle();
                ltv.secilenAdedi = Convert.ToInt32(tvNumericUD.Value);
                b.secilenAdedi = Convert.ToInt32(buzdolabiNumericUD.Value);
                c.secilenAdedi = Convert.ToInt32(telefonNumericUD.Value);
                l.secilenAdedi = Convert.ToInt32(laptopNumericUD.Value);
                sepet1.SepeteUrunEkle(sepet1.LEDTV);//urunlerin kdv hesabını yapar ve stok adedine gore uyari verir.
                sepet1.SepeteUrunEkle(sepet1.BUZDOLABI);
                sepet1.SepeteUrunEkle(sepet1.CEPTEL);
                sepet1.SepeteUrunEkle(sepet1.LAPTOP);
                if (Convert.ToInt32(tvNumericUD.Value) != 0 && (ltv.stokAdedi - ltv.secilenAdedi) >= 0)// listelere tv ekler ekler
                {
                    adetListBox.Items.Add(ltv.secilenAdedi);
                    urunListBox.Items.Add("Led Tv");
                    kdvliFiyatListBox.Items.Add(ltv.KdvUygula(ltv));
                    ltv.stokAdedi -= ltv.secilenAdedi;
                    StokYaz();
                }

                if (Convert.ToInt32(buzdolabiNumericUD.Value) != 0 && (b.stokAdedi - b.secilenAdedi) >= 0)// listelere buzdolabi ekler ekler
                {
                    adetListBox.Items.Add(b.secilenAdedi);
                    urunListBox.Items.Add("Buzdolabı");
                    kdvliFiyatListBox.Items.Add(b.KdvUygula(b));
                    b.stokAdedi -= b.secilenAdedi;
                    StokYaz();
                }

                if (Convert.ToInt32(telefonNumericUD.Value) != 0 && (c.stokAdedi - c.secilenAdedi) >= 0)// listelere cep telefonu ekler ekler
                {
                    adetListBox.Items.Add(c.secilenAdedi);
                    urunListBox.Items.Add("Cep Telefonu");
                    kdvliFiyatListBox.Items.Add(c.KdvUygula(c));
                    c.stokAdedi -= c.secilenAdedi;
                    StokYaz();
                }

                if (Convert.ToInt32(laptopNumericUD.Value) != 0 && (l.stokAdedi - l.secilenAdedi) >= 0)// listelere laptop ekler ekler
                {
                    adetListBox.Items.Add(l.secilenAdedi);
                    urunListBox.Items.Add("Laptop");
                    kdvliFiyatListBox.Items.Add(l.KdvUygula(l));
                    l.stokAdedi -= l.secilenAdedi;
                    StokYaz();
                }
                kdvliFiyatLabel.Text = Convert.ToString(sepet1.toplamFiyat);
            }
            private void sepetiTemizleButton_Click(object sender, EventArgs e)
            {
                l.stokAdedi += l.secilenAdedi;//stok adedi negatif ise geri yukleme yapmaz
                c.stokAdedi += c.secilenAdedi;
                b.stokAdedi += b.secilenAdedi;
                ltv.stokAdedi += ltv.secilenAdedi;
                StokYaz();
                l.secilenAdedi = 0;
                b.secilenAdedi = 0;
                c.secilenAdedi = 0;
                ltv.secilenAdedi = 0;
                tvNumericUD.Value = 0;
                telefonNumericUD.Value = 0;
                buzdolabiNumericUD.Value = 0;
                laptopNumericUD.Value = 0;
                kdvliFiyatLabel.Text = "0";
                ListeTemizle();
            }
        }
    }   
}
