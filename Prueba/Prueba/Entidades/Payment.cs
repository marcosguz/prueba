using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int StaffId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        //Propiedad Relacion con Rental
        public Rental RentalName { get; set; }
        public int RentalId { get; set; }

        //Propiedad Relacion con Customer
        public Customer CustomerName { get; set; }
        public int CustomerId { get; set; }
    }
}
