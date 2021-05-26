using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmTTCoBan : Form
    {
        Connect cn = new Connect();
        public FrmTTCoBan()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO tbTTNVCoBan ";
                if (cn.Exitsted())
                {

                }
            }
            catch
            {

            }
        }
    }
}
