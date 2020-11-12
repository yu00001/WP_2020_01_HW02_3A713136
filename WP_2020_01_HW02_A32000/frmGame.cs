using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_A32000.Properties;

namespace WP_2020_01_HW02_A32000
{
    public partial class frmGame : Form
    {
        List<Image> list = new List<Image>();

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            list.Add(Resources._01);
            list.Add(Resources._02);
            list.Add(Resources._03);
            list.Add(Resources._04);
            list.Add(Resources._05);
            list.Add(Resources._06);
            list.Add(Resources._07);
            list.Add(Resources._08);
            list.Add(Resources._09);
            list.Add(Resources._10);
            list.Add(Resources._11);
            list.Add(Resources._12);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Poker p = new Poker();
            List<int> poker = p.GetPoker(12);

            string msg = "";
            for (int i = 0; i < 1; i++)
            {
                msg += $"{poker[i] +1 } ";

            }
            rtbLog.Text += msg + "\n";
            picResult.Image = list[poker[0]];
            //int index = 3;//模擬隨機產生 一個值;
            //picResult.Image = list[index];
        }    
    }
}
