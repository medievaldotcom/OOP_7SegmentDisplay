using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7segmentOOP
{
    public partial class Form1 : Form
    {
        int hour10;
        int hour01;
        int minute10;
        int minute01;
        int seconds10;
        int seconds01;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }


    }
} 
       
