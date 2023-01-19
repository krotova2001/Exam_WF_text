﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
