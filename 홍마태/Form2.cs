using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp119
{
    public partial class Form2 : Form
    {
        Button btn1;
        Gong go = new Gong();
        name f1;
        Form3 f3;
        public ArrayList btnArray;
        public string tb_text, tb_text2,yymmdd1, yymmdd2;

        public Form2(name form1)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.f1 = form1;
             f3 = new Form3(this);
            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            dt1.ToShortDateString();
        }

        public void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt2 = dateTimePicker2.Value;
            dt2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {//저장
            for (int i = 1; i<12; i++)
            {
                if(f1.counter == i)
                {
                    tb_text = textBox1.Text;
                    tb_text2 = textBox2.Text;
                    btn1 = go.button2("일정" + i, tb_text, Btn2_Click);                    
                    f1.flowLayoutPanel.Controls.Add(btn1);
                }
            }
            f1.counter++;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//취소
            Close();
        }

        public void Btn2_Click(object sender, EventArgs e)
        {//생성된 버튼 불러오기
            
            f1.panel2.Controls.Clear();
            Button button = (Button)sender;
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            yymmdd1 = dt1.ToShortDateString();
            yymmdd2 = dt2.ToString();
            for (int i=1; i<12; i++)
            {
               if(button.Name == "일정" +i)
                {
                    f3 = new Form3(f1 , button);
                    f3.TopLevel = false;
                    f3.TopMost = true;
                    f3.MdiParent = f1;
                    f3.Dock = DockStyle.Fill;
                    f3.textBox1.Text = tb_text;
                    f3.textBox2.Text = tb_text2;
                    f3.dateTimePicker3.Text = yymmdd1;
                    f3.dateTimePicker4.Text = yymmdd2;
                    f3.dateTimePicker3.Enabled = false;
                    f3.dateTimePicker4.Enabled = false;
                }
            }
            
            switch (btn1.Name)
            {
                case "일정1":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정2":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정3":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정4":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정5":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정6":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정7":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정8":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정9":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정10":
                    f1.panel2.Controls.Add(f3);
                    break;
                case "일정11":
                    f1.panel2.Controls.Add(f3);
                    break;
            }
                f3.Show();
        }
    }
}
