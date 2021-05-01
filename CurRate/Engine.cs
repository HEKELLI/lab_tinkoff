using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinkoff.Trading.OpenApi.Network;

namespace CurRate
{
    public class Engine
    {
        public SandboxConnection connection;
        public SandboxContext context;
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList Securities_stocks;
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList Securities_bonds;
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList Securities_etfs;
        //private Tinkoff.Trading.OpenApi.Models.SandboxAccount Account;
        //private Tinkoff.Trading.OpenApi.Models.BrokerAccountType type;
        private Tinkoff.Trading.OpenApi.Models.Portfolio portfolio;
        private Tinkoff.Trading.OpenApi.Models.PortfolioCurrencies currencies;
        private string brokerAccountId = "SB3336849";
        int tmp = 0;
        private bool flag = false;
        public void get_connection(string token)
        {
            connection = ConnectionFactory.GetSandboxConnection(token);
            context = connection.Context;
            get_stocks_async();
            get_bonds_async();
            get_etfs_async();
            get_porfolio_async();
            get_currencies_async();
            //register();
        }
        /*
        public async void register()
        {
            //type = Account.BrokerAccountType;
            Account = await context.RegisterAsync(type);
            brokerAccountId = Account.BrokerAccountId;
        }
        */
        public Tinkoff.Trading.OpenApi.Models.PortfolioCurrencies get_currencies()
        {
            get_currencies_async();
            if (flag == true)
            {
                flag = false;
                return currencies;
            }
            else
            {
                while(flag==false)
                {
                    tmp++;
                }
                tmp = 0;
                return currencies;
            }
        }

        private async void get_currencies_async()
        {
            currencies = await context.PortfolioCurrenciesAsync();
            flag = true;
        }

        public Tinkoff.Trading.OpenApi.Models.Portfolio get_portfolio()
        {
            get_porfolio_async();
            if (flag == true)
                return portfolio;
            else
                return null;
        }

        private async void get_porfolio_async()
        {
            portfolio = await context.PortfolioAsync(brokerAccountId);
            flag = true;
        }

        private async void get_stocks_async()
        {
            Securities_stocks = await context.MarketStocksAsync();
        }
        private async void get_bonds_async()
        {
            Securities_bonds = await context.MarketBondsAsync();
        }
        private async void get_etfs_async()
        {
            Securities_etfs = await context.MarketEtfsAsync();
        }
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList get_stocks()
        {
            return Securities_stocks;
        }
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList get_bonds()
        {
            return Securities_bonds;
        }
        public Tinkoff.Trading.OpenApi.Models.MarketInstrumentList get_etfs()
        {
            return Securities_etfs;
        }
    }
}
