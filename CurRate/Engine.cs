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
        public void get_connection(string token)
        {
            connection = ConnectionFactory.GetSandboxConnection(token);
            context = connection.Context;
            get_stocks_async();
            get_bonds_async();
            get_etfs_async();
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
