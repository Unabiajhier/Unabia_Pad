using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unabia_Pad
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            result = db.sp_log_in(textBox1.Text, textBox2.Text).Count();

            if (db.sp_type(textBox1.Text, textBox2.Text) == 0)
            {
                MessageBox.Show("Welcome Admin");
            }
            else
            {
                MessageBox.Show("Welcome Staff");
            }
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            Unabia_pad up = new Unabia_pad();
            this.Hide(); 
            up.Show();
        }
    }
}
