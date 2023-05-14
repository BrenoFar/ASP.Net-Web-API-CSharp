using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SistemaTarefasDBContex : DbContext //trabalhando com um ORM
    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options)
            : base(options) 
        { 
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }
    }
}
