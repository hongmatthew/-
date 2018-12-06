using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class gong
    {
        Button btn1, btn2, btn3;//, btn4, btn5, btn6, btn7, btn8, btn9;
        Label lb1;//, lb2;
        Panel pn1, pn2 ,pn3;
        TextBox ttb1;


        public Label label1(int i)
        {

            lb1 = new Label();
            lb1.Text = string.Format("{0}", i);
            lb1.Location = new Point(30, 30 + (50 * i));
            lb1.AutoSize = true;
            lb1.Font = new Font("굴림체", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            lb1.Name = "label1";
            return lb1;
        }


        public Button button1(int x,int y, EventHandler e)
        {
            btn1 = new Button();
            btn1.Size = new Size(30, 30);
            btn1.Location = new Point(15 + (x * 40), 15 +(y * 40));
            btn1.Text = string.Format("{0} ", (x + y));
            btn1.Name = "button1";
            btn1.Click += e;
            btn1.UseVisualStyleBackColor = true;
            return btn1;
        }

        //public Button button3()
        //{
        //    btn3 = new Button();
        //    btn3.Size = new Size(40, 40);
        //    btn3.Location = new Point(20, 140);
        //    btn3.Name = "button3";
        //    btn1.TabIndex = 0;
        //    btn3.Text = ("3");
        //    btn3.UseVisualStyleBackColor = true;
        //    return btn3;
        //}

        //public EventArgs btn1_click(object a , EventArge s)
        //{

        //}

        public Panel panel1(int i)
        {
            pn1 = new Panel();
            pn1.Size = new Size(80 + (i * 60), 450);
            pn1.Location = new Point((i * 80), 0);
            pn1.Name = "panel";
            if (i == 0) pn1.BackColor = SystemColors.MenuHighlight;
            else if(i == 1)pn1.BackColor = Color.BlueViolet;
            return pn1;
        }



        public Panel panel3(int i)
        {
            pn3 = new Panel();
            pn3.Size = new Size(1000, 10+(i*70));
            pn3.BackColor = SystemColors.MenuHighlight;
            pn3.Location = new Point(0, 50+(i*320));
            pn3.Name = "panel3";
            return pn3;
        }

        //public Panel panel4()
        //{
        //    pn4 = new Panel();
        //    pn4.Size = new Size(170, 450);
        //    pn4.BackColor = Color.DeepSkyBlue;
        //    pn4.Location = new Point(80, 0);
        //    pn4.Name = "panel4";
        //    return pn4;
        //}





        //public TextBox textBox()
        //{
        //    ttb1 = new TextBox();
        //    ttb1.Font = new Font("굴림", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
        //    ttb1.Location = new Point(450, 226);
        //    ttb1.Name = "textBox1";
        //    ttb1.Size = new Size(100, 38);
        //    ttb1.TabIndex = 0;
        //}
    }
}
