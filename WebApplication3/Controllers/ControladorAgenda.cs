using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ControladorAgenda : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;
        public ControladorAgenda(MVCDemoDbContext mvcMicrosoftWebApplication3)
        {

        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddAgendaViewModel addAgendaRequest)
        {
            var agenda = new agenda()
            {
                Id = Guid.NewGuid(),
                responsavel = addAgendaRequest.Responsavel,
                dataInicial = addAgendaRequest.Data_inicial,
                dataFinal = addAgendaRequest.data_conclusão,
                prazo = addAgendaRequest.Prazo,
                atividade = addAgendaRequest.Titulo,
                descrição = addAgendaRequest.Descrição,
                Status = addAgendaRequest.Status,
            };

            return View(agenda);
        }
    }
}
