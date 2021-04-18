using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Tinkoff.Trading.OpenApi.Network;

namespace CurRate
{
    public partial class PortfolioForm : Form
    {
        public PortfolioForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            get_portfolio();
        }
        MainForm mainForm;
        private void but_main_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void get_portfolio()
        {
          //  mainForm.portfolio = await mainForm.context.PortfolioAsync("SB3336849");
            write_portfolio();
        }
        public void write_portfolio()
        {
           // textBox1.Text = JsonSerializer.Serialize<Tinkoff.Trading.OpenApi.Models.Portfolio>(mainForm.portfolio);
        }
    }
}
