using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
            EventoId = 1,
           Tema = "Angular e .NET 5",
           Local = "Olinda",
           Lote = "1º Lote",
           QtdPessoas = 250,
           DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
           ImageURL = "foto.jpg"
         },
          new Evento(){
            EventoId = 2,
           Tema = "estudos e novidades",
           Local = "Recife",
           Lote = "2º Lote",
           QtdPessoas = 350,
           DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
           ImageURL = "foto2.jpg"
         }};


         [HttpGet]
        public IEnumerable <Evento>  Get()
        {
           return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable <Evento>  GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public String Post()
        {
           return "exemplo de POST";
        }

         [HttpPut("{id}")]
        public String PUT(int id)
        {
           return $"exemplo de PUT com id = {id}";
        }

         [HttpDelete("{id}")]
        public String Delete(int id)
        {
           return $"exemplo de DELETE com id = {id}";
        }
    }
}
