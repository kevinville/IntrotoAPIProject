using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WorkerSalaryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerSalaryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
        private readonly SalaryDbContext _context;


        public PublicController(SalaryDbContext context)
        {
            _context = context;
        }

        // api/Public
        [HttpGet]
        public async Task<ActionResult<Response>> GetPublicInfo()
        {
            var response = new Response();
            response.statusCode = 200;

            var listofworkers = await _context.PublicInfo.ToListAsync();

            response.Public = listofworkers;

            if (listofworkers.Count == 0)
            {
                response.statusCode = 404;
                response.statusDescription = "No workers?";
            }

            return response;

        }
    }
}
