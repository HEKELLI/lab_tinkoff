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
using MaterialSkin.Controls;
using System.IO;

namespace CurRate
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            //reg = engine.connection.Context;
        }
        public Engine engine = new Engine();

        PortfolioForm portfolioForm;
        SecuritiesForm securitiesForm;
        string token;
        private void get_connection(string text_token)
        {
            token = engine.get_token();
            if(token == "Not found")
            {
                label2.Text = "Токен не найден, добавьте новый токен";
                materialRaisedButton2.Text = "Добавить токен";
                materialRaisedButton2.Visible = true;
            }
            else
            {
                engine.get_connection();
                label2.Text = "Подключён";
                but_form_portfolio.Enabled = true;
                but_stocks.Enabled = true;
                but_bonds.Enabled = true;
                but_etfs.Enabled = true;
                but_connect.Enabled = false;
            }
            
        }
        private void but_connect_Click(object sender, EventArgs e)
        {
            get_connection(text_box_token.Text);
            StreamReader sr = new StreamReader("token.txt");
            token = sr.ReadLine();
            sr.Close();
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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            text_box_token.Visible = true;
            materialRaisedButton3.Visible = true;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            engine.set_token(text_box_token.Text);
            materialRaisedButton3.Visible = false;
            text_box_token.Visible = false;
        }
    }
}
