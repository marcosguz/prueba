using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModeloDB
{
    public class Class1 : DbContext
    {
        //Configuracion de las entidades
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //Modelado
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion uno a uno de Rental a Customer
            modelBuilder.Entity<Rental>()
                .HasOne(rental => rental.CustomerName)
                .WithMany(customer => customer.RentalName)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(rental => rental.CustomerId);

            //Relacion uno a varios de Payment a Rental
            modelBuilder.Entity<Payment>()
                .HasOne(payment => payment.RentalName)
                .WithMany(rental => rental.ListPayment)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(payment => payment.RentalId);

            //Relacion uno a Varios de Payment a Customer
            modelBuilder.Entity<Payment>()
                .HasOne(payment => payment.CustomerName)
                .WithMany(customer => customer.ListPayment)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(payment => payment.CustomerId);
        }

        //Conexion con la base de datos SQLServer
        override protected void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("SERVER=DESKTOP-JEQTB22; initial catalog = Prueba; trusted_connection = true;");
        }
    }
}