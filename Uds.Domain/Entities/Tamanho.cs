using System;
using System.Collections.Generic;
using System.Text;

namespace Uds.Domain.Entities
{
    public class Tamanho
    {
        public Guid TamanhoId { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public int Tempo { get; set; }
    }
}
