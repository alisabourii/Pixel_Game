using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixel_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        PixelGame pxml = new PixelGame();
        private void button32_Click(object sender, EventArgs e)
        {
            Button[] buttons = {button1,button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11,button12,button13,button14,button15,button16,button17,button18,button19,button20,button21,button22,button23,
            button24,button25,button26,button27,button28,button29,button30};
            pxml.FA_pxm(buttons);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Button[] buttons = {button1,button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11,button12,button13,button14,button15,button16,button17,button18,button19,button20,button21,button22,button23,
            button24,button25,button26,button27,button28,button29,button30};
            pxml.CA_pxm(buttons);
           
        }

        //int color_case = 0;
        PixelGame pxm = new PixelGame();
        private void button1_Click(object sender, EventArgs e)
        { pxm.color_change(button1); }

        private void button2_Click(object sender, EventArgs e)
        { pxm.color_change(button2); }

        private void button3_Click(object sender, EventArgs e)
        { pxm.color_change(button3); }

        private void button4_Click(object sender, EventArgs e)
        { pxm.color_change(button4); }

        private void button5_Click(object sender, EventArgs e)
        { pxm.color_change(button5); }

        private void button6_Click(object sender, EventArgs e)
        { pxm.color_change(button6); }

        private void button7_Click(object sender, EventArgs e)
        { pxm.color_change(button7); }

        private void button8_Click(object sender, EventArgs e)
        { pxm.color_change(button8); }

        private void button9_Click(object sender, EventArgs e)
        { pxm.color_change(button9); }

        private void button10_Click(object sender, EventArgs e)
        { pxm.color_change(button10); }

        private void button11_Click(object sender, EventArgs e)
        { pxm.color_change(button11); }

        private void button12_Click(object sender, EventArgs e)
        { pxm.color_change(button12); }

        private void button13_Click(object sender, EventArgs e)
        { pxm.color_change(button13); }

        private void button14_Click(object sender, EventArgs e)
        { pxm.color_change(button14); }

        private void button15_Click(object sender, EventArgs e)
        { pxm.color_change(button15); }

        private void button16_Click(object sender, EventArgs e)
        { pxm.color_change(button16); }

        private void button17_Click(object sender, EventArgs e)
        { pxm.color_change(button17); }

        private void button18_Click(object sender, EventArgs e)
        { pxm.color_change(button18); }

        private void button19_Click(object sender, EventArgs e)
        { pxm.color_change(button19); }

        private void button20_Click(object sender, EventArgs e)
        { pxm.color_change(button20); }

        private void button21_Click(object sender, EventArgs e)
        { pxm.color_change(button21); }

        private void button22_Click(object sender, EventArgs e)
        { pxm.color_change(button22); }

        private void button23_Click(object sender, EventArgs e)
        { pxm.color_change(button23); }

        private void button24_Click(object sender, EventArgs e)
        { pxm.color_change(button24); }

        private void button25_Click(object sender, EventArgs e)
        { pxm.color_change(button25); }

        private void button26_Click(object sender, EventArgs e)
        { pxm.color_change(button26); }

        private void button27_Click(object sender, EventArgs e)
        { pxm.color_change(button27); }

        private void button28_Click(object sender, EventArgs e)
        { pxm.color_change(button28); }

        private void button29_Click(object sender, EventArgs e)
        { pxm.color_change(button29); }

        private void button30_Click(object sender, EventArgs e)
        { pxm.color_change(button30); }
    }


    class PixelGame
    {
        int cc=0;
        public int CC
        {
            get { return cc; }
        }
        public void color_change(Button btn)
        {
             if (cc == 0)
             {
                 btn.BackColor = Color.Orange;
                 cc = 1;
             }
             else 
             {
                 btn.BackColor = Color.Gray;
                 cc = 0;
             }
        }

        public void CA_pxm(params Button[] btns)
        {
            for(int i=0; i<= btns.Length-1; i++)
                btns[i].BackColor = Color.Gray;
        }
        public void FA_pxm(params Button[] btns)
        {
            for (int i = 0; i <= btns.Length - 1; i++)
                btns[i].BackColor = Color.Orange;
        }
    }
}
