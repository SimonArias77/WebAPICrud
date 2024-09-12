using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCrud.Data;

namespace WebApiCrud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Producto
        [HttpGet]
    public async Task<IActionResult> GetProducto()
    {
        return Ok(await _context.Productos.ToListAsync());
            }
//get, post, delete,put
       
    }
}