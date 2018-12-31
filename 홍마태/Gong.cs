using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp119
{
    class Gong 
    {
        public Button btn1, btn2;
        public Panel pn1, panel2;
        DateTime dTP1, dTP2;
        
        public bool inputValue = false;

        name f1;
        Form2 f2;
        Form3 f3;
        public Gong( )
        {
         
            
        }
        public Gong(name form1)
        {   f1 = form1; }
        public Gong(Form2 form2)
        { f2 = form2; }
        public Gong(Form3 form3)
        {   f3 = form3; }



        //public Button button1(Form1 form, string name, string txt, int i, EventHandler eh)
        //{
        //    btn1 = new Button();
        //    f1 = form;
        //    btn1.Location = new System.Drawing.Point(0, (i * 35) + 200);
        //    btn1.Name = name;
        //    btn1.Size = new System.Drawing.Size(220, 25);
        //    btn1.TabIndex = 0;
        //    btn1.Text = string.Format("{0} ", "일정");
        //    btn1.Text = txt;
        //    btn1.Click += Btn1_Click;
        //    btn1.UseVisualStyleBackColor = true;

        //    return btn1;
        //}

        public Button button2(string Name, string tb_text, EventHandler Btn2_Click)
        {
            btn2 = new Button();
            btn2.Location = new System.Drawing.Point(3, 5);
            btn2.Name = Name;
            btn2.Size = new System.Drawing.Size(215, 28);
            btn2.TabIndex = 0;
            btn2.Text = tb_text;//"일정" + Text.ToString();
           // btn2.FlatStyle = FlatStyle.Popup;
            btn2.Click += new EventHandler(Btn2_Click);
            btn2.UseVisualStyleBackColor = false;
            btn2.FlatStyle = FlatStyle.Flat;
            
            return btn2;
        }

        


        //public void Btn1_Click(object sender, EventArgs e)
        //{
        //    Form activeChild = new ActiveMdiChild();
        //    불러올 폼에 대한 설정과 자식 부모폼 지정, 실행


        //}


    }
}
