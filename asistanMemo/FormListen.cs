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


namespace asistanMemo
{
    public partial class FormListen : Form
    {
        public FormListen()
        {
            InitializeComponent();
        }

        private void button_listen_Click(object sender, EventArgs e)//butona tıklandığında olucaklar
        {
            SpVoice ses = new SpVoice();//seslendirme oluştur
            ses.Speak(richTextBox1.Text);//richTextBox1 in text inde yazanları seslendir.
        }
    }
}
