using System.ComponentModel.DataAnnotations;

namespace Lembretes.Models
{
    public class Lembrete
    {
        [Key] public string Name { get; set; }
        public DateTime Data { get; set; }
    }
}
