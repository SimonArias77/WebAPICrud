using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCrud.Models; //recordar poner el using que enlace con el proyecto

namespace WebApiCrud.Data;

public class ApplicationDbContext : DbContext
{
    //Models
    public DbSet<Producto> Productos { get; set; } //dentro de las boquillas debe ir el nombre de la clase e inmediatamente despues el mismo nombre en plural que hace referencia a la tabla de la base de datos
    //constructor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }


}