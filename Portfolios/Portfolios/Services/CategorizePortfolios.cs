using Portfolios.Models;
using Portfolios.Services.Interfaces;

namespace Portfolios.Services
{
    public class CategorizePortfolios : ICategorizePortfolios
    {
        public List<string> Categorize(List<FinancialInstrument> financialInstruments)
        {
            List<string> result = new List<string>();

            foreach (var financialInstrument in financialInstruments)
            {
                if (financialInstrument.MarketValue < 1000000)
                {
                    result.Add("Low Value");
                }
                else if (financialInstrument.MarketValue >= 1000000 && financialInstrument.MarketValue <= 5000000)
                {
                    result.Add("Medium Value");
                }
                else if (financialInstrument.MarketValue > 5000000)
                {
                    result.Add("High Value");
                }
            }

            return result;
        }
    }
}
