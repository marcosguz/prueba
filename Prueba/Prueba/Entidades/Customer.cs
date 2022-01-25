using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int AddresId { get; set; }
        public bool ActiveBoll { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Active { get; set; }

        //Propiedad relacion con Rental
        public IEnumerable<Rental> RentalName { get; set; }

        //Propiedad Relacion con Payment
        public IEnumerable<Payment> ListPayment { get; set; }
    }
}
