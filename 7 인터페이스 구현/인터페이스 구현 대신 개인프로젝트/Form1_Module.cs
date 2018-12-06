using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Form1_Module
    {
        Form1 form1;
        gong qq = new gong();
        Panel panel1, panel2, panel3;
        Label label1;
        Button button1;

        public Form1_Module(Form1 form1)
        {
            this.form1 = form1;
        }

        public void Module()
        {
            for (int i = 0; i < 2; i++)                                                           // 패널반복실행 O
            {
                if (i == 0)
                {
                    panel1 = qq.panel1(i);
                    form1.Controls.Add(panel1);
                }
                else if (i == 1)
                {
                    panel2 = qq.panel1(i);
                    form1.Controls.Add(panel2);
                }

                // panel1.
                //패널1, 2 첫번째 버튼공간
            }

            for (int i = 0; i < 2; i++)
            {      // qq.panel3(i)가 반복 돌떄마다 생성된다 
                panel3 = qq.panel3(i); //
                form1.Controls.Add(panel3);  //패널2 가로줄
            }

            // 전역변수로 만든 패널에 (공 클래스 안에있는 패널1 메서르를)생성하여 넣는다.
            //(패널)전역변수 = 공클래스(qq) 안에 있는 메서드(panel1)();
            // --지역변수--  =└    ------- 생성한 값 ------            ┘
            //panel1 = qq.panel1(u);
            //ex)
            //값을 할당한 지역변수의 컨트롤에      공클래스 안에 버튼메서드를 넣는다.
            //panel1.Controls.Add(qq.button1(i));  //버튼1

            for (int i = 1; i < 5; i++)                                                            //패널에 라벨넣기  
            {
                //라벨 지역변수에 넣는다 
                //qq.label1(i); => 생성
                label1 = qq.label1(i);
                panel1.Controls.Add(qq.label1(i));//라벨
            }

            for (int y = 0; y < 3; y++)//                                                                  패널에 버튼2넣기 
            {
                for (int x = 0; x < 3; x++)
                {
                    button1 = qq.button1(x, y, btn_Click);
                    panel2.Controls.Add(button1); //버튼2
                }
            }


            //Controls.Add(qq.textBox());   //테스트 박스
        }


        private void btn_Click(object o, EventArgs a)
        {
            MessageBox.Show("확인");

        }

    



    }
}
