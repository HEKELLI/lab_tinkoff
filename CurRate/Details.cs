using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tinkoff.Trading.OpenApi.Network;
using MaterialSkin.Controls;

namespace CurRate
{
    public partial class Details : MaterialForm
    {
        public Details(MainForm mainForm, Tinkoff.Trading.OpenApi.Models.MarketInstrument security)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.security = security;
            thisForm = this;
            thisForm.Text = security.Name;
            write_securities();
        }
        MainForm mainForm;
        Details thisForm;
        Tinkoff.Trading.OpenApi.Models.MarketInstrument security;

        private void write_securities()
        {
            materialSingleLineTextField1.Text = security.Figi;
            materialSingleLineTextField2.Text = security.Ticker;
            materialSingleLineTextField3.Text = security.Isin;
            materialSingleLineTextField4.Text = Convert.ToString(security.MinPriceIncrement);
            materialSingleLineTextField5.Text = Convert.ToString(security.Lot);
            materialSingleLineTextField6.Text = Convert.ToString(security.Currency);
            materialSingleLineTextField7.Text = security.Name;
            materialSingleLineTextField8.Text = Convert.ToString(security.Type);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Tinkoff.Trading.OpenApi.Models.MarketOrder order = new Tinkoff.Trading.OpenApi.Models.MarketOrder(materialSingleLineTextField1.Text, Convert.ToInt32(materialSingleLineTextField9.Text), Tinkoff.Trading.OpenApi.Models.OperationType.Buy);
            market_buy(order);
        }
        private async void market_buy(Tinkoff.Trading.OpenApi.Models.MarketOrder order)
        {
            Tinkoff.Trading.OpenApi.Models.PlacedMarketOrder request;
            try
            {
                request = await mainForm.engine.context.PlaceMarketOrderAsync(order);
                mainForm.engine.get_porfolio_async();
                materialLabel9.Text = "Транзакция прошла успешно";
                materialLabel9.BackColor = Color.LightGreen;
                materialLabel9.Visible = true;
            }
            catch
            {
                materialLabel9.Visible = true;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
