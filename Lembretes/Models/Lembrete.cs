using System.ComponentModel.DataAnnotations;

namespace Lembretes.Models
{
    public class Lembrete
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Data { get; set; }
    }
}
