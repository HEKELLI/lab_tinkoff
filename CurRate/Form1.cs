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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SandboxConnection connection;
        SandboxContext context;
        Tinkoff.Trading.OpenApi.Models.Portfolio portfolio;
        //System.Threading.Tasks.Task<Tinkoff.Trading.OpenApi.Models.MarketInstrumentList> stocks;

        Tinkoff.Trading.OpenApi.Models.MarketInstrumentList stocks;
        Tinkoff.Trading.OpenApi.Models.MarketInstrument stocks_instruments;
        PortfolioForm portfolioForm;
        StocksForm stocksForm;
        BondsForm bondsForm;
        EtfsForm etfsForm;

        private void get_connection(string text_token)
        {
            connection = ConnectionFactory.GetSandboxConnection(text_token);
            context = connection.Context;
        }

        private async void get_portfolio()
        {
            portfolio = await context.PortfolioAsync("SB3336849");
            write_portfolio();
        }

        private async void get_stocks()
        {
            stocks = await context.MarketStocksAsync();
            stocks_instruments = stocks.Instruments[1];
            write_stocks();
        }
        public void write_stocks()
        {
            label2.Text = JsonSerializer.Serialize<Tinkoff.Trading.OpenApi.Models.MarketInstrument>(stocks_instruments);
            label2.Text = stocks.Instruments[1].Name;
        }
        public void write_portfolio()
        {
            label1.Text = JsonSerializer.Serialize<Tinkoff.Trading.OpenApi.Models.Portfolio>(portfolio);
        }

        private void but_connect_Click(object sender, EventArgs e)
        {
            get_connection(text_box_token.Text);
            get_portfolio();
            get_stocks();

        }

        private void but_form_portfolio_Click(object sender, EventArgs e)
        { 
            portfolioForm = new PortfolioForm(this);
            portfolioForm.ShowDialog();
        }

        private void but_stocks_Click(object sender, EventArgs e)
        {
            stocksForm = new StocksForm(this);
            stocksForm.ShowDialog();
        }

        private void but_bonds_Click(object sender, EventArgs e)
        {
            bondsForm = new BondsForm(this);
            bondsForm.ShowDialog();
        }

        private void but_etfs_Click(object sender, EventArgs e)
        {
            etfsForm = new EtfsForm(this);
            etfsForm.ShowDialog();
        }
    }
}
