using System;
using System.Collections.Generic;
using System.Text;

namespace Uds.Domain.Entities
{
    public class Sabor
    {
        public Guid SaborId { get; set; }
        public string Descricao { get; set; }
        public int Tempo { get; set; }
    }
}
