using System.ComponentModel.DataAnnotations;

namespace SoalNo3MembuatAPI
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nama { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}