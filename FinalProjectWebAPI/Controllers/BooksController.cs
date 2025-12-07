using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectWebAPI.Data;
using FinalProjectWebAPI.Models;

namespace FinalProjectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly FinalProjectWebAPIContext _context;

        public BooksController(FinalProjectWebAPIContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetBook()
        {
            var book = _context.Book.ToList();
            return Ok(book);
        }
        [HttpGet("{id}")]
        public IActionResult Getbook(int id)
        {
            Book book = _context.Book.Find(id);
            if (book == null || id == 0)
            {
                List<Book> firstFivebooks = _context.Book.Take(5).ToList();
                return Ok(firstFivebooks);
            }
            else
                return Ok(book);
        }
        [HttpPost]
        public IActionResult Postbook(Book book)
        {
            try
            {
                _context.Book.Add(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Deletebook(int id)
        {
            Book book = _context.Book.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            try
            {
                _context.Book.Remove(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Putbook(Book book)
        {
            try
            {
                _context.Entry(book).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }


    }
}
