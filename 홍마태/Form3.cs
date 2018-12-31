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

    public partial class Form3 : Form
    {
        name f1;
        Form2 f2;
        Button day_btn;

        public Form3(name f1 , Button btn)
        {
            InitializeComponent();
            Load += Form3_Load;
            this.f1 = f1;
            this.day_btn = btn;
        }
        public Form3( Form2 f2)
        {     this.f2 = f2;   }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {//삭제
            day_btn.Dispose();
            this.Close();
            f1.counter2--;
            f1.counter--;
        }

        private void button1_Click(object sender, EventArgs e)
        {//수정
            button1.Visible = false;  // 수정
            button2.Visible = false;  // 삭제
            button3.Visible = true; // 저장
            button4.Visible = true; // 취소
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {// 저장
            button1.Visible = true;  // 수정
            button2.Visible = true;  // 삭제
            button3.Visible = false; // 저장
            button4.Visible = false; // 취소
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 제목
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // 내용
        }

        private void button4_Click(object sender, EventArgs e) // 취소
        {  //취소
            button1.Visible = true;  // 수정
            button2.Visible = true;  // 삭제
            button3.Visible = false; // 저장
            button4.Visible = false; // 취소
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
        }
    }
}
