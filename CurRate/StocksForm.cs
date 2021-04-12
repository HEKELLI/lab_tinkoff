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
    public partial class StocksForm : Form
    {
        public StocksForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            get_stocks();
        }
        Form1 mainForm;
        public Tinkoff.Trading.OpenApi.Models.MarketInstrument figi_search;
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList ticker_search;
        int i = 0;

        private void but_main_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void get_stocks()
        {
            mainForm.stocks = await mainForm.context.MarketStocksAsync();
            mainForm.stocks_instruments = mainForm.stocks.Instruments[1];
            write_stocks();
        }
        public void write_stocks()
        {
            //JsonSerializer.Serialize<Tinkoff.Trading.OpenApi.Models.MarketInstrument>(mainForm.stocks_instruments);
            //textBox1.Text = JsonSerializer.Serialize<Tinkoff.Trading.OpenApi.Models.MarketInstrument>(mainForm.stocks_instruments);
            //textBox1.Text = mainForm.stocks.Instruments[1].Name;
            write_stock1(mainForm.stocks.Instruments[i]);
            i++;
            write_stock2(mainForm.stocks.Instruments[i]);
            i++;
            write_stock3(mainForm.stocks.Instruments[i]);
            i++;
            write_stock4(mainForm.stocks.Instruments[i]);
        }

        public void write_stock1(Tinkoff.Trading.OpenApi.Models.MarketInstrument stock)
        {
            label18.Text = Convert.ToString(i + 1);
            textBox1.Text = stock.Figi;
            textBox4.Text = stock.Ticker;
            textBox5.Text = stock.Isin;
            textBox6.Text = Convert.ToString(stock.MinPriceIncrement);
            textBox7.Text = Convert.ToString(stock.Lot);
            textBox9.Text = Convert.ToString(stock.Currency);
            textBox8.Text = stock.Name;
            textBox10.Text = Convert.ToString(stock.Type);
        }

        public void write_stock2(Tinkoff.Trading.OpenApi.Models.MarketInstrument stock)
        {
            label19.Text = Convert.ToString(i + 1);
            textBox11.Text = stock.Figi;
            textBox12.Text = stock.Ticker;
            textBox13.Text = stock.Isin;
            textBox14.Text = Convert.ToString(stock.MinPriceIncrement);
            textBox15.Text = Convert.ToString(stock.Lot);
            textBox16.Text = Convert.ToString(stock.Currency);
            textBox17.Text = stock.Name;
            textBox18.Text = Convert.ToString(stock.Type);
        }
        public void write_stock3(Tinkoff.Trading.OpenApi.Models.MarketInstrument stock)
        {
            label21.Text = Convert.ToString(i + 1);
            textBox26.Text = stock.Figi;
            textBox25.Text = stock.Ticker;
            textBox24.Text = stock.Isin;
            textBox23.Text = Convert.ToString(stock.MinPriceIncrement);
            textBox22.Text = Convert.ToString(stock.Lot);
            textBox20.Text = Convert.ToString(stock.Currency);
            textBox21.Text = stock.Name;
            textBox19.Text = Convert.ToString(stock.Type);
        }

        public void write_stock4(Tinkoff.Trading.OpenApi.Models.MarketInstrument stock)
        {
            label31.Text = Convert.ToString(i + 1);
            textBox34.Text = stock.Figi;
            textBox33.Text = stock.Ticker;
            textBox32.Text = stock.Isin;
            textBox31.Text = Convert.ToString(stock.MinPriceIncrement);
            textBox30.Text = Convert.ToString(stock.Lot);
            textBox28.Text = Convert.ToString(stock.Currency);
            textBox29.Text = stock.Name;
            textBox27.Text = Convert.ToString(stock.Type);
        }

        private void but_next_stocks_Click(object sender, EventArgs e)
        {
            if (i + 4 > mainForm.stocks.Instruments.Count) 
            {
                if(i + 3 > mainForm.stocks.Instruments.Count)
                {
                    if(i + 2 > mainForm.stocks.Instruments.Count)
                    {
                        if(i + 1 > mainForm.stocks.Instruments.Count)
                        {
                            
                        }
                        else
                        {
                            i++;
                            write_stock1(mainForm.stocks.Instruments[i]);
                        }
                    }
                    else
                    {
                        i++;
                        write_stock1(mainForm.stocks.Instruments[i]);
                        i++;
                        write_stock2(mainForm.stocks.Instruments[i]);
                    }
                }
                else
                {
                    i++;
                    write_stock1(mainForm.stocks.Instruments[i]);
                    i++;
                    write_stock2(mainForm.stocks.Instruments[i]);
                    i++;
                    write_stock3(mainForm.stocks.Instruments[i]);
                }
            }
            else
            {
                i++;
                write_stock1(mainForm.stocks.Instruments[i]);
                i++;
                write_stock2(mainForm.stocks.Instruments[i]);
                i++;
                write_stock3(mainForm.stocks.Instruments[i]);
                i++;
                write_stock4(mainForm.stocks.Instruments[i]);
            }
        }

        private void but_prev_stocks_Click(object sender, EventArgs e)
        {
            if (i - 3 < 0)
            {
                if (i - 2 < 0)
                {
                    if (i - 1 < 0)
                    {
                       /* if (i - 1 < 0)
                        {

                        }
                        else
                        {
                            i--;
                            write_stock1(mainForm.stocks.Instruments[i]);
                        }
                       */
                    }
                    else
                    {
                        write_stock2(mainForm.stocks.Instruments[i]);
                        i--;
                        write_stock1(mainForm.stocks.Instruments[i]);
                        i--;
                    }
                }
                else
                {
                    write_stock3(mainForm.stocks.Instruments[i]);
                    i--;
                    write_stock2(mainForm.stocks.Instruments[i]);
                    i--;
                    write_stock1(mainForm.stocks.Instruments[i]);
                    i--;
                }
            }
            else
            {
                write_stock4(mainForm.stocks.Instruments[i]);
                i--;
                write_stock3(mainForm.stocks.Instruments[i]);
                i--;
                write_stock2(mainForm.stocks.Instruments[i]);
                i--;
                write_stock1(mainForm.stocks.Instruments[i]);
                i--;
            }
        }

        private void but_figi_search_Click(object sender, EventArgs e)
        {
            searchbyFigi(textBox3.Text);
        }
        private async void searchbyFigi(string figi)
        {
            figi_search = await mainForm.context.MarketSearchByFigiAsync(figi);
            write_stock1(figi_search);
        }

        private void but_ticker_search_Click(object sender, EventArgs e)
        {
            searchbyTicker(textBox2.Text);
        }
        private async void searchbyTicker(string ticker)
        {
            ticker_search = await mainForm.context.MarketSearchByTickerAsync(ticker);
            Tinkoff.Trading.OpenApi.Models.MarketInstrument ticker_instrument_search;
            ticker_instrument_search = ticker_search.Instruments[0];
            write_stock1(ticker_instrument_search);
        }
    }
}
