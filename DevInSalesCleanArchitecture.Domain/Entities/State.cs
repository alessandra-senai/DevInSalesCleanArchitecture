using System.ComponentModel.DataAnnotations;

namespace DevInSalesCleanArchitecture.Domain.Entities
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
    }
}
