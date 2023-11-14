using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using reserva_emergencia.Models;
using System.Security.Cryptography.X509Certificates;

namespace reserva_emergencia.Controllers
{
    public class ReservasController : Controller // Criando um controlador 
    {
        private readonly AppDbContext _context;
        public ReservasController(AppDbContext context)
        {
            _context = context; // toda vez que fazer alteracao no banco de dados será utilizado a varial context pra isso
        }
        // classe de ineração do usuário
        // classe index vai retornar os dados da tabela
        public async Task<IActionResult> Index() // Tornando a função assincrona, independente, para que a operação não seja bloqueada 
        {
            var dados = await _context.Reservas.ToListAsync(); //Retorna os dados da tabela Reservas, lista os dados

            return View(dados);
        }
        //requisição get
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Reserva reserva)
        {
            if (ModelState.IsValid)
            { // Se o modelo de dados for válido
                _context.Reservas.Add(reserva); // vai adicionar a lista de dados no banco de dados           
                await _context.SaveChangesAsync(); // salvar os dados no banco de dados
                return RedirectToAction("Index"); // retornar para a tela de index 
            }

            return View(reserva);
        }

        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null) // se o id for nulo, retorne "não encontrado"
                return NotFound();

            var dados = await _context.Reservas.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Reserva veiculo)
        {

            if (id != veiculo.Id)
                return NotFound(); // se o id não for falso 

            if (ModelState.IsValid)
            { // verifica Se o modelo de dados for válido e todos os campos estão preenchidos

                _context.Reservas.Update(veiculo); // atualiza a lista de dados no banco de dados  
                await _context.SaveChangesAsync(); // salvar os dados no banco de dados
                return RedirectToAction("Index"); // retornar para a tela de index 
            }


            return View();          
        }
        public async Task<IActionResult> Datail(int? id) // Detalhar os dados 
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Reservas.FindAsync(id);

            if (dados == null)
                return NotFound();

           
            return View(dados);
        }

    }
}
