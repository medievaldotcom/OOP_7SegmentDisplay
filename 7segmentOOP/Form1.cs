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
            mainFunction();

        }
        private void mainFunction()
        {
            String myTimeStr = DateTime.Now.ToLongTimeString();
            String myDateStr = DateTime.Now.ToLongDateString();


            String sthrs = "";
            String stmn = "";
            String stss = "";

            String myTimeStrCopy = myTimeStr;
            String sttmp = "";

            sthrs = myTimeStrCopy.Substring(0, myTimeStrCopy.IndexOf(':'));
            sttmp = myTimeStrCopy.Remove(0, myTimeStrCopy.IndexOf(':') + 1);

            stmn = sttmp.Substring(0, sttmp.IndexOf(':'));
            sttmp = sttmp.Remove(0, sttmp.IndexOf(':') + 1);

            stss = sttmp.Substring(0, sttmp.IndexOf(' '));
            sttmp = sttmp.Remove(0, sttmp.IndexOf(' ') + 1);


            if (sthrs.Length == 1)
            {
                hour10 = 0;
                hour01 = int.Parse(sthrs);
            }
            else if (sthrs.Length == 2)
            {
                hour10 = int.Parse(sthrs[0].ToString());
                hour01 = int.Parse(sthrs[1].ToString());
            }


            if (stss.Length == 1)
            {
                seconds10 = 0;
                seconds01 = int.Parse(stss);
            }
            else if (stss.Length == 2)
            {
                seconds10 = int.Parse(stss[0].ToString());
                seconds01 = int.Parse(stss[1].ToString());
            }

            if (stmn.Length == 1)
            {
                minute10 = 0;
                minute01 = int.Parse(stmn);
            }
            else if (stmn.Length == 2)
            {
                minute10 = int.Parse(stmn[0].ToString());
                minute01 = int.Parse(stmn[1].ToString());
            }



            sevensegemnts(hour10, ref hh1, ref hh2, ref hh3, ref hh4, ref hh5, ref hh6, ref hh7);
            sevensegemnts(hour01, ref h1, ref h2, ref h3, ref h4, ref h5, ref h6, ref h7);
            sevensegemnts(minute10, ref mm1, ref mm2, ref mm3, ref mm4, ref mm5, ref mm6, ref mm7);
            sevensegemnts(minute01, ref m1, ref m2, ref m3, ref m4, ref m5, ref m6, ref m7);
            sevensegemnts(seconds10, ref ss1, ref ss2, ref ss3, ref ss4, ref ss5, ref ss6, ref ss7);
            sevensegemnts(seconds01, ref s1, ref s2, ref s3, ref s4, ref s5, ref s6, ref s7);
        }
        private void segmentonoroff(ref Button btnLED, bool isLED_On)
        {
            if (isLED_On)
            {
                btnLED.BackColor = Color.Red;
                btnLED.Visible = true;
            }
            else
            {
                btnLED.BackColor = Color.Black;
                btnLED.Visible = false;
            }
        }
        private bool sevensegemnts(int numDigit, ref Button seg1, ref Button seg2, ref Button seg3, ref Button seg4, ref Button seg5, ref Button seg6, ref Button seg7)
        {
            this.BackColor = Color.Black;



            if (numDigit == 0)
            {
                segmentonoroff(ref seg1, true);
                segmentonoroff(ref seg2, true);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, true);
                segmentonoroff(ref seg5, true);
                segmentonoroff(ref seg6, true);
                segmentonoroff(ref seg7, false);

                return true;

            }

            else if (numDigit == 1)
            {
                segmentonoroff(ref seg1, false);
                segmentonoroff(ref seg2, true);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, false);
                segmentonoroff(ref seg5, false);
                segmentonoroff(ref seg6, false);
                segmentonoroff(ref seg7, false);

                return true;
            }


            else if (numDigit == 2)
            {
                segmentonoroff(ref seg1, true);
                segmentonoroff(ref seg2, true);
                segmentonoroff(ref seg3, false);
                segmentonoroff(ref seg4, true);
                segmentonoroff(ref seg5, true);
                segmentonoroff(ref seg6, false);
                segmentonoroff(ref seg7, true);

                return true;
            }


            else if (numDigit == 3)
            {
                segmentonoroff(ref seg1, true);
                segmentonoroff(ref seg2, true);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, true);
                segmentonoroff(ref seg5, false);
                segmentonoroff(ref seg6, false);
                segmentonoroff(ref seg7, true);

                return true;
            }


            else if (numDigit == 4)
            {
                segmentonoroff(ref seg1, false);
                segmentonoroff(ref seg2, true);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, false);
                segmentonoroff(ref seg5, false);
                segmentonoroff(ref seg6, true);
                segmentonoroff(ref seg7, true);

                return true;
            }


            else if (numDigit == 5)
            {
                segmentonoroff(ref seg1, true);
                segmentonoroff(ref seg2, false);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, true);
                segmentonoroff(ref seg5, false);
                segmentonoroff(ref seg6, true);
                segmentonoroff(ref seg7, true);

                return true;
            }

            else if (numDigit == 6)
            {
                segmentonoroff(ref seg1, true);
                segmentonoroff(ref seg2, false);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, true);
                segmentonoroff(ref seg5, true);
                segmentonoroff(ref seg6, true);
                segmentonoroff(ref seg7, true);

                return true;
            }

            else if (numDigit == 7)
            {
                segmentonoroff(ref seg1, true);
                segmentonoroff(ref seg2, true);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, false);
                segmentonoroff(ref seg5, false);
                segmentonoroff(ref seg6, false);
                segmentonoroff(ref seg7, false);

                return true;
            }


            else if (numDigit == 8)
            {
                segmentonoroff(ref seg1, true);
                segmentonoroff(ref seg2, true);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, true);
                segmentonoroff(ref seg5, true);
                segmentonoroff(ref seg6, true);
                segmentonoroff(ref seg7, true);

                return true;
            }


            else if (numDigit == 9)
            {
                segmentonoroff(ref seg1, true);
                segmentonoroff(ref seg2, true);
                segmentonoroff(ref seg3, true);
                segmentonoroff(ref seg4, true);
                segmentonoroff(ref seg5, false);
                segmentonoroff(ref seg6, true);
                segmentonoroff(ref seg7, true);

                return true;
            }
            else
            {

                segmentonoroff(ref seg1, false);
                segmentonoroff(ref seg2, false);
                segmentonoroff(ref seg3, false);
                segmentonoroff(ref seg4, false);
                segmentonoroff(ref seg5, false);
                segmentonoroff(ref seg6, false);
                segmentonoroff(ref seg7, false);

                return false;
            }
        }
    }

}
       
