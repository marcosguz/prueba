using System;
using Modelo.Entidades;
using ModeloDB;

namespace Prueba
{
    internal class Program
    {
        public static object GestionConsola { get; set; }

        static void Main(string[] args)
        {
            //Creacion de Rental
            Rental rentaJuan = new Rental()
            {
                RentalDate = DateTime.Now,
                InventoryId = 2,
                ReturnDate = new DateTime(2022, 3, 15),
                StaffId = 3,
            };

            Rental rentaJuan1 = new Rental()
            {
                RentalDate = DateTime.Now,
                InventoryId = 2,
                ReturnDate = new DateTime(2022, 3, 15),
                StaffId = 3,
            };

            Rental rentaPedro = new Rental()
            {
                RentalDate = DateTime.Now,
                InventoryId = 2,
                ReturnDate = new DateTime(2022, 3, 15),
                StaffId = 3,
            };
            Rental rentaPedro1 = new Rental()
            {
                RentalDate = DateTime.Now,
                InventoryId = 2,
                ReturnDate = new DateTime(2022, 3, 15),
                StaffId = 3,
            };

            Rental rentaMaria = new Rental()
            {
                RentalDate = DateTime.Now,
                InventoryId = 2,
                ReturnDate = new DateTime(2022, 3, 15),
                StaffId = 3,
            };
            Rental rentaMaria1 = new Rental()
            {
                RentalDate = DateTime.Now,
                InventoryId = 2,
                ReturnDate = new DateTime(2022, 3, 15),
                StaffId = 3,
            };
            Rental rentaJoana = new Rental()
            {
                RentalDate = DateTime.Now,
                InventoryId = 2,
                ReturnDate = new DateTime(2022, 3, 15),
                StaffId = 3,
            };
            Rental rentaJoana1 = new Rental()
            {
                RentalDate = DateTime.Now,
                InventoryId = 2,
                ReturnDate = new DateTime(2022, 3, 15),
                StaffId = 3,
            };
            //Creacion Payment
            Payment payJuan = new Payment()
            {
                Amount = (decimal)200.00,
                PaymentDate = DateTime.Now,
                StaffId = 4
            };
            Payment payJuan1 = new Payment()
            {
                Amount = (decimal)300.00,
                PaymentDate = DateTime.Now,
                StaffId = 4
            };

            Payment payPedro = new Payment()
            {
                Amount = (decimal)200.00,
                PaymentDate = DateTime.Now,
                StaffId = 4
            };
            Payment payPedro1 = new Payment()
            {
                Amount = (decimal)300.00,
                PaymentDate = DateTime.Now,
                StaffId = 4
            };

            Payment payJoana = new Payment()
            {
                Amount = (decimal)200.00,
                PaymentDate = DateTime.Now,
                StaffId = 4
            };
            Payment payMaria = new Payment()
            {
                Amount = (decimal)300.00,
                PaymentDate = DateTime.Now,
                StaffId = 4
            };

            //Creacion de Customer
            Customer JuanPerez = new Customer()
            {
                FirstName = "Juan",
                LastName = "Perez",
                Email = "jperez@mail.com",
                AddresId = 2,
                ActiveBoll = true,
                CreateDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                Active = "Yes",
                RentalName = new List<Rental> { rentaJuan, rentaJuan1 },
                ListPayment = new List<Payment> { payJuan, payJuan1 }
            };

            Customer PedroJuares = new Customer()
            {
                FirstName = "Pedro",
                LastName = "Juarez",
                Email = "pjuarez@mail.com",
                AddresId = 2,
                ActiveBoll = true,
                CreateDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                Active = "Yes",
                RentalName = new List<Rental> { rentaPedro, rentaPedro1 },
                ListPayment = new List<Payment> { payPedro, payPedro1 }
            };

            Customer MariaPuican = new Customer()
            {
                FirstName = "Maria",
                LastName = "Puican",
                Email = "mpuican@mail.com",
                AddresId = 2,
                ActiveBoll = true,
                CreateDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                Active = "Yes",
                RentalName = new List<Rental> { rentaMaria, rentaMaria1 },
                ListPayment = new List<Payment> { payMaria }
            };

            Customer JoanaVarela = new Customer()
            {
                FirstName = "Joana",
                LastName = "Varela",
                Email = "jvarela@mail.com",
                AddresId = 2,
                ActiveBoll = true,
                CreateDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                Active = "Yes",
                RentalName = new List<Rental> { rentaJoana, rentaJoana1 },
                ListPayment = new List<Payment> { payJoana }
            };

            //Guardar en la base de datos
            Class1 repositorio = new Class1();
            repositorio.AddRange(new List<Customer>() { JuanPerez, PedroJuares, MariaPuican, JoanaVarela });
            repositorio.SaveChanges();
        }
    }
}
