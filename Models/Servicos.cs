using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace projetoHope.Models
{
    public class Servicos
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        [NotNull] public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
