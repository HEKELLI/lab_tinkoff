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

namespace CurRate
{
    public partial class PortfolioForm : MaterialForm
    {
        public PortfolioForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            get_portfolio();
            get_currencies();
            start_form_and_write_position();
        }
        MainForm mainForm;
        private Tinkoff.Trading.OpenApi.Models.Portfolio portfolio;
        private Tinkoff.Trading.OpenApi.Models.PortfolioCurrencies currencies;
        private int i = 0;
        
        private void get_currencies()
        {
            currencies = mainForm.engine.get_currencies();
        }
        private void get_portfolio()
        {
           portfolio = mainForm.engine.get_portfolio();
          //  mainForm.portfolio = await mainForm.context.PortfolioAsync("SB3336849");
            write_portfolio();
        }
        public void write_portfolio()
        {
            //textBox1.Text = JsonSerializer.Serialize<Tinkoff.Trading.OpenApi.Models.Portfolio>(portfolio);
        }

        private void but_show_rub_Click(object sender, EventArgs e)
        {
            get_currencies();
            materialLabel1.Text = "Баланс в рублях: " + search_currency("Rub");
        }
        private string search_currency(string cur)
        {
            for(int i=0; i<currencies.Currencies.Count;i++)
            {
                if(Convert.ToString(currencies.Currencies[i].Currency) == cur)
                {
                    return Convert.ToString(currencies.Currencies[i].Balance);
                }
            }
            return null;
        }

        private void but_show_eur_Click(object sender, EventArgs e)
        {
            get_currencies();
            materialLabel1.Text = "Баланс в евро: " + search_currency("Eur");
        }

        private void but_show_usd_Click(object sender, EventArgs e)
        {
            get_currencies();
            materialLabel1.Text = "Баланс в долларах: " + search_currency("Usd");
        }

        private void write_position(Tinkoff.Trading.OpenApi.Models.Portfolio.Position position)
        {
            materialSingleLineTextField1.Text = position.Figi;
            materialSingleLineTextField2.Text = position.Ticker;
            materialSingleLineTextField3.Text = position.Isin;
            materialSingleLineTextField4.Text = Convert.ToString(position.InstrumentType);
            materialSingleLineTextField5.Text = Convert.ToString(position.Balance);
            materialSingleLineTextField6.Text = Convert.ToString(position.Blocked);
            materialSingleLineTextField7.Text = Convert.ToString(position.Lots);
            materialSingleLineTextField8.Text = position.Name;
        }

        private void start_form_and_write_position()
        {
            if (portfolio.Positions[i] != null)
            {
                if (Convert.ToString(portfolio.Positions[i].InstrumentType) != "Currency")
                {
                    write_position(portfolio.Positions[i]);
                }
            }
        }
        private void next_pos_Click(object sender, EventArgs e)
        {
            if (i < portfolio.Positions.Count)
            {
                if (Convert.ToString(portfolio.Positions[i + 1].InstrumentType) != "Currency")
                {
                    i++;
                    write_position(portfolio.Positions[i]);
                }
            }
        }

        private void prev_pos_Click(object sender, EventArgs e)
        {
            if (portfolio.Positions[i] != null)
            {
                if (i > 0)
                {
                    i--;
                    write_position(portfolio.Positions[i]);
                }
            }
        }

        private void but_main_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
