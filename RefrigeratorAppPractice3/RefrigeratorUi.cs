using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        public Weight weight;
        public double Add;
        public string Current;
        public string Remain;

        


        private void SaveButton_Click(object sender, EventArgs e)
        {
            weight = new Weight();
            weight.MaxWeight = Convert.ToInt32(maxWeightTakeTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            weight.AddItemWeight(Convert.ToInt32(itemTextBox.Text), Convert.ToDouble(weightTextBox.Text));
            currentWeightTextBox.Text = (weight.CurrentWeight(Convert.ToInt32(itemTextBox.Text), Convert.ToDouble(weightTextBox.Text))).ToString();
            remainingWeightTextBox.Text = (weight.RemainWeight(Convert.ToInt32(maxWeightTakeTextBox.Text))).ToString();

            MessageBox.Show("Done");
        }
    }
}
