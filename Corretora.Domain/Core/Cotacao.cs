using Skender.Stock.Indicators;

namespace Corretora.Domain.Core
{
    public class Cotacao : Entity<Guid>, IQuote
    {        
        public Guid AcaoId { get; set; }
        public DateTime Data { get; set; }
        public decimal Abertura { get; set; }
        public decimal Alta { get; set; }
        public decimal Baixa { get; set; }
        public decimal Fechamento { get; set; }
        public decimal FechamentoAjustado { get; set; }
        public int Volume { get; set; }
        public Acao Acao { get; set; }  

        // mapping for indicator library
        DateTime IQuote.Date => Data;
        decimal IQuote.Open => Abertura;
        decimal IQuote.High => Alta;
        decimal IQuote.Low => Baixa;
        decimal IQuote.Close => Fechamento;
        decimal IQuote.Volume => Volume;
    }
}
