using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace swift_car_rental.Models { 
    public class CarDetails
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public int ModelYear { get; set; }

        public int Odometer { get; set; }
        public int NoOfSeats { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}