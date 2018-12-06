using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;

        }
        ////클래스, 패널을 전역변수로 만든다
        //gong qq = new gong();
        //Panel panel1, panel2, panel3;
        //Label label1;
        //Button button1;

        ////패널안에 버튼 넣는 방법
        ////1.폼에 넣는 우선순위 1. 패널

        ////공클래스에서 가져온것을 바로사용할수 없고
        ////지역변수화 해서 그 안에 할당해서 사용해야 한다.

        ////지역변수화 한 변수 -> 타입 이름;
        ////공클래스에서 가져온것 -> 값


        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Module md = new Form1_Module(this);
            md.Module();
        }

            //    //폼에 각각 등록되는 순서 - 우선순위 패널

            //    for (int i = 0; i<2; i++)                                                           // 패널반복실행 O
            //    {
            //        if (i == 0) { panel1 = qq.panel1(i); Controls.Add(panel1); }
            //        else if  (i == 1) {panel2 = qq.panel1(i); Controls.Add(panel2); }

            //            // panel1.
            //            //패널1, 2 첫번째 버튼공간
            //    }

            //    for (int i = 0; i < 2; i++)
            //    {      // qq.panel3(i)가 반복 돌떄마다 생성된다 
            //        panel3 = qq.panel3(i); //
            //        Controls.Add(panel3);  //패널2 가로줄
            //    }

            //    // 전역변수로 만든 패널에 (공 클래스 안에있는 패널1 메서르를)생성하여 넣는다.
            //    //(패널)전역변수 = 공클래스(qq) 안에 있는 메서드(panel1)();
            //    // --지역변수--  =└    ------- 생성한 값 ------            ┘
            //    //panel1 = qq.panel1(u);
            //    //ex)
            //    //값을 할당한 지역변수의 컨트롤에      공클래스 안에 버튼메서드를 넣는다.
            //    //panel1.Controls.Add(qq.button1(i));  //버튼1
                       
            //    //Controls.Add(qq.textBox());   //테스트 박스
            //}
            
            //private void btn_Click(object o, EventArgs a)
            //{
            //    MessageBox.Show("확인");

      
    }
}
