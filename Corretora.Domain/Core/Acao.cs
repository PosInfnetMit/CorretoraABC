using System.ComponentModel.DataAnnotations;

namespace Corretora.Domain.Core
{
    public class Acao : Entity<Guid>
    {
        
        [MaxLength(300)]
        public string Nome { get; set; }
        
        
        [MaxLength(10)]
        public string Sigla { get; set; }

        public IEnumerable<Cotacao> Cotacoes { get; set; }


    }
}
