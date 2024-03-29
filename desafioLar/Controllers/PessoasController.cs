﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using desafioLar.Data;
using desafioLar.Models;

namespace desafioLar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PessoasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Pessoas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoas()
        {
            return await _context.Pessoas
                                 .Include(p => p.Telefones)
                                 .ToListAsync();
        }


        // GET: api/Pessoas/{nome}
        [HttpGet("{nome}")]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoasByNome(string nome)
        {
            var pessoas = await _context.Pessoas
                                        .Where(p => p.Nome.Contains(nome)) 
                                        .Include(p => p.Telefones) 
                                        .ToListAsync();

            if (!pessoas.Any())
            {
                return NotFound();
            }

            return pessoas;
        }





        // PUT: api/Pessoas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Pessoa>> PutPessoa(int id, Pessoa pessoa)
        {
            if (id != pessoa.PessoaId)
            {
                return BadRequest();
            }

            _context.Entry(pessoa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            
            return Ok(pessoa);
        }


        // POST: api/Pessoas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPessoa", new { id = pessoa.PessoaId }, pessoa);
        }

        // DELETE: api/Pessoas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePessoa(int id)
        {
            var pessoa = await _context.Pessoas.FindAsync(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("{pessoaId}/Telefone/{telefoneId}")]
        public async Task<ActionResult<Telefone>> GetTelefone(int pessoaId, int telefoneId)
        {
            var telefone = await _context.Telefones
                                         .Where(t => t.PessoaId == pessoaId && t.TelefoneId == telefoneId)
                                         .FirstOrDefaultAsync();

            if (telefone == null)
            {
                return NotFound();
            }

            return telefone;
        }


        [HttpPost("{pessoaId}/Telefone")]
        public async Task<ActionResult<Telefone>> PostTelefone(int pessoaId, Telefone telefone)
        {
            var pessoa = await _context.Pessoas.FindAsync(pessoaId);
            if (pessoa == null)
            {
                return NotFound();
            }

            telefone.PessoaId = pessoaId;


            telefone.TelefoneId = 0;

            _context.Telefones.Add(telefone);
            await _context.SaveChangesAsync();

            
            return Ok(telefone);
        }

        [HttpDelete("{pessoaId}/Telefone/{telefoneId}")]
        public async Task<IActionResult> DeleteTelefone(int pessoaId, int telefoneId)
        {
            
            var telefone = await _context.Telefones
                .Where(t => t.TelefoneId == telefoneId && t.PessoaId == pessoaId)
                .FirstOrDefaultAsync();

           
            if (telefone == null)
            {
                return NotFound();
            }

            
            _context.Telefones.Remove(telefone);
            await _context.SaveChangesAsync();

            
            return NoContent();
        }


        private bool PessoaExists(int id)
        {
            return _context.Pessoas.Any(e => e.PessoaId == id);
        }
    }
}
