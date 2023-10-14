﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContaFacil2.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace ContaFacil2.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly AppDbContex _context;

        public CadastrosController(AppDbContex context)
        {
            _context = context;
        }

        // GET: Cadastros
        public async Task<IActionResult> Index()
        {
              return View(await _context.Cadastros.ToListAsync());
        }


        //criando login 

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login (Cadastro cadastro)
        {
            var dados = await _context.Cadastros.FindAsync(cadastro.IdUsuario);
            if(dados == null)
            {
                ViewBag.Message = "Usuário ou senha errados";
                return View();
            }
            bool senhaOk = BCrypt.Net.BCrypt.Verify(cadastro.Senha, dados.Senha);
            if (senhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, cadastro.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, dados.Perfil.ToString())
                };

                var usuarioIdentify = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentify);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");


            }
            else
            {
                ViewBag.Message = "Usuário ou senha errados";
            }

            return View();
        }
        
        //criando o logout

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Cadastros");
        }






        // GET: Cadastros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastros
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // GET: Cadastros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cadastros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,Nome,Email,Logadouro,Cidade,Uf,CEP,Telefone,Cpf,Senha,Perfil")] Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                cadastro.Senha = BCrypt.Net.BCrypt.HashPassword(cadastro.Senha);
                _context.Add(cadastro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastro);
        }

        // GET: Cadastros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastros.FindAsync(id);
            if (cadastro == null)
            {
                return NotFound();
            }
            return View(cadastro);
        }

        // POST: Cadastros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,Nome,Email,Logadouro,Cidade,Uf,CEP,Telefone,Cpf,Senha,Perfil")] Cadastro cadastro)
        {
            if (id != cadastro.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cadastro.Senha = BCrypt.Net.BCrypt.HashPassword(cadastro.Senha);
                    _context.Update(cadastro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroExists(cadastro.IdUsuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cadastro);
        }

        // GET: Cadastros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastros
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // POST: Cadastros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cadastros == null)
            {
                return Problem("Entity set 'AppDbContex.Cadastros'  is null.");
            }
            var cadastro = await _context.Cadastros.FindAsync(id);
            if (cadastro != null)
            {
                _context.Cadastros.Remove(cadastro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroExists(int id)
        {
          return _context.Cadastros.Any(e => e.IdUsuario == id);
        }
    }
}