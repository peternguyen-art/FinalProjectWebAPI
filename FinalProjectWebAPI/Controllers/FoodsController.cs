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
    public class FoodsController : ControllerBase
    {
        private readonly FinalProjectWebAPIContext _context;

        public FoodsController(FinalProjectWebAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFood()
        {
            var food = _context.Food.ToList();
            return Ok(food);
        }
        [HttpGet("{id}")]
        public IActionResult GetFood(int id)
        {
            Food food = _context.Food.Find(id);
            if (food == null || id == 0)
            {
                List<Food> firstFiveFoods = _context.Food.Take(5).ToList();
                return Ok(firstFiveFoods);
            }
            else 
                return Ok(food);
        }
        [HttpPost]
        public IActionResult PostFood(Food food)
        {
            try
            {
                _context.Food.Add(food);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFood(int id)
        {
            Food food = _context.Food.Find(id);
            if (food == null)
            {
                return NotFound();
            }
            try
            {
                _context.Food.Remove(food);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult PutFood(Food food)
        {
            try
            {
                _context.Entry(food).State = EntityState.Modified;
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
