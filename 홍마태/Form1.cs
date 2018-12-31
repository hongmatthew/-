using System;
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
    public partial class name : Form
    {
        public int counter =1, counter2;
        DateTime dTP1, dTP2;
        public bool inputValue = false;
        
        public name()
        {
            InitializeComponent();
            label1.Text = monthCalendar1.SelectionRange.Start.Date.ToShortDateString();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            if (counter < 12 )
            {
                Form2 f2 = new Form2(this);
                f2.TopLevel = false;
                f2.TopMost = true;
                f2.MdiParent = this;
                f2.Dock = DockStyle.Fill;
                panel2.Controls.Add(f2);
                f2.Show();
               
                if (inputValue)
                {
                    f2.dateTimePicker1.Value = dTP1;
                    f2.dateTimePicker2.Value = dTP2;
                    inputValue = false;
                }
                else
                {
                   // MessageBox.Show("일정을 먼저 선택해주세요.");
                }
            }
            else
            {
                MessageBox.Show("현재 일정을 정리해 주세요.");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionRange.Start.Date.ToShortDateString();
            dTP1 = DateTime.Parse(monthCalendar1.SelectionRange.Start.Date.ToShortDateString());
            dTP2 = DateTime.Parse(monthCalendar1.SelectionRange.End.Date.ToShortDateString());
            inputValue = true;
        }
    }
}
