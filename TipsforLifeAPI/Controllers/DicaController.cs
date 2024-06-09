using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using TipsforLifeAPI.Data;
using TipsforLifeAPI.Entidades;

namespace TipsforLifeAPI.Controllers
{
    [Route("api/Dica")]
    [ApiController]
    public class DicaController : ControllerBase
    {
        private readonly DicaContext _dicaContext;

        public DicaController(DicaContext dicaContext)
        {
            _dicaContext = dicaContext;
        }

        [HttpGet]
        public async Task<ActionResult<DicaModel>> ObterMensagem()
        {
            try
            {
                DicaModel dicaModel = new DicaModel();

                using var http = new HttpClient();
                var retorno = await http.GetAsync("https://api.adviceslip.com/advice");

                var conteudo = await retorno.Content.ReadAsStringAsync();
                dicaModel = JsonConvert.DeserializeObject<DicaModel>(conteudo);

                _dicaContext.Add(dicaModel);
                await _dicaContext.SaveChangesAsync();
                return Ok(dicaModel);
            }
            catch (Exception)
            {

                return BadRequest("Id mensagem já existe!");
            }
        }

    }
}
