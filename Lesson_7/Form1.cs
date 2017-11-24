using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void notBtn1_Click(object sender, EventArgs e)
		{
			for (Int32 i = 100; i<=120; i++)
			{
				lbl1.Text += i.ToString() + " ";
				
			}
		}

		private void notBtn2_Click(object sender, EventArgs e)
		{
			//works i hope
			Int32 i = 100;
			while (i <= 120)
			{
				lbl2.Text += i.ToString() + " ";
				i++;
			}
		}

		private void notBtn3_Click(object sender, EventArgs e)
		{
			AddNumbers(txt1.Text, txt2.Text);
		
		}

		private String AddNumbers(string txt1, string txt2)
		{
			Decimal a = Convert.ToDecimal(txt1);
			Decimal b = Convert.ToDecimal(txt2);
			Int32 c = Convert.ToInt32(a);
			Int32 d = Convert.ToInt32(b);
			Int32 sum = c + d;
			String final = Convert.ToString(sum);
			lbl3.Text = final;
			return final;
		}
	}
}
