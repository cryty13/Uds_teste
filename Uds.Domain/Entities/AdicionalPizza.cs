using System;
using System.Collections.Generic;
using System.Text;

namespace Uds.Domain.Entities
{
    public class AdicionalPizza
    {
        public Guid AdicionalPizzaId { get; set; }
        public Guid PizzaId { get; set; }
        public string Descricao { get; set; }
        public int Tempo { get; set; }
        public float Valor { get; set; }
        public int QtdAdicional { get; set; }
    }
}
