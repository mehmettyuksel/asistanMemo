
namespace asistanMemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_note = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_word = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_paint = new System.Windows.Forms.Button();
            this.button_movie = new System.Windows.Forms.Button();
            this.button_google = new System.Windows.Forms.Button();
            this.button_date = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_note
            // 
            this.button_note.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_note.ImageKey = "Notepad_plus_plus.png";
            this.button_note.ImageList = this.imageList1;
            this.button_note.Location = new System.Drawing.Point(11, 22);
            this.button_note.Name = "button_note";
            this.button_note.Size = new System.Drawing.Size(106, 89);
            this.button_note.TabIndex = 0;
            this.button_note.Text = "Note(1)";
            this.button_note.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_note.UseVisualStyleBackColor = true;
            this.button_note.Click += new System.EventHandler(this.button_note_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Microsoft-Word-Logo.png");
            this.imageList1.Images.SetKeyName(1, "Notepad_plus_plus.png");
            this.imageList1.Images.SetKeyName(2, "paint.png");
            this.imageList1.Images.SetKeyName(3, "tarih.png");
            this.imageList1.Images.SetKeyName(4, "YouTube.png");
            this.imageList1.Images.SetKeyName(5, "Excel.png");
            this.imageList1.Images.SetKeyName(6, "movie.png");
            this.imageList1.Images.SetKeyName(7, "tarih.png");
            this.imageList1.Images.SetKeyName(8, "googlelogo.png");
            this.imageList1.Images.SetKeyName(9, "ses.png");
            // 
            // button_word
            // 
            this.button_word.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_word.ImageKey = "Microsoft-Word-Logo.png";
            this.button_word.ImageList = this.imageList1;
            this.button_word.Location = new System.Drawing.Point(149, 22);
            this.button_word.Name = "button_word";
            this.button_word.Size = new System.Drawing.Size(106, 89);
            this.button_word.TabIndex = 1;
            this.button_word.Text = "Word(2)";
            this.button_word.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_word.UseVisualStyleBackColor = true;
            this.button_word.Click += new System.EventHandler(this.button_word_Click);
            // 
            // button_excel
            // 
            this.button_excel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_excel.ImageKey = "Excel.png";
            this.button_excel.ImageList = this.imageList1;
            this.button_excel.Location = new System.Drawing.Point(286, 22);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(106, 89);
            this.button_excel.TabIndex = 2;
            this.button_excel.Text = "Excel(3)";
            this.button_excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_excel.UseVisualStyleBackColor = true;
            // 
            // button_paint
            // 
            this.button_paint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_paint.ImageKey = "paint.png";
            this.button_paint.ImageList = this.imageList1;
            this.button_paint.Location = new System.Drawing.Point(11, 132);
            this.button_paint.Name = "button_paint";
            this.button_paint.Size = new System.Drawing.Size(106, 89);
            this.button_paint.TabIndex = 3;
            this.button_paint.Text = "Paint(4)";
            this.button_paint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_paint.UseVisualStyleBackColor = true;
            // 
            // button_movie
            // 
            this.button_movie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_movie.ImageKey = "movie.png";
            this.button_movie.ImageList = this.imageList1;
            this.button_movie.Location = new System.Drawing.Point(149, 132);
            this.button_movie.Name = "button_movie";
            this.button_movie.Size = new System.Drawing.Size(105, 89);
            this.button_movie.TabIndex = 4;
            this.button_movie.Text = "Movie(5)";
            this.button_movie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_movie.UseVisualStyleBackColor = true;
            // 
            // button_google
            // 
            this.button_google.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_google.ImageKey = "googlelogo.png";
            this.button_google.ImageList = this.imageList1;
            this.button_google.Location = new System.Drawing.Point(286, 132);
            this.button_google.Name = "button_google";
            this.button_google.Size = new System.Drawing.Size(105, 89);
            this.button_google.TabIndex = 5;
            this.button_google.Text = "Google(6)";
            this.button_google.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_google.UseVisualStyleBackColor = true;
            // 
            // button_date
            // 
            this.button_date.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_date.ImageKey = "tarih.png";
            this.button_date.ImageList = this.imageList1;
            this.button_date.Location = new System.Drawing.Point(12, 237);
            this.button_date.Name = "button_date";
            this.button_date.Size = new System.Drawing.Size(105, 89);
            this.button_date.TabIndex = 6;
            this.button_date.Text = "Date(7)";
            this.button_date.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_date.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Location = new System.Drawing.Point(432, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(137, 352);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "ses.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(149, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 89);
            this.button1.TabIndex = 8;
            this.button1.Text = "Listen(8)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_date);
            this.Controls.Add(this.button_google);
            this.Controls.Add(this.button_movie);
            this.Controls.Add(this.button_paint);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_word);
            this.Controls.Add(this.button_note);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_note;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_word;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.Button button_paint;
        private System.Windows.Forms.Button button_movie;
        private System.Windows.Forms.Button button_google;
        private System.Windows.Forms.Button button_date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

