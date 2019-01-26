using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public IList<Order> Orders { get; set; }

        public Customer()
        {

        }

        public Customer(string firstName, string lasName, string birthdate)
        {
            FirstName = firstName;
            LastName = lasName;

            DateTime dateTime;
            DateTime.TryParseExact(birthdate, "dd-mm-yyyy",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out dateTime);

            Birthdate = dateTime;
        }
    }
}
