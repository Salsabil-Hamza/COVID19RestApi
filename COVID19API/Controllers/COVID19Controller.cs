using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COVID19API.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Linq.Expressions;

namespace COVID19API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class COVID19Controller : ControllerBase
    {
        private readonly COVID19APIContext _context;

        public static IWebHostEnvironment _environment;

      

        public class FileUploadAPI
        {
            public IFormFile files { get; set; }
        }



        public COVID19Controller(COVID19APIContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }


    //    [HttpPost]
    //    public async Task<string> Post(FileUploadAPI objFile)
    //    {
    //        try
    //        { 
    //        if (objFile.files.Length > 0)
    //        {
    //            if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
    //            {
    //                Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
    //            }
    //            using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
    //            {
    //                objFile.files.CopyTo(fileStream);
    //                fileStream.Flush();
    //                return "\\Upload\\" + objFile.files.FileName;
    //            }
    //        }
    //        else
    //        {
    //            return "Failed";
    //        }
        
    //}
    //    catch(Exception ex)
    //    {
    //        return ex.Message.ToString();
    //    }
    //}



        // GET: api/COVID19
        [HttpGet]
        public async Task<ActionResult<IEnumerable<COVID19>>> GetCOVID19()
        {
            return await _context.COVID19.ToListAsync();
        }

        // GET: api/COVID19/5
        [HttpGet("{id}")]
        public async Task<ActionResult<COVID19>> GetCOVID19(int id)
        {
            var cOVID19 = await _context.COVID19.FindAsync(id);

            if (cOVID19 == null)
            {
                return NotFound();
            }

            return cOVID19;
        }

        // PUT: api/COVID19/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCOVID19(int id, COVID19 cOVID19)
        {
            if (id != cOVID19.Id)
            {
                return BadRequest();
            }

            _context.Entry(cOVID19).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!COVID19Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/COVID19
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
       public async Task<ActionResult<COVID19>> PostCOVID19(COVID19 cOVID19)
        {
            _context.COVID19.Add(cOVID19);
            await _context.SaveChangesAsync();

          return CreatedAtAction("GetCOVID19", new { id = cOVID19.Id }, cOVID19);
        }

        // DELETE: api/COVID19/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<COVID19>> DeleteCOVID19(int id)
        {
            var cOVID19 = await _context.COVID19.FindAsync(id);
            if (cOVID19 == null)
            {
                return NotFound();
            }

            _context.COVID19.Remove(cOVID19);
            await _context.SaveChangesAsync();

            return cOVID19;
        }

        private bool COVID19Exists(int id)
        {
            return _context.COVID19.Any(e => e.Id == id);
        }
    }
}
