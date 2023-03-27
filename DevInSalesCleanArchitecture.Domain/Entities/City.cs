using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DevInSalesCleanArchitecture.Domain.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("State")]
        public int State_Id { get; set; }
        public State State { get; set; }
    }
}
