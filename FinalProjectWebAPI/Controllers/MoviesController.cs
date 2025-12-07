using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectWebAPI.Data;
using FinalProjectWebAPI.Models;


[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly FinalProjectWebAPIContext _context;

    public MoviesController(FinalProjectWebAPIContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetFood()
    {
        var movie = _context.Movie.ToList();
        return Ok(movie);
    }
    [HttpGet("{id}")]
    public IActionResult GetMovie(int id)
    {
        Movie movie = _context.Movie.Find(id);
        if (movie == null || id == 0)
        {
            List<Movie> firstFiveMovie = _context.Movie.Take(5).ToList();
            return Ok(firstFiveMovie);
        }
        else
            return Ok(movie);
    }
    [HttpPost]
    public IActionResult PostMovie(Movie movie)
    {
        try
        {
            _context.Movie.Add(movie);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id)
    {
        Movie movie = _context.Movie.Find(id);
        if (movie == null)
        {
            return NotFound();
        }
        try
        {
            _context.Movie.Remove(movie);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok();
    }
    [HttpPut]
    public IActionResult PutMovie(Movie movie)
    {
        try
        {
            _context.Entry(movie).State = EntityState.Modified;
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            return NotFound();
        }
        return Ok();
    }
}


