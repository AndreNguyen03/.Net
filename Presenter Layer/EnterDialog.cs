using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap1.Presenter_Layer
{
    public partial class EnterDialog : Form
    {
        public int CowAmount  { get; set; }
        public int SheepAmount { get; set; }
        public int GoatAmount { get; set; }
        public EnterDialog()
        {
            InitializeComponent();
        }



        private void Ok_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbCow.Text, out int cowAmount) &&
                int.TryParse(tbGoat.Text, out int goatAmount) &&
                int.TryParse(tbSheep.Text, out int sheepAmount))
            {
                CowAmount = cowAmount;
                SheepAmount = sheepAmount;
                GoatAmount = goatAmount;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid amount!");
            }
        }
    }
}
