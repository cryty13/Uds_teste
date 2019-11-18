using System;
using System.Collections.Generic;
using System.Text;

namespace Uds.Domain.Entities
{
    public class Pizza
    {
        public Guid PizzaId { get; set; }
        public string Tamanho { get; set; }
        public string Sabor { get; set; }
        public float ValorTotal { get; set; }
        public int TempoPreparo { get; set; }
        public virtual List<AdicionalPizza> adicionalPizza { get; set; }
    }
}
