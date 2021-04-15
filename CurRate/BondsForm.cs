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
    public partial class BondsForm : Form
    {
        public BondsForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            get_bonds();
        }
        private Tinkoff.Trading.OpenApi.Models.MarketInstrumentList bonds;
        private Tinkoff.Trading.OpenApi.Models.MarketInstrument figi_search;
        private Tinkoff.Trading.OpenApi.Models.MarketInstrumentList ticker_search;
        Form1 mainForm;
        int i = 0;
        private async void get_bonds()
        {
            bonds = await mainForm.context.MarketBondsAsync();
            write_bonds1(bonds.Instruments[i]);
            i++;
            write_bonds2(bonds.Instruments[i]);
            i++;
            write_bonds3(bonds.Instruments[i]);
            i++;
            write_bonds4(bonds.Instruments[i]);
        }
        private void but_main_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void write_bonds1(Tinkoff.Trading.OpenApi.Models.MarketInstrument bond)
        {
            label34.Text = Convert.ToString(i + 1);
            textBox1.Text = bond.Figi;
            textBox2.Text = bond.Ticker;
            textBox3.Text = bond.Isin;
            textBox4.Text = Convert.ToString(bond.MinPriceIncrement);
            textBox5.Text = Convert.ToString(bond.Lot);
            textBox6.Text = Convert.ToString(bond.Currency);
            textBox7.Text = bond.Name;
            textBox8.Text = Convert.ToString(bond.Type);
        }
        private void write_bonds2(Tinkoff.Trading.OpenApi.Models.MarketInstrument bond)
        {
            label35.Text = Convert.ToString(i + 1);
            textBox16.Text = bond.Figi;
            textBox15.Text = bond.Ticker;
            textBox14.Text = bond.Isin;
            textBox13.Text = Convert.ToString(bond.MinPriceIncrement);
            textBox12.Text = Convert.ToString(bond.Lot);
            textBox11.Text = Convert.ToString(bond.Currency);
            textBox10.Text = bond.Name;
            textBox9.Text = Convert.ToString(bond.Type);
        }
        private void write_bonds3(Tinkoff.Trading.OpenApi.Models.MarketInstrument bond)
        {
            label37.Text = Convert.ToString(i + 1);
            textBox24.Text = bond.Figi;
            textBox23.Text = bond.Ticker;
            textBox22.Text = bond.Isin;
            textBox21.Text = Convert.ToString(bond.MinPriceIncrement);
            textBox20.Text = Convert.ToString(bond.Lot);
            textBox19.Text = Convert.ToString(bond.Currency);
            textBox18.Text = bond.Name;
            textBox17.Text = Convert.ToString(bond.Type);
        }
        private void write_bonds4(Tinkoff.Trading.OpenApi.Models.MarketInstrument bond)
        {
            label39.Text = Convert.ToString(i + 1);
            textBox32.Text = bond.Figi;
            textBox31.Text = bond.Ticker;
            textBox30.Text = bond.Isin;
            textBox29.Text = Convert.ToString(bond.MinPriceIncrement);
            textBox28.Text = Convert.ToString(bond.Lot);
            textBox27.Text = Convert.ToString(bond.Currency);
            textBox26.Text = bond.Name;
            textBox25.Text = Convert.ToString(bond.Type);
        }

        private void but_next_stocks_Click(object sender, EventArgs e)
        {
            if (i + 4 > mainForm.stocks.Instruments.Count)
            {
                if (i + 3 > mainForm.stocks.Instruments.Count)
                {
                    if (i + 2 > mainForm.stocks.Instruments.Count)
                    {
                        if (i + 1 > mainForm.stocks.Instruments.Count)
                        {

                        }
                        else
                        {
                            i++;
                            write_bonds1(bonds.Instruments[i]);
                        }
                    }
                    else
                    {
                        i++;
                        write_bonds1(bonds.Instruments[i]);
                        i++;
                        write_bonds2(bonds.Instruments[i]);
                    }
                }
                else
                {
                    i++;
                    write_bonds1(bonds.Instruments[i]);
                    i++;
                    write_bonds2(bonds.Instruments[i]);
                    i++;
                    write_bonds3(bonds.Instruments[i]);
                }
            }
            else
            {
                i++;
                write_bonds1(bonds.Instruments[i]);
                i++;
                write_bonds2(bonds.Instruments[i]);
                i++;
                write_bonds3(bonds.Instruments[i]);
                i++;
                write_bonds4(bonds.Instruments[i]);
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
                        write_bonds2(bonds.Instruments[i]);
                        i--;
                        write_bonds1(bonds.Instruments[i]);
                        i--;
                    }
                }
                else
                {
                    write_bonds3(bonds.Instruments[i]);
                    i--;
                    write_bonds2(bonds.Instruments[i]);
                    i--;
                    write_bonds1(bonds.Instruments[i]);
                    i--;
                }
            }
            else
            {
                write_bonds4(bonds.Instruments[i]);
                i--;
                write_bonds3(bonds.Instruments[i]);
                i--;
                write_bonds2(bonds.Instruments[i]);
                i--;
                write_bonds1(bonds.Instruments[i]);
                i--;
            }
        }

        private void but_figi_search_Click(object sender, EventArgs e)
        {
            searchbyFigi(textBox33.Text);
        }
        private async void searchbyFigi(string figi)
        {
            figi_search = await mainForm.context.MarketSearchByFigiAsync(figi);
            write_bonds1(figi_search);
        }
        private void but_ticker_search_Click(object sender, EventArgs e)
        {
            searchbyTicker(textBox34.Text);
        }
        private async void searchbyTicker(string ticker)
        {
            ticker_search = await mainForm.context.MarketSearchByTickerAsync(ticker);
            Tinkoff.Trading.OpenApi.Models.MarketInstrument ticker_instrument_search;
            ticker_instrument_search = ticker_search.Instruments[0];
            write_bonds1(ticker_instrument_search);
        }
    }
}
