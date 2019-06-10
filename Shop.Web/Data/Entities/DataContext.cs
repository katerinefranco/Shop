namespace Shop.Web.Data.Entities
{
    using Microsoft.EntityFrameworkCore;
    using System;



    public class DataContext : DbContext //usa el entiti framework para .net core
    {

        public DbSet<Product> Products { get; set; } //se va a mapear como una tabla, se va a crear la clase como una bd



        public DataContext(DbContextOptions<DataContext> options) : base(options)//conexion a la BD en el contructor
        {

        }
    }
}
