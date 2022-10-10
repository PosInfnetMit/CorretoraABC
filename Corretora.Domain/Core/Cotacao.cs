﻿namespace Corretora.Domain.Core
{
    public class Cotacao : Entity<Guid>
    {        
        public DateTime Data { get; set; }
        public decimal Abertura { get; set; }
        public decimal Alta { get; set; }
        public decimal Baixa { get; set; }
        public decimal Fechamento { get; set; }
        public decimal FechamentoAjustado { get; set; }
        public int Volume { get; set; }
    }
}
