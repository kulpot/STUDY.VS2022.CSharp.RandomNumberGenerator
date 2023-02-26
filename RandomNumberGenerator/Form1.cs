using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomNumberGenerator;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();


        private void generateButton_Click(object sender, EventArgs e)
        {
            int randomNumber = r.Next(1, 1000);//1 to 1000
            numberLabel.Text = randomNumber.ToString();
        }
    }
}
