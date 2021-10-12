using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace fooddelivery.foodie
{
    public class newfoodie
    {
        
               
        public string Fitem { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public decimal Price { get; set; }
         [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public int TotalItems { get; set; }
        
    }
}
