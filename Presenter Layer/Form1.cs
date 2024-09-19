using Baitap1.Business_Layer;
using Baitap1.Data_Layer;
using Baitap1.Presenter_Layer;
using Baitap1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap1
{
    public partial class Form1 : Form
    {
        private readonly Farm farm;
        public Form1()
        {
            InitializeComponent();
            farm = new Farm();
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            (int totalMilk,int totalChild) = farm.Statistic();
            MessageBox.Show($"Total milk : {totalMilk}, Total Child: {totalChild}");
        }

        private void Absentee_Click(object sender, EventArgs e)
        {

            MessageBox.Show(farm.Sound());
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            using (EnterDialog  dlg = new EnterDialog())
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    int CowAmount = dlg.CowAmount;
                    int SheepAmount = dlg.SheepAmount;
                    int GoatAmount = dlg.GoatAmount;

                    farm.EnterAnimal(new Cow(), CowAmount);
                    farm.EnterAnimal(new Sheep(), SheepAmount);
                    farm.EnterAnimal(new Goat(), GoatAmount);
                }
            }
        }
    }
}
