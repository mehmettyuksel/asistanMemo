using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib; // Speech kütüphanesini çağırma //Konuşturmak için kullandık 
using System.Speech.Recognition; //Konuştuğumuzu anlamasını sağlamak için
using System.Data.SqlClient; // veritabanı bağlantı kodu

namespace asistanMemo
{
    public partial class FormNote : Form
    {
        public FormNote()
        {
            InitializeComponent();
        }
        asistanEntities db = new asistanEntities();//veri tabanı ile bağlantı kodu
        public void ProductList()//listeleme fonksiyonu
        {
            var products = db.Tbl_Not.ToList(); //veritababnındaki notları listeleme
            dataGridView1.DataSource = products;//ve bunu datagridviev e yansıtıyor
        }

        void enabled()//nesnelere erişimin kısıtlandığı fonksiyon
        {
            textBox1.Enabled = false;
            maskedTextBox1.Enabled = false;
            richTextBox1.Enabled = false;

        }
        void colormethod()//nesnelerin renklendirme işleminin yapıldığı fanksiyon
        {
            textBox1.BackColor = Color.White;
            maskedTextBox1.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
        }

        private void FormNote_Load(object sender, EventArgs e)// form a ilk giriş yapıldığında olacaklar
        {
            enabled();//nesneler kapalı durumdadıre
            colormethod();//ve renkleri beyazdır
            timer1.Start(); //For açılır açılmaz zamanlayıcı çalışır
        }
        
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            //konustugumu rictextbox a yazıyor
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine(); //Konuştuğumuz sesi yazıya çevirme
            Grammar g = new DictationGrammar(); //İmla kurallarını için
            sr.LoadGrammar(g);// sr deki sesi alıp g de imlaya tabi tutar ve imla yapısı oluşturur


            sr.SetInputToDefaultAudioDevice(); //ses çıkışını alma
            RecognitionResult res = sr.Recognize(); // sesi tanımlayıp res e attık
            richTextBox2.Text = res.Text; // res ten gelen değerleri richtext box a text olarak yazdırma
        }
       

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            //------eğer nesnenin rengi şartta belirtilen renkte ise ve erişim açıksa--------
            if (textBox1.BackColor == Color.PowderBlue && textBox1.Enabled == true)
            {
                textBox1.Text = richTextBox2.Text;//richtextbox2 deki yazıyı textbox1 in text ine yaz
                enabled();//sonra nesneye erişimi kapat
                colormethod();// sonra rengini tekrar fonksiyonda belirtilen beyaz renge çevir
            }
            if (maskedTextBox1.BackColor == Color.PowderBlue && maskedTextBox1.Enabled == true)
            {

                enabled();
                colormethod();
            }
            if (richTextBox1.BackColor == Color.PowderBlue && richTextBox1.Enabled == true)
            {
                richTextBox1.Text = richTextBox2.Text;
                enabled();
                colormethod();
            }
            //-----------------------------------------------------------------------------------
            if (richTextBox2.Text == "List note" || richTextBox2.Text == "And")
            {
                ProductList();
            }
            if (richTextBox2.Text == "Add" || richTextBox2.Text == "Save" || richTextBox2.Text == "Add to" || richTextBox2.Text == "Forty")
            {
                Tbl_Not t = new Tbl_Not();
                t.Not_Baslik = textBox1.Text;
                t.Not_Tarih = DateTime.Parse(maskedTextBox1.Text);
                t.Not_Yazi = richTextBox1.Text;
                db.Tbl_Not.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kaydedildi");
            }
           
            //--------------geçekleşen şartda olacaklar------------
            if (richTextBox2.Text == "One" || richTextBox2.Text == "Hood")
            {
                textBox1.Focus();//imleci textbox aodakla
                textBox1.BackColor = Color.PowderBlue;//arkaplan rengi değiştir
                textBox1.Enabled = true;//erişimi aktif et
            }
            if (richTextBox2.Text == "For" || richTextBox2.Text == "Date")
            {
                maskedTextBox1.Focus();
                maskedTextBox1.BackColor = Color.PowderBlue;
                maskedTextBox1.Text = DateTime.Now.ToString("dd.MM.yyyy");//o anki tarihi al ve nesnenin text ine yaz
                maskedTextBox1.Enabled = true;
            }
            if (richTextBox2.Text == "Five" || richTextBox2.Text == "Note")
            {
                richTextBox1.Focus();
                richTextBox1.BackColor = Color.PowderBlue;
                richTextBox1.Enabled = true;
            }
            //--------------------------------------------------------------------------------------
            if (richTextBox2.Text == "The" || richTextBox2.Text == "Eleven")
            {
                timer1.Stop();//zamanlayıcıyı durdur
                Form1 Form1 = new Form1();
                Form1.Show();//ana forma geri dön
                this.Hide();//formu gizle
            }
            //-----------------------------------------------------------------------------------------

        }
    }
}
