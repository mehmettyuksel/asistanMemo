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
using System.Diagnostics;//Bilgisayarlardaki kütüphanelere erişmemizi sağlıyor

namespace asistanMemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); //Form açılır açılmaz zamanlayıcı çalışır
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //konustugumu rictextbox a yazıyor
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine(); //Konuştuğumuz sesi yazıya çevirme
            Grammar g = new DictationGrammar(); //İmla kurallarını için
            sr.LoadGrammar(g);// sr deki sesi alıp g de imlaya tabi tutar ve imla yapısı oluşturur
            
                
                sr.SetInputToDefaultAudioDevice(); //ses çıkışını alma
                RecognitionResult res = sr.Recognize(); // sesi tanımlayıp res e attık
                richTextBox1.Text = res.Text; // res ten gelen değerleri richtext box a text olarak yazdırma
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1 in text inde yazılana göre yapılması gerekenler if ile şartlanmıştır 
            if (richTextBox1.Text == "Note" || richTextBox1.Text == "One")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                FormNote formNote = new FormNote();
                formNote.Show();//gerekli form alanının açılmasını sağlıyor
                timer1.Stop();//zamanlayıcıyı durduruyor
                this.Hide();//mevcut formu gizliyor
                

            }
            if (richTextBox1.Text == "World" || richTextBox1.Text == "Twoo")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                Process.Start(@"C:\Program Files(x86)\Microsoft Office\root\Office16\WINWORD.EXE");// Belirtilen yoldaki program çalışacaktır
            }
            if (richTextBox1.Text == "Excel" || richTextBox1.Text == "Three")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE");// Belirtilen yoldaki program çalışacaktır
            }
            if (richTextBox1.Text == "Paint" || richTextBox1.Text == "Four" || richTextBox1.Text == "For")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                Process.Start(@"C:\Windows\system32\mspaint.exe");// Belirtilen yoldaki program çalışacaktır
            }
            if (richTextBox1.Text == "Movie" || richTextBox1.Text == "Five")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                Process.Start("https://jetfilmizle.live/");// Belirtilen yoldaki site açılacaktır
            }
            if (richTextBox1.Text == "Google" || richTextBox1.Text == "Six")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                Process.Start("https://www.google.com.tr/"); // Belirtilen yoldaki site açılacaktır
            }
            if (richTextBox1.Text == "Date" || richTextBox1.Text == "Seven")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                button_date.Text =DateTime.Now.ToString("dd.MM.yyyy");//Şimdiki zamanı alıp sitring e çeviriyor ve butonun textine bunu yazıyor
                SpVoice ses = new SpVoice();//Konuşma cinsinden yeni bir konuşma oluşturuyor
                ses.Speak(button_date.Text);//Butonun text inde yazanları sese çeviriyor 
            }
            if (richTextBox1.Text == "Stop" || richTextBox1.Text == "Eleven")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                timer1.Stop();//zamnlayıcı duruyor
                Application.Exit();//ve uygulama kapatılıyor
            }

            if (richTextBox1.Text == "Listen" || richTextBox1.Text == "Eight")//Bu şartın gerçekleşmesi durumunda olucaklar
            {
                FormListen formlisten = new FormListen();
                formlisten.Show();//gerekli form sayfası açılıyor
                timer1.Stop();//zamanlayıcı duruyor
                this.Hide();//mevcut form gizleniyor


            }

        }

        private void button_note_Click(object sender, EventArgs e)
        {
            
        }

        private void button_word_Click(object sender, EventArgs e)
        {
            
        }
    }
}
