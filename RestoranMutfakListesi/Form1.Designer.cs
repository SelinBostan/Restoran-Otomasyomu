
namespace RestoranMutfakListesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.tarifno = new System.Windows.Forms.NumericUpDown();
            this.porsiyon = new System.Windows.Forms.NumericUpDown();
            this.gununProgramınaEkle = new System.Windows.Forms.Button();
            this.alınacaklarListesiVer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniMalzeme = new System.Windows.Forms.TextBox();
            this.yeniTarifNoLabel = new System.Windows.Forms.Label();
            this.yeniTarifNo = new System.Windows.Forms.NumericUpDown();
            this.yeniMalzeme_Onay = new System.Windows.Forms.Button();
            this.tarifNo_onay = new System.Windows.Forms.Button();
            this.yeniMalzemeBirim2 = new System.Windows.Forms.RadioButton();
            this.yeniMalzemeBirim1 = new System.Windows.Forms.RadioButton();
            this.siparisListesiVer = new System.Windows.Forms.Button();
            this.musteriBilgiText = new System.Windows.Forms.TextBox();
            this.listeleriTemizle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.yeniMalzemeMiktar = new System.Windows.Forms.TextBox();
            this.siparisSil_tarifNo = new System.Windows.Forms.NumericUpDown();
            this.siparisSil_onay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.masaNoTextBox = new System.Windows.Forms.TextBox();
            this.siparisSil_masaNo = new System.Windows.Forms.TextBox();
            this.siparisSil_porsiyon = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tarifno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porsiyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniTarifNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisSil_tarifNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisSil_porsiyon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-91, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Günün programına ekle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tarifno
            // 
            this.tarifno.BackColor = System.Drawing.Color.Firebrick;
            this.tarifno.Location = new System.Drawing.Point(302, 406);
            this.tarifno.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.tarifno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarifno.MinimumSize = new System.Drawing.Size(100, 0);
            this.tarifno.Name = "tarifno";
            this.tarifno.Size = new System.Drawing.Size(117, 22);
            this.tarifno.TabIndex = 2;
            this.tarifno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // porsiyon
            // 
            this.porsiyon.BackColor = System.Drawing.Color.Firebrick;
            this.porsiyon.Location = new System.Drawing.Point(437, 406);
            this.porsiyon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porsiyon.Name = "porsiyon";
            this.porsiyon.Size = new System.Drawing.Size(113, 22);
            this.porsiyon.TabIndex = 3;
            this.porsiyon.Tag = "";
            this.porsiyon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gununProgramınaEkle
            // 
            this.gununProgramınaEkle.BackColor = System.Drawing.Color.Firebrick;
            this.gununProgramınaEkle.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.gununProgramınaEkle.Location = new System.Drawing.Point(1039, 392);
            this.gununProgramınaEkle.Name = "gununProgramınaEkle";
            this.gununProgramınaEkle.Size = new System.Drawing.Size(50, 45);
            this.gununProgramınaEkle.TabIndex = 4;
            this.gununProgramınaEkle.Text = "a";
            this.gununProgramınaEkle.UseVisualStyleBackColor = false;
            this.gununProgramınaEkle.Click += new System.EventHandler(this.gununProgramınaEkle_Click_1);
            // 
            // alınacaklarListesiVer
            // 
            this.alınacaklarListesiVer.BackColor = System.Drawing.Color.Maroon;
            this.alınacaklarListesiVer.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınacaklarListesiVer.Location = new System.Drawing.Point(361, 563);
            this.alınacaklarListesiVer.Name = "alınacaklarListesiVer";
            this.alınacaklarListesiVer.Size = new System.Drawing.Size(504, 62);
            this.alınacaklarListesiVer.TabIndex = 5;
            this.alınacaklarListesiVer.Text = "Alınacaklar  Listesi  Ver";
            this.alınacaklarListesiVer.UseVisualStyleBackColor = false;
            this.alınacaklarListesiVer.Click += new System.EventHandler(this.alınacaklarListesiVer_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 294);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Tarif";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(455, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 294);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yeniMalzeme
            // 
            this.yeniMalzeme.BackColor = System.Drawing.Color.LightGray;
            this.yeniMalzeme.Location = new System.Drawing.Point(51, 218);
            this.yeniMalzeme.Name = "yeniMalzeme";
            this.yeniMalzeme.Size = new System.Drawing.Size(100, 22);
            this.yeniMalzeme.TabIndex = 8;
            this.yeniMalzeme.Text = "Malzeme";
            // 
            // yeniTarifNoLabel
            // 
            this.yeniTarifNoLabel.BackColor = System.Drawing.Color.LightGray;
            this.yeniTarifNoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yeniTarifNoLabel.Location = new System.Drawing.Point(51, 107);
            this.yeniTarifNoLabel.Name = "yeniTarifNoLabel";
            this.yeniTarifNoLabel.Size = new System.Drawing.Size(100, 23);
            this.yeniTarifNoLabel.TabIndex = 10;
            this.yeniTarifNoLabel.Text = "Tarif No";
            this.yeniTarifNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yeniTarifNo
            // 
            this.yeniTarifNo.BackColor = System.Drawing.Color.LightGray;
            this.yeniTarifNo.Location = new System.Drawing.Point(189, 107);
            this.yeniTarifNo.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.yeniTarifNo.Name = "yeniTarifNo";
            this.yeniTarifNo.Size = new System.Drawing.Size(120, 22);
            this.yeniTarifNo.TabIndex = 11;
            // 
            // yeniMalzeme_Onay
            // 
            this.yeniMalzeme_Onay.BackColor = System.Drawing.Color.Firebrick;
            this.yeniMalzeme_Onay.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.yeniMalzeme_Onay.Location = new System.Drawing.Point(350, 202);
            this.yeniMalzeme_Onay.Name = "yeniMalzeme_Onay";
            this.yeniMalzeme_Onay.Size = new System.Drawing.Size(50, 45);
            this.yeniMalzeme_Onay.TabIndex = 12;
            this.yeniMalzeme_Onay.Text = "a";
            this.yeniMalzeme_Onay.UseVisualStyleBackColor = false;
            this.yeniMalzeme_Onay.Click += new System.EventHandler(this.yeniMalzeme_Onay_Click);
            // 
            // tarifNo_onay
            // 
            this.tarifNo_onay.BackColor = System.Drawing.Color.Firebrick;
            this.tarifNo_onay.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tarifNo_onay.Location = new System.Drawing.Point(350, 91);
            this.tarifNo_onay.Name = "tarifNo_onay";
            this.tarifNo_onay.Size = new System.Drawing.Size(50, 45);
            this.tarifNo_onay.TabIndex = 13;
            this.tarifNo_onay.Text = "a";
            this.tarifNo_onay.UseVisualStyleBackColor = false;
            this.tarifNo_onay.Click += new System.EventHandler(this.tarifNo_onay_Click);
            // 
            // yeniMalzemeBirim2
            // 
            this.yeniMalzemeBirim2.BackColor = System.Drawing.Color.LightGray;
            this.yeniMalzemeBirim2.Location = new System.Drawing.Point(272, 231);
            this.yeniMalzemeBirim2.Name = "yeniMalzemeBirim2";
            this.yeniMalzemeBirim2.Size = new System.Drawing.Size(61, 24);
            this.yeniMalzemeBirim2.TabIndex = 14;
            this.yeniMalzemeBirim2.TabStop = true;
            this.yeniMalzemeBirim2.Text = "kg";
            this.yeniMalzemeBirim2.UseVisualStyleBackColor = false;
            // 
            // yeniMalzemeBirim1
            // 
            this.yeniMalzemeBirim1.BackColor = System.Drawing.Color.LightGray;
            this.yeniMalzemeBirim1.Location = new System.Drawing.Point(272, 201);
            this.yeniMalzemeBirim1.Name = "yeniMalzemeBirim1";
            this.yeniMalzemeBirim1.Size = new System.Drawing.Size(61, 24);
            this.yeniMalzemeBirim1.TabIndex = 15;
            this.yeniMalzemeBirim1.TabStop = true;
            this.yeniMalzemeBirim1.Text = "adet";
            this.yeniMalzemeBirim1.UseVisualStyleBackColor = false;
            // 
            // siparisListesiVer
            // 
            this.siparisListesiVer.BackColor = System.Drawing.Color.Maroon;
            this.siparisListesiVer.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisListesiVer.Location = new System.Drawing.Point(361, 474);
            this.siparisListesiVer.Name = "siparisListesiVer";
            this.siparisListesiVer.Size = new System.Drawing.Size(504, 62);
            this.siparisListesiVer.TabIndex = 16;
            this.siparisListesiVer.Text = "Sipariş Listesi Ver";
            this.siparisListesiVer.UseVisualStyleBackColor = false;
            this.siparisListesiVer.Click += new System.EventHandler(this.siparisListesiVer_Click);
            // 
            // musteriBilgiText
            // 
            this.musteriBilgiText.BackColor = System.Drawing.Color.Firebrick;
            this.musteriBilgiText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriBilgiText.Location = new System.Drawing.Point(576, 404);
            this.musteriBilgiText.Name = "musteriBilgiText";
            this.musteriBilgiText.Size = new System.Drawing.Size(306, 30);
            this.musteriBilgiText.TabIndex = 17;
            this.musteriBilgiText.Text = "Musteri isim-soy isim";
            // 
            // listeleriTemizle
            // 
            this.listeleriTemizle.BackColor = System.Drawing.Color.Firebrick;
            this.listeleriTemizle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeleriTemizle.Location = new System.Drawing.Point(1008, 575);
            this.listeleriTemizle.Name = "listeleriTemizle";
            this.listeleriTemizle.Size = new System.Drawing.Size(81, 50);
            this.listeleriTemizle.TabIndex = 18;
            this.listeleriTemizle.Text = "Listeleri Temizle";
            this.listeleriTemizle.UseVisualStyleBackColor = false;
            this.listeleriTemizle.Click += new System.EventHandler(this.listeleriTemizle_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Firebrick;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(495, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 27);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Kara Lahana Sarması";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Firebrick;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(495, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 27);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "Lahana Sarması";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Firebrick;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(495, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 27);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "Kabak Graten";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Firebrick;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(857, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(284, 27);
            this.textBox5.TabIndex = 23;
            this.textBox5.Text = "Brokoli Çorbası";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Firebrick;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(857, 155);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(297, 27);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = "Nigar Çorbası";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Firebrick;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(857, 214);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(284, 27);
            this.textBox7.TabIndex = 25;
            this.textBox7.Text = "Kabak Çiçeği Dolması";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Firebrick;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(857, 278);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(284, 27);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "Patates Rulo";
            // 
            // yeniMalzemeMiktar
            // 
            this.yeniMalzemeMiktar.BackColor = System.Drawing.Color.LightGray;
            this.yeniMalzemeMiktar.Location = new System.Drawing.Point(166, 218);
            this.yeniMalzemeMiktar.Name = "yeniMalzemeMiktar";
            this.yeniMalzemeMiktar.Size = new System.Drawing.Size(90, 22);
            this.yeniMalzemeMiktar.TabIndex = 27;
            this.yeniMalzemeMiktar.Text = "Miktar";
            // 
            // siparisSil_tarifNo
            // 
            this.siparisSil_tarifNo.BackColor = System.Drawing.Color.LightGray;
            this.siparisSil_tarifNo.Location = new System.Drawing.Point(129, 530);
            this.siparisSil_tarifNo.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.siparisSil_tarifNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.siparisSil_tarifNo.Name = "siparisSil_tarifNo";
            this.siparisSil_tarifNo.Size = new System.Drawing.Size(85, 22);
            this.siparisSil_tarifNo.TabIndex = 28;
            this.siparisSil_tarifNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // siparisSil_onay
            // 
            this.siparisSil_onay.BackColor = System.Drawing.Color.Firebrick;
            this.siparisSil_onay.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.siparisSil_onay.Location = new System.Drawing.Point(230, 519);
            this.siparisSil_onay.Name = "siparisSil_onay";
            this.siparisSil_onay.Size = new System.Drawing.Size(50, 45);
            this.siparisSil_onay.TabIndex = 30;
            this.siparisSil_onay.Text = "a";
            this.siparisSil_onay.UseVisualStyleBackColor = false;
            this.siparisSil_onay.Click += new System.EventHandler(this.siparisSil_onay_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "tarif no";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "masa no";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // masaNoTextBox
            // 
            this.masaNoTextBox.BackColor = System.Drawing.Color.Firebrick;
            this.masaNoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masaNoTextBox.Location = new System.Drawing.Point(904, 404);
            this.masaNoTextBox.Name = "masaNoTextBox";
            this.masaNoTextBox.Size = new System.Drawing.Size(109, 30);
            this.masaNoTextBox.TabIndex = 33;
            this.masaNoTextBox.Text = "Masa no";
            // 
            // siparisSil_masaNo
            // 
            this.siparisSil_masaNo.BackColor = System.Drawing.Color.LightGray;
            this.siparisSil_masaNo.Location = new System.Drawing.Point(129, 500);
            this.siparisSil_masaNo.Name = "siparisSil_masaNo";
            this.siparisSil_masaNo.Size = new System.Drawing.Size(83, 22);
            this.siparisSil_masaNo.TabIndex = 35;
            // 
            // siparisSil_porsiyon
            // 
            this.siparisSil_porsiyon.BackColor = System.Drawing.Color.LightGray;
            this.siparisSil_porsiyon.Location = new System.Drawing.Point(131, 563);
            this.siparisSil_porsiyon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.siparisSil_porsiyon.Name = "siparisSil_porsiyon";
            this.siparisSil_porsiyon.Size = new System.Drawing.Size(81, 22);
            this.siparisSil_porsiyon.TabIndex = 36;
            this.siparisSil_porsiyon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(29, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "porsiyon";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Firebrick;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(495, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 27);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "Zeytinyağlı Enginar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1194, 665);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.siparisSil_porsiyon);
            this.Controls.Add(this.siparisSil_masaNo);
            this.Controls.Add(this.masaNoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.siparisSil_onay);
            this.Controls.Add(this.siparisSil_tarifNo);
            this.Controls.Add(this.yeniMalzemeMiktar);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listeleriTemizle);
            this.Controls.Add(this.musteriBilgiText);
            this.Controls.Add(this.siparisListesiVer);
            this.Controls.Add(this.yeniMalzemeBirim1);
            this.Controls.Add(this.yeniMalzemeBirim2);
            this.Controls.Add(this.tarifNo_onay);
            this.Controls.Add(this.yeniMalzeme_Onay);
            this.Controls.Add(this.yeniTarifNo);
            this.Controls.Add(this.yeniTarifNoLabel);
            this.Controls.Add(this.yeniMalzeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alınacaklarListesiVer);
            this.Controls.Add(this.gununProgramınaEkle);
            this.Controls.Add(this.porsiyon);
            this.Controls.Add(this.tarifno);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tarifno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porsiyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniTarifNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisSil_tarifNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisSil_porsiyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tarifno;
        private System.Windows.Forms.NumericUpDown porsiyon;
        private System.Windows.Forms.Button gununProgramınaEkle;
        private System.Windows.Forms.Button alınacaklarListesiVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yeniMalzeme;
        private System.Windows.Forms.Label yeniTarifNoLabel;
        private System.Windows.Forms.NumericUpDown yeniTarifNo;
        private System.Windows.Forms.Button yeniMalzeme_Onay;
        private System.Windows.Forms.Button tarifNo_onay;
        private System.Windows.Forms.RadioButton yeniMalzemeBirim2;
        private System.Windows.Forms.RadioButton yeniMalzemeBirim1;
        private System.Windows.Forms.Button siparisListesiVer;
        private System.Windows.Forms.TextBox musteriBilgiText;
        private System.Windows.Forms.Button listeleriTemizle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox yeniMalzemeMiktar;
        private System.Windows.Forms.NumericUpDown siparisSil_tarifNo;
        private System.Windows.Forms.Button siparisSil_onay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox masaNoTextBox;
        private System.Windows.Forms.TextBox siparisSil_masaNo;
        private System.Windows.Forms.NumericUpDown siparisSil_porsiyon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

