using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RestoranMutfakListesi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AOVQC6V\\MSSQLSERVER01;Initial Catalog=MalzemeListeleri;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        List<Alınacaklar> alınacaklarListesi = new List<Alınacaklar>();
        List<MusteriBilgi> siparisListesi = new List<MusteriBilgi>();

        bool alınacaklarListesiVerTık = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void gununProgramınaEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();

            if (!alınacaklarListesiVerTık)
            {
                if (masaNoTextBox.TextLength > 0 && musteriBilgiText.TextLength > 0)
                {
                    string yemek = null;

                    if (tarifno.Value == 1)
                        yemek = textBox1.Text;
                    else if (tarifno.Value == 2)
                        yemek = textBox2.Text;
                    else if (tarifno.Value == 3)
                        yemek = textBox3.Text;
                    else if (tarifno.Value == 4)
                        yemek = textBox4.Text;
                    else if (tarifno.Value == 5)
                        yemek = textBox5.Text;
                    else if (tarifno.Value == 6)
                        yemek = textBox6.Text;
                    else if (tarifno.Value == 7)
                        yemek = textBox7.Text;
                    else if (tarifno.Value == 8)
                        yemek = textBox8.Text;

                    komut.CommandText = "INSERT INTO siparis(porsiyon,masano,tarif,musteri) VALUES (@porsiyon,@masano,@tarif,@musteri)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@porsiyon", Convert.ToInt32(porsiyon.Value));
                    komut.Parameters.AddWithValue("@masano", Convert.ToInt32(masaNoTextBox.Text));
                    komut.Parameters.AddWithValue("@tarif", yemek);
                    komut.Parameters.AddWithValue("@musteri", musteriBilgiText.Text.ToString());

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    tarifno.Value = 1;
                    porsiyon.Value = 1;
                    musteriBilgiText.Text = null;
                    masaNoTextBox.Text = null;
                }

                else
                    MessageBox.Show("Müşteri veya masa no bilgisi boş geçilemez");
            }

            else
                MessageBox.Show("Alınacaklar listesi oluşturulduktan sonra ekleme yapılamaz");
        }
        
        private void alınacaklarListesiVer_Click(object sender, EventArgs e)
        {
            if (alınacaklarListesiVerTık == false)
            {
                alınacalkarList_temizle();

                for (int i = 0; i < siparisListesi.Count; i++)
                {
                    SqlDataAdapter adap = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();

                    if (siparisListesi.ElementAt(i).Tarif == textBox1.Text)
                        komut.CommandText = "SELECT * FROM TABLO1";
                    else if (siparisListesi.ElementAt(i).Tarif == textBox2.Text)
                        komut.CommandText = "SELECT * FROM TABLO2";
                    else if (siparisListesi.ElementAt(i).Tarif == textBox3.Text)
                        komut.CommandText = "SELECT * FROM TABLO3";
                    else if (siparisListesi.ElementAt(i).Tarif == textBox4.Text)
                        komut.CommandText = "SELECT * FROM TABLO4";
                    else if (siparisListesi.ElementAt(i).Tarif == textBox5.Text)
                        komut.CommandText = "SELECT * FROM TABLO5";
                    else if (siparisListesi.ElementAt(i).Tarif == textBox6.Text)
                        komut.CommandText = "SELECT * FROM TABLO6";
                    else if (siparisListesi.ElementAt(i).Tarif == textBox7.Text)
                        komut.CommandText = "SELECT * FROM TABLO7";
                    else if (siparisListesi.ElementAt(i).Tarif == textBox8.Text)
                        komut.CommandText = "SELECT * FROM TABLO8";

                    komut.Connection = baglanti;
                    adap.Fill(dt);

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        alınacaklarListesi.Add(new Alınacaklar()
                        {
                            Malzeme = dt.Rows[j]["malzeme"].ToString(),
                            Miktar = (Convert.ToInt32(dt.Rows[j]["miktar"]) * siparisListesi.ElementAt(i).Porsiyon),
                            Birim = dt.Rows[j]["birim"].ToString()
                        });
                    }
                }


                for (int i = 0; i < alınacaklarListesi.Count; i++)
                {
                    for (int j = i + 1; j < alınacaklarListesi.Count; j++)
                    {
                        if (alınacaklarListesi.ElementAt(i).Malzeme == alınacaklarListesi.ElementAt(j).Malzeme)
                        {
                            alınacaklarListesi.ElementAt(i).Miktar += alınacaklarListesi.ElementAt(j).Miktar;
                            alınacaklarListesi.RemoveAt(j);
                        }
                    }
                }
            }


            string total = "";
            for (int i = 0; i < alınacaklarListesi.Count; i++)
            {
                string temp = alınacaklarListesi[i].Miktar.ToString();
                if (alınacaklarListesi[i].Birim=="kg")
                {
                    temp = Convert.ToString(alınacaklarListesi[i].Miktar / 1000);
                }
                total += alınacaklarListesi[i].Malzeme + "\t" + temp + alınacaklarListesi[i].Birim + "\n";
            }
            MessageBox.Show(total);

            alınacaklarListesiVerTık = true;
        }


        private void siparisListesiVer_Click(object sender, EventArgs e)
        {
            siparisList_Temizle();

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            komut.CommandText = "SELECT * FROM siparis";
            komut.Connection = baglanti;
            adap.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                siparisListesi.Add(new MusteriBilgi()
                {
                    Porsiyon = (int)dt.Rows[i]["porsiyon"],
                    MasaNo = (int)dt.Rows[i]["masano"],
                    Tarif = dt.Rows[i]["tarif"].ToString(),
                    Musteri = dt.Rows[i]["musteri"].ToString(),
                    
                });
            }

            for (int i = 0; i < siparisListesi.Count; i++)
            {
                for (int j = i + 1; j < siparisListesi.Count; j++)
                {
                    if (siparisListesi.ElementAt(i).MasaNo == siparisListesi.ElementAt(j).MasaNo && siparisListesi.ElementAt(i).Tarif == siparisListesi.ElementAt(j).Tarif)
                    {
                        siparisListesi.ElementAt(i).Porsiyon += siparisListesi.ElementAt(j).Porsiyon;
                        siparisListesi.RemoveAt(j);
                    }
                }
            }

            SqlCommand komut2 = new SqlCommand();

            komut2.CommandText = "DELETE FROM siparis";
            komut2.Connection = baglanti;

            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();

            for (int i = 0; i < siparisListesi.Count; i++)
            {
                SqlCommand komut3 = new SqlCommand();

                komut3.CommandText = "INSERT INTO siparis(porsiyon,masano,tarif,musteri) VALUES (@porsiyon,@masano,@tarif,@musteri)";
                komut3.Connection = baglanti;
                komut3.Parameters.AddWithValue("@porsiyon", siparisListesi.ElementAt(i).Porsiyon);
                komut3.Parameters.AddWithValue("@masano", siparisListesi.ElementAt(i).MasaNo);
                komut3.Parameters.AddWithValue("@tarif", siparisListesi.ElementAt(i).Tarif);
                komut3.Parameters.AddWithValue("@musteri", siparisListesi.ElementAt(i).Musteri);

                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }

            string total = "";
            for (int i = 0; i < siparisListesi.Count; i++)
            {
                total += siparisListesi[i].Tarif + "  " + siparisListesi[i].Porsiyon + " porsiyon" + "  " + siparisListesi[i].Musteri + "  " + siparisListesi[i].MasaNo + " nolu masa" + "\n";
            }
            MessageBox.Show(total);
        }

        private void siparisList_Temizle()
        {
            
            siparisListesi.Clear();
        }

        private void alınacalkarList_temizle()
        {
            alınacaklarListesi.Clear();
        }

        private void listeleriTemizle_Click(object sender, EventArgs e)
        {
            alınacaklarListesiVerTık = false;

            siparisList_Temizle();
            alınacalkarList_temizle();

            komut.CommandText = "DELETE FROM siparis";
            komut.Connection = baglanti;

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Listeler başarıyla temizlendi");
        }


        string gecici = null;
        int silinentarifno = 0;
        private void tarifNo_onay_Click(object sender, EventArgs e)
        {
            silinentarifno = Convert.ToInt32(yeniTarifNo.Value);

            switch (yeniTarifNo.Value)
                {
                    case 1:
                        komut.CommandText = "DELETE FROM TABLO1";
                        komut.Connection = baglanti;
                    gecici = textBox1.Text;
                    textBox1.Clear();
                    break;
                    case 2:
                        komut.CommandText = "DELETE FROM TABLO2";
                        komut.Connection = baglanti;
                    gecici = textBox2.Text;
                    textBox2.Clear();
                    break;
                    case 3:
                        komut.CommandText = "DELETE FROM TABLO3";
                        komut.Connection = baglanti;
                    gecici = textBox3.Text;
                    textBox3.Clear();
                    break;
                    case 4:
                        komut.CommandText = "DELETE FROM TABLO4";
                        komut.Connection = baglanti;
                    gecici = textBox4.Text;
                    textBox4.Clear();
                    break;
                    case 5:
                        komut.CommandText = "DELETE FROM TABLO5";
                        komut.Connection = baglanti;
                    gecici = textBox5.Text;
                    textBox5.Clear();
                    break;
                    case 6:
                        komut.CommandText = "DELETE FROM TABLO6";
                        komut.Connection = baglanti;
                    gecici = textBox6.Text;
                    textBox6.Clear();
                    break;
                    case 7:
                        komut.CommandText = "DELETE FROM TABLO7";
                        komut.Connection = baglanti;
                    gecici = textBox7.Text;
                    textBox7.Clear();
                    break;
                    case 8:
                        komut.CommandText = "DELETE FROM TABLO8";
                        komut.Connection = baglanti;
                    gecici = textBox8.Text;
                    textBox8.Clear();
                    break;
                }

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            yeniTarifNo.Value = 0;
  
        }


        private void yeniMalzeme_Onay_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adap = new SqlDataAdapter(komut);

            switch (silinentarifno)
            {
                case 1:
                    komut.CommandText = "INSERT INTO TABLO1(malzeme,miktar,birim) VALUES (@malzeme,@miktar,@birim)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@malzeme", yeniMalzeme.Text);
                    if (yeniMalzemeBirim1.Checked)
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(yeniMalzemeMiktar.Text));
                        komut.Parameters.AddWithValue("@birim", "adet");
                    }
                    else if (yeniMalzemeBirim2.Checked)
                    {
                        double x = (Convert.ToDouble(yeniMalzemeMiktar.Text)) * 1000;
                        int y = (int)x;
                        komut.Parameters.AddWithValue("@miktar", y);
                        komut.Parameters.AddWithValue("@birim", "kg");
                    }
                    break;

                case 2:
                    komut.CommandText = "INSERT INTO TABLO2(malzeme,miktar,birim) VALUES (@malzeme,@miktar,@birim)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@malzeme", yeniMalzeme.Text);
                    if (yeniMalzemeBirim1.Checked)
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(yeniMalzemeMiktar.Text));
                        komut.Parameters.AddWithValue("@birim", "adet");
                    }
                    else if (yeniMalzemeBirim2.Checked)
                    {
                        double x = (Convert.ToDouble(yeniMalzemeMiktar.Text)) * 1000;
                        int y = (int)x;
                        komut.Parameters.AddWithValue("@miktar", y);
                        komut.Parameters.AddWithValue("@birim", "kg");
                    }
                    break;

                case 3:
                    komut.CommandText = "INSERT INTO TABLO3(malzeme,miktar,birim) VALUES (@malzeme,@miktar,@birim)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@malzeme", yeniMalzeme.Text);
                    if (yeniMalzemeBirim1.Checked)
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(yeniMalzemeMiktar.Text));
                        komut.Parameters.AddWithValue("@birim", "adet");
                    }
                    else if (yeniMalzemeBirim2.Checked)
                    {
                        double x = (Convert.ToDouble(yeniMalzemeMiktar.Text)) * 1000;
                        int y = (int)x;
                        komut.Parameters.AddWithValue("@miktar", y);
                        komut.Parameters.AddWithValue("@birim", "kg");
                    }
                    break;

                case 4:
                    komut.CommandText = "INSERT INTO TABLO4(malzeme,miktar,birim) VALUES (@malzeme,@miktar,@birim)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@malzeme", yeniMalzeme.Text);
                    if (yeniMalzemeBirim1.Checked)
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(yeniMalzemeMiktar.Text));
                        komut.Parameters.AddWithValue("@birim", "adet");
                    }
                    else if (yeniMalzemeBirim2.Checked)
                    {
                        double x = (Convert.ToDouble(yeniMalzemeMiktar.Text)) * 1000;
                        int y = (int)x;
                        komut.Parameters.AddWithValue("@miktar", y);
                        komut.Parameters.AddWithValue("@birim", "kg");
                    }
                    break;

                case 5:
                    komut.CommandText = "INSERT INTO TABLO5(malzeme,miktar,birim) VALUES (@malzeme,@miktar,@birim)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@malzeme", yeniMalzeme.Text);
                    if (yeniMalzemeBirim1.Checked)
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(yeniMalzemeMiktar.Text));
                        komut.Parameters.AddWithValue("@birim", "adet");
                    }
                    else if (yeniMalzemeBirim2.Checked)
                    {
                        double x = (Convert.ToDouble(yeniMalzemeMiktar.Text)) * 1000;
                        int y = (int)x;
                        komut.Parameters.AddWithValue("@miktar", y);
                        komut.Parameters.AddWithValue("@birim", "kg");
                    }
                    break;

                case 6:
                    komut.CommandText = "INSERT INTO TABLO6(malzeme,miktar,birim) VALUES (@malzeme,@miktar,@birim)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@malzeme", yeniMalzeme.Text);
                    if (yeniMalzemeBirim1.Checked)
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(yeniMalzemeMiktar.Text));
                        komut.Parameters.AddWithValue("@birim", "adet");
                    }
                    else if (yeniMalzemeBirim2.Checked)
                    {
                        double x = (Convert.ToDouble(yeniMalzemeMiktar.Text)) * 1000;
                        int y = (int)x;
                        komut.Parameters.AddWithValue("@miktar", y);
                        komut.Parameters.AddWithValue("@birim", "kg");
                    }
                    break;

                case 7:
                    komut.CommandText = "INSERT INTO TABLO7(malzeme,miktar,birim) VALUES (@malzeme,@miktar,@birim)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@malzeme", yeniMalzeme.Text);
                    if (yeniMalzemeBirim1.Checked)
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(yeniMalzemeMiktar.Text));
                        komut.Parameters.AddWithValue("@birim", "adet");
                    }
                    else if (yeniMalzemeBirim2.Checked)
                    {
                        double x = (Convert.ToDouble(yeniMalzemeMiktar.Text)) * 1000;
                        int y = (int)x;
                        komut.Parameters.AddWithValue("@miktar", y);
                        komut.Parameters.AddWithValue("@birim", "kg");
                    }
                    break;

                case 8:
                    komut.CommandText = "INSERT INTO TABLO8(malzeme,miktar,birim) VALUES (@malzeme,@miktar,@birim)";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@malzeme", yeniMalzeme.Text);
                    if (yeniMalzemeBirim1.Checked)
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(yeniMalzemeMiktar.Text));
                        komut.Parameters.AddWithValue("@birim", "adet");
                    }
                    else if (yeniMalzemeBirim2.Checked)
                    {
                        double x = (Convert.ToDouble(yeniMalzemeMiktar.Text)) * 1000;
                        int y = (int)x;
                        komut.Parameters.AddWithValue("@miktar", y);
                        komut.Parameters.AddWithValue("@birim", "kg");
                    }
                    break;
            }

            baglanti.Open();
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            baglanti.Close();

            yeniMalzeme.Clear();
            yeniMalzemeMiktar.Clear();
            yeniMalzemeBirim1.Checked = false;
            yeniMalzemeBirim2.Checked = false;
        }

        
        private void siparisSil_onay_Click(object sender, EventArgs e)
        {
            siparisList_Temizle();

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            komut.CommandText = "SELECT * FROM siparis";
            komut.Connection = baglanti;
            adap.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                siparisListesi.Add(new MusteriBilgi()
                {
                    Porsiyon = (int)dt.Rows[i]["porsiyon"],
                    MasaNo = (int)dt.Rows[i]["masano"],
                    Tarif = dt.Rows[i]["tarif"].ToString(),
                    Musteri = dt.Rows[i]["musteri"].ToString(),

                });
            }

            string t = null;

            if (siparisSil_tarifNo.Value == 1)
                t = textBox1.Text;
            else if (siparisSil_tarifNo.Value == 2)
                t = textBox2.Text;
            else if (siparisSil_tarifNo.Value == 3)
                t = textBox3.Text;
            else if (siparisSil_tarifNo.Value == 4)
                t = textBox4.Text;
            else if (siparisSil_tarifNo.Value == 5)
                t = textBox5.Text;
            else if (siparisSil_tarifNo.Value == 6)
                t = textBox6.Text;
            else if (siparisSil_tarifNo.Value == 7)
                t = textBox7.Text;
            else if (siparisSil_tarifNo.Value == 8)
                t = textBox8.Text;

            for (int i = 0; i < siparisListesi.Count; i++)
            {
                    if (siparisListesi[i].MasaNo == Convert.ToInt32(siparisSil_masaNo.Text) && t == siparisListesi[i].Tarif)
                    {
                        if (siparisListesi[i].Porsiyon == siparisSil_porsiyon.Value)
                        {
                            siparisListesi.RemoveAt(i);
                        }
                        else
                        {
                            siparisListesi[i].Porsiyon -= Convert.ToInt32(siparisSil_porsiyon.Value);
                        }
                    }
            }

            SqlCommand komut2 = new SqlCommand();

            komut2.CommandText = "DELETE FROM siparis";
            komut2.Connection = baglanti;

            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();

            for (int i = 0; i < siparisListesi.Count; i++)
            {
                SqlCommand komut3 = new SqlCommand();

                komut3.CommandText = "INSERT INTO siparis(porsiyon,masano,tarif,musteri) VALUES (@porsiyon,@masano,@tarif,@musteri)";
                komut3.Connection = baglanti;
                komut3.Parameters.AddWithValue("@porsiyon", siparisListesi.ElementAt(i).Porsiyon);
                komut3.Parameters.AddWithValue("@masano", siparisListesi.ElementAt(i).MasaNo);
                komut3.Parameters.AddWithValue("@tarif", siparisListesi.ElementAt(i).Tarif);
                komut3.Parameters.AddWithValue("@musteri", siparisListesi.ElementAt(i).Musteri);

                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }

            MessageBox.Show("Sipariş başarıyla silindi");
           
            siparisSil_masaNo.Text = null;
            siparisSil_tarifNo.Value = 1;
            siparisSil_porsiyon.Value = 1;
        }

        
    }
}
