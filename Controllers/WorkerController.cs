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
    public class WorkerController : ControllerBase
    {
        private readonly SalaryDbContext _context;


        public WorkerController(SalaryDbContext context)
        {
            _context = context;
        }

        // GET ALL api/Worker
        [HttpGet]
        public async Task<ActionResult<Response>> GetWorkers()
        {
            var response = new Response();
            response.statusCode = 200;

            var listofworkers = await _context.Worker.Include(i => i.PublicInfo).ToListAsync();

            response.Worker = listofworkers;

            if (listofworkers.Count == 0)
            {
                response.statusCode = 404;
                response.statusDescription = "No workers?";
            }

            response.statusDescription = "Successfully fetched Workers.";
            return response;
            
        }
        
        // GET ID api/Worker/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Response>> GetWorker(int id)
        {

            var workers = await _context.Worker.Include(i => i.PublicInfo).Where(i => i.WorkerId == id).ToListAsync();
            var response = new Response();
            response.statusCode = 200;

            if(workers.Count == 0)
            {
                response.statusCode = 404;
                response.statusDescription = "ID Does not Exist";
                return NotFound(response);
            }
            response.Worker = workers;
            response.statusDescription = "Fetched Worker with said ID";
            return response;
        }

        private bool WorkerExists(int id)
        {
            return _context.Worker.Any(i => i.WorkerId == id);
        }

        // PUT api/Worker/id
        [HttpPut("{id}")]
        public async Task<ActionResult<Response>> PutWorker(int id, Worker worker)
        {
            var response = new Response();

            if (id != worker.WorkerId)
            {
                return BadRequest();
            }

            _context.Entry(worker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (WorkerExists(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            response.statusCode = 200;
            response.statusDescription = "Successfully updated info.";
            return response;
            
        }

        // POST api/Worker
        [HttpPost]
        public async Task<ActionResult<Response>> PostWorkers(Worker worker)
        {
            var response = new Response();
            response.statusCode = 201;

            try
            {
                _context.Worker.Add(worker);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                response.statusCode = 500;
                response.statusDescription = "Could not add worker into DB. Perhaps wrong syntax?";
                return response;
            }

            var addedWorker = await _context.Worker.Where(i => i.WorkerId == worker.WorkerId).ToListAsync();
            response.Worker = addedWorker;
            response.statusDescription = "Added worker into the Database.";

            return Ok(response);
        }

        // DELETE api/Worker/id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Response>> DeleteWorker(int id)
        {
            var response = new Response();
            response.statusCode = 200;
            var worker = await _context.Worker.FindAsync(id);

            if(worker == null)
            {
                response.statusCode = 400;
                response.statusDescription = "Worker does not Exist.";
                return NotFound(response);
            }

            _context.Worker.Remove(worker);
            await _context.SaveChangesAsync();
            response.statusDescription = "Worker has been deleted.";
            return response;
        }

    }
}
