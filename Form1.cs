using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Speech.Synthesis;

namespace Exam_WF
{
    public partial class Form1 : Form
    {
        List<Favorite> favoriteList = new List<Favorite>(); // список избранного
        public Form1()
        {
            InitializeComponent();
        }

        //функция сохранения избранного в файл
        private void Save_favorites()
        {
            using (FileStream fs = new FileStream("bookmarks.json", FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize<List<Favorite>>(fs, favoriteList);
            }
        }

        private void Load_favorites()
        {
            try
            {
                string buffer = File.ReadAllText("bookmarks.json");
                //favoriteList = JsonSerializer.Deserialize<List<Favorite>>(buffer);
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);
            }
            
        }
            

#region переключение тем
        //светая тема
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
            this.ForeColor = SystemColors.WindowText;
            richTextBox1.ForeColor = SystemColors.WindowText;
            richTextBox1.BackColor = SystemColors.Window;
        }

        //темная тема
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
        }

        //серая тема
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            this.ForeColor = Color.White;
            richTextBox1.BackColor = Color.Gray;
            richTextBox1.ForeColor = Color.White;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //кнопка "Озвучить"
        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SpeakAsync(richTextBox1.Text);
        }
    }
}
