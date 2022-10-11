using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Domain.Core.Interfaces.Services;

namespace Corretora.Domain.Core.Services
{
    public class AcaoService : IAcaoService
    {

        private readonly IAcaoRepository _acaoRepository;

        public AcaoService(IAcaoRepository acaoRepository)
        {
            _acaoRepository = acaoRepository;
        }

        public async Task Delete(Acao entity)
        {
            await _acaoRepository.Delete(entity);
        }

        public async Task<Acao> Get(object id)
        {
            return await _acaoRepository.Get(id);
        }

        public async Task<IEnumerable<Acao>> GetAll()
        {
            return await _acaoRepository.GetAll();    
        }

        public async Task Save(Acao entity)
        {
            await _acaoRepository.Save(entity);           

        }

        public async Task Update(Acao entity)
        {
            await _acaoRepository.Update(entity);
        }
    }
}
