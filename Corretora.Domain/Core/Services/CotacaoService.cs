using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Domain.Core.Interfaces.Services;

namespace Corretora.Domain.Core.Services
{
    public class CotacaoService : ICotacaoService
    {
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoService(ICotacaoRepository cotacaoRepository)
        {
            _cotacaoRepository = cotacaoRepository;
        }

        public async Task Delete(Cotacao entity)
        {
            await _cotacaoRepository.Delete(entity);  
        }

        public async Task<Cotacao> Get(object id)
        {
           return await _cotacaoRepository.Get(id);
        }

        public async Task<IEnumerable<Cotacao>> GetAll()
        {
            return await _cotacaoRepository.GetAll(); 
        }

        public async Task Save(Cotacao entity)
        {
            await  _cotacaoRepository.Save(entity);
        }

        public async Task Update(Cotacao entity)
        {
            await   _cotacaoRepository.Update(entity);  
        }
    }
}
