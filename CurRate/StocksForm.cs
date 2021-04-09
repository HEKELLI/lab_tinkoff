using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurRate
{
    public partial class StocksForm : Form
    {
        public StocksForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        Form1 mainForm;

        private void but_main_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
