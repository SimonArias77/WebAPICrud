using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCrud.Data;
using WebApiCrud.Models;

namespace WebApiCrud.Controllers;

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
    //POST: api/Producto
    [HttpPost]
    public async Task<IActionResult> PostProducto(Producto producto)
    {
        await  _context.Productos.AddAsync(producto);
        await _context.SaveChangesAsync();
        return Ok("producto guardado con éxito");
         
    }
}


//Get (leer u obtener datos desde el servidor, se pueden obtener todos los productos o solo uno por ID)
//Post (se usa para crear un nuevo recurso en el servidor)
//Delete ( se usa para eliminar un recurso existente en el servidor) 
//Put (se usa para actualizar un recurso existente, generalmente para reemplazar)




