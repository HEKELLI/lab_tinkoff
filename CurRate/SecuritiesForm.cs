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
    public partial class SecuritiesForm : MaterialForm
    {
        public SecuritiesForm(MainForm mainForm, string SecuritiesType)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            get_stocks_by_type(SecuritiesType);
        }
        MainForm mainForm;
        Details detailsForm;
        public Tinkoff.Trading.OpenApi.Models.MarketInstrument figi_search;
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList ticker_search;
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList Securities;
        int i1 = 0;
        int i2 = 1;
        int i3 = 2;
        int i4 = 3;

        private void but_main_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void get_stocks_by_type(string SecType)
        {
            if(SecType=="Stocks")
            {
                Securities = mainForm.engine.get_stocks();
            }
            else
            {
                if(SecType=="Bonds")
                {
                    Securities = mainForm.engine.get_bonds();
                }
                else
                {
                    if(SecType=="Etfs")
                    {
                        Securities = mainForm.engine.get_etfs();
                    }
                }
            }
            write_stocks();
        }
        public void write_stocks()
        {
            write_stock1(Securities.Instruments[i1]);
            write_stock2(Securities.Instruments[i2]);
            write_stock3(Securities.Instruments[i3]);
            write_stock4(Securities.Instruments[i4]);
        }

        public void write_stock1(Tinkoff.Trading.OpenApi.Models.MarketInstrument security)
        {
            label18.Text = Convert.ToString(i1 + 1);
            textBox1.Text = security.Figi;
            textBox4.Text = security.Ticker;
            textBox5.Text = security.Isin;
            textBox6.Text = Convert.ToString(security.MinPriceIncrement);
            textBox7.Text = Convert.ToString(security.Lot);
            textBox9.Text = Convert.ToString(security.Currency);
            textBox8.Text = security.Name;
            textBox10.Text = Convert.ToString(security.Type);
        }

        public void write_stock2(Tinkoff.Trading.OpenApi.Models.MarketInstrument security)
        {
            label19.Text = Convert.ToString(i2 + 1);
            textBox11.Text = security.Figi;
            textBox12.Text = security.Ticker;
            textBox13.Text = security.Isin;
            textBox14.Text = Convert.ToString(security.MinPriceIncrement);
            textBox15.Text = Convert.ToString(security.Lot);
            textBox16.Text = Convert.ToString(security.Currency);
            textBox17.Text = security.Name;
            textBox18.Text = Convert.ToString(security.Type);
        }
        public void write_stock3(Tinkoff.Trading.OpenApi.Models.MarketInstrument security)
        {
            label21.Text = Convert.ToString(i3 + 1);
            textBox26.Text = security.Figi;
            textBox25.Text = security.Ticker;
            textBox24.Text = security.Isin;
            textBox23.Text = Convert.ToString(security.MinPriceIncrement);
            textBox22.Text = Convert.ToString(security.Lot);
            textBox20.Text = Convert.ToString(security.Currency);
            textBox21.Text = security.Name;
            textBox19.Text = Convert.ToString(security.Type);
        }

        public void write_stock4(Tinkoff.Trading.OpenApi.Models.MarketInstrument security)
        {
            label31.Text = Convert.ToString(i4 + 1);
            textBox34.Text = security.Figi;
            textBox33.Text = security.Ticker;
            textBox32.Text = security.Isin;
            textBox31.Text = Convert.ToString(security.MinPriceIncrement);
            textBox30.Text = Convert.ToString(security.Lot);
            textBox28.Text = Convert.ToString(security.Currency);
            textBox29.Text = security.Name;
            textBox27.Text = Convert.ToString(security.Type);
        }

        private void but_next_stocks_Click(object sender, EventArgs e)
        {
            if (i4 + 4 > Securities.Instruments.Count) 
            {
                if(i4 + 3 > Securities.Instruments.Count)
                {
                    if(i4 + 2 > Securities.Instruments.Count)
                    {
                        if(i4 + 1 > Securities.Instruments.Count)
                        {
                            
                        }
                        else
                        {
                            i1 += 1;
                            write_stock1(Securities.Instruments[i1]);
                            i2 += 1;
                            write_stock2(Securities.Instruments[i2]);
                            i3 += 1;
                            write_stock3(Securities.Instruments[i3]);
                            i4 += 1;
                            write_stock4(Securities.Instruments[i4]);
                        }
                    }
                    else
                    {
                        i1 += 2;
                        write_stock1(Securities.Instruments[i1]);
                        i2 += 2;
                        write_stock2(Securities.Instruments[i2]);
                        i3 += 2;
                        write_stock3(Securities.Instruments[i3]);
                        i4 += 2;
                        write_stock4(Securities.Instruments[i4]);
                    }
                }
                else
                {
                    i1 += 3;
                    write_stock1(Securities.Instruments[i1]);
                    i2 += 3;
                    write_stock2(Securities.Instruments[i2]);
                    i3 += 3;
                    write_stock3(Securities.Instruments[i3]);
                    i4 += 3;
                    write_stock4(Securities.Instruments[i4]);
                }
            }
            else
            {
                i1 += 4;
                write_stock1(Securities.Instruments[i1]);
                i2 += 4;
                write_stock2(Securities.Instruments[i2]);
                i3 += 4;
                write_stock3(Securities.Instruments[i3]);
                i4 += 4;
                write_stock4(Securities.Instruments[i4]);
            }
        }

        private void but_prev_stocks_Click(object sender, EventArgs e)
        {
            if (i1 - 4 < 0)
            {
                if (i1 - 3 < 0)
                {
                    if (i1 - 2 < 0)
                    {
                        if (i1 - 1 < 0)
                        {

                        }
                        else
                        {
                            i1 -= 1;
                            write_stock1(Securities.Instruments[i1]);
                            i2 -= 1;
                            write_stock2(Securities.Instruments[i2]);
                            i3 -= 1;
                            write_stock3(Securities.Instruments[i3]);
                            i4 -= 1;
                            write_stock4(Securities.Instruments[i4]);
                        }
                    }
                    else
                    {
                        i1 -= 2;
                        write_stock1(Securities.Instruments[i1]);
                        i2 -= 2;
                        write_stock2(Securities.Instruments[i2]);
                        i3 -= 2;
                        write_stock3(Securities.Instruments[i3]);
                        i4 -= 2;
                        write_stock4(Securities.Instruments[i4]);
                    }
                }
                else
                {
                    i1 -= 3;
                    write_stock1(Securities.Instruments[i1]);
                    i2 -= 3;
                    write_stock2(Securities.Instruments[i2]);
                    i3 -= 3;
                    write_stock3(Securities.Instruments[i3]);
                    i4 -= 3;
                    write_stock4(Securities.Instruments[i4]);
                }
            }
            else
            {
                i1 -= 4;
                write_stock1(Securities.Instruments[i1]);
                i2 -= 4;
                write_stock2(Securities.Instruments[i2]);
                i3 -= 4;
                write_stock3(Securities.Instruments[i3]);
                i4 -= 4;
                write_stock4(Securities.Instruments[i4]);
            }
        }

        private void but_figi_search_Click(object sender, EventArgs e)
        {
            searchbyFigi(textBox3.Text);
        }
        private async void searchbyFigi(string figi)
        {
            figi_search = await mainForm.engine.context.MarketSearchByFigiAsync(figi);
            detailsForm = new Details(mainForm, figi_search);
            detailsForm.ShowDialog();
        }

        private void but_ticker_search_Click(object sender, EventArgs e)
        {
            searchbyTicker(textBox2.Text);
        }
        private async void searchbyTicker(string ticker)
        {
            ticker_search = await mainForm.engine.context.MarketSearchByTickerAsync(ticker);
            Tinkoff.Trading.OpenApi.Models.MarketInstrument ticker_instrument_search;
            ticker_instrument_search = ticker_search.Instruments[0];
            detailsForm = new Details(mainForm, ticker_instrument_search);
            detailsForm.ShowDialog();
        }

        private void detail_but1_Click(object sender, EventArgs e)
        {
            detailsForm = new Details(mainForm, Securities.Instruments[i1]);
            detailsForm.ShowDialog();
        }

        private void detail_but2_Click(object sender, EventArgs e)
        {
            detailsForm = new Details(mainForm, Securities.Instruments[i2]);
            detailsForm.ShowDialog();
        }

        private void detail_but3_Click(object sender, EventArgs e)
        {
            detailsForm = new Details(mainForm, Securities.Instruments[i3]);
            detailsForm.ShowDialog();
        }

        private void detail_but4_Click(object sender, EventArgs e)
        {
            detailsForm = new Details(mainForm, Securities.Instruments[i4]);
            detailsForm.ShowDialog();
        }
    }
}
