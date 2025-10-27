using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace projetoHope.Models
{
    public class Selecionado
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        [Indexed(Unique = true)] public int UserId { get; set; } // 1 seleção por usuário
        public int ServiceId { get; set; }
        public DateTime SelectedAt { get; set; } = DateTime.UtcNow;
    }
}
