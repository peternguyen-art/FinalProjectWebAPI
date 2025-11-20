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

        
    }
}
