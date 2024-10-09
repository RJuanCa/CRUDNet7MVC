using CRUDNet7MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDNet7MVC.Datos
{
    public class AplicationDbContex : DbContext
    {
        public AplicationDbContex(DbContextOptions<AplicationDbContex> options) : base(options)
        {
        }
        //Agregar los modelos aqui
        public DbSet<Contacto> Contacto { get; set; }
    }
}
