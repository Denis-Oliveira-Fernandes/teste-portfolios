using Microsoft.AspNetCore.Mvc;
using Portfolios.Models;
using Portfolios.Services;
using Portfolios.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfoliosController : ControllerBase
    {
        private ICategorizePortfolios _categorizePortfolios;

        public PortfoliosController(ICategorizePortfolios categorizePortfolios)
        {
            _categorizePortfolios = categorizePortfolios;
        }

        // POST api/<PortfoliosController>
        [HttpPost]
        public List<string> Post(List<FinancialInstrument> input)
        {
            var response = _categorizePortfolios.Categorize(input);

            return response;
        }
    }
}
