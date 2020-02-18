using ManagingApp.WebApi.Entities;
using ManagingApp.WebApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ManagingApp.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoProntoController : ControllerBase
    {
        private readonly IProdutoProntoRepository _produtoProntoRepository;

        public ProdutoProntoController(IProdutoProntoRepository produtoProntoRepository)
        {
            _produtoProntoRepository = produtoProntoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_produtoProntoRepository.FindAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProdutoPronto produtoPronto)
        {
            _produtoProntoRepository.Save(produtoPronto);
            return Ok(await _produtoProntoRepository.UnitOfWork.Commit());
        }
    }
}
