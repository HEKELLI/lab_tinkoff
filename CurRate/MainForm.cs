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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }
        public Engine engine = new Engine();
        PortfolioForm portfolioForm;
        SecuritiesForm securitiesForm;

        private void get_connection(string text_token)
        {
            engine.get_connection(text_token);
            label2.Text = "Подключён";
        }
        private void but_connect_Click(object sender, EventArgs e)
        {
            get_connection(text_box_token.Text);

        }

        private void but_form_portfolio_Click(object sender, EventArgs e)
        { 
            portfolioForm = new PortfolioForm(this);
            portfolioForm.ShowDialog();
        }

        private void but_stocks_Click(object sender, EventArgs e)
        {
            securitiesForm = new SecuritiesForm(this, "Stocks");
            securitiesForm.ShowDialog();
        }

        private void but_bonds_Click(object sender, EventArgs e)
        {
            securitiesForm = new SecuritiesForm(this, "Bonds");
            securitiesForm.ShowDialog();
        }

        private void but_etfs_Click(object sender, EventArgs e)
        {
            securitiesForm = new SecuritiesForm(this, "Etfs");
            securitiesForm.ShowDialog();
        }
    }
}
