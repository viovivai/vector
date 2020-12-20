using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace vector
{
    public partial class Form1 : Form
    {
        double x1, x2, y1, y2, x, y;
        double l1, l2, l;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        { try { x1 = double.Parse(textBox1.Text); } catch { textBox1.Text = "Ошибка"; } }
        private void textBox2_TextChanged(object sender, EventArgs e)
        { try { y1 = double.Parse(textBox2.Text); } catch { textBox2.Text = "Ошибка"; } }
        private void textBox3_TextChanged(object sender, EventArgs e)
        { try { x2 = double.Parse(textBox3.Text); } catch { textBox3.Text = "Ошибка"; } }
        private void textBox4_TextChanged(object sender, EventArgs e)                    
        { try { y2 = double.Parse(textBox4.Text); } catch { textBox4.Text = "Ошибка"; } }
                      
        private void button2_Click(object sender, EventArgs e)
        {   Graphics g = pictureBox1.CreateGraphics();
            g.Clear(BackColor);}

        private void button1_Click(object sender, EventArgs e)
        { Calc(); Coord();}

        public void Calc()
        {   l1 = Sqrt(Pow(x1, 2) + Pow(y1, 2)); textBox5.Text = Convert.ToString(l1);
            l2 = Sqrt(Pow(x2, 2) + Pow(y2, 2)); textBox6.Text = Convert.ToString(l2);
            if (radioButton1.Checked == true)
            { x = x1 + x2; textBox7.Text = Convert.ToString(x);
              y = y1 + y2; textBox8.Text = Convert.ToString(y);
              l = Sqrt(Pow(x, 2) + Pow(y, 2)); textBox9.Text = Convert.ToString(l);}
            if (radioButton2.Checked == true)
            { x = x1 - x2; textBox7.Text = Convert.ToString(x);
              y = y1 - y2; textBox8.Text = Convert.ToString(y);
              l = Sqrt(Pow(x, 2) + Pow(y, 2)); textBox9.Text = Convert.ToString(l);}}

        public void Coord()
        {   Graphics g = pictureBox1.CreateGraphics();
            int i, H, W;
            H = pictureBox1.Height;
            W = pictureBox1.Width;
            g.DrawLine(new Pen(Brushes.Black, 2), 0, W / 2, H, W / 2); // ОСЬ X
            g.DrawLine(new Pen(Brushes.Black, 2), H / 2, 0, H / 2, W); // ОСЬ Y      
            i = W / 2;                                                                     // СЕТКА
            while (i <= W) { g.DrawLine(new Pen(Brushes.Black, 1), 0, i, H, i); i += 15; } // -- \/            
            while (i >= 0) { g.DrawLine(new Pen(Brushes.Black, 1), 0, i, H, i); i -= 15; } // -- /\   
            i = H / 2;                                                                     //
            while (i <= H) { g.DrawLine(new Pen(Brushes.Black, 1), i, 0, i, W); i += 15; } // | >
            while (i >= 0) { g.DrawLine(new Pen(Brushes.Black, 1), i, 0, i, W); i -= 15; } // | <
            g.DrawLine(new Pen(Brushes.Red, 2), new Point(H/2,W/2), new Point(Convert.ToInt32(H/2+x1*15),Convert.ToInt32(W/2-y1*15)));//A
            g.DrawLine(new Pen(Brushes.Blue, 2), new Point(H/2,W/2), new Point(Convert.ToInt32(H/2+x2*15), Convert.ToInt32(W/2-y2*15)));//B                                                                                                                         
            if (radioButton1.Checked == true) // СЛОЖЕНИЕ
            { g.DrawLine(new Pen(Brushes.Green, 2), 
                new Point(Convert.ToInt32(H/2), Convert.ToInt32(W / 2)), 
                new Point(Convert.ToInt32(H/2+x1*15+x2*15), Convert.ToInt32(W/2-y1*15-y2*15))); }
            if (radioButton2.Checked == true) //ВЫЧИТАНИЕ
            { g.DrawLine(new Pen(Brushes.Green, 2), 
                new Point(Convert.ToInt32(H/2+x1*15), Convert.ToInt32(W/2-y1*15)),
                new Point(Convert.ToInt32(H/2+x2*15), Convert.ToInt32(W/2-y2*15))); } }

         public Form1()
         { InitializeComponent(); }
    }       
}        


       
    
        
    

