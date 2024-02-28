using Portfolios.Models;

namespace Portfolios.Services.Interfaces
{
    public interface ICategorizePortfolios
    {
        public List<string> Categorize(List<FinancialInstrument> financialInstruments);
    }
}
