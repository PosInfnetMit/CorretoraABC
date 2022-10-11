using Corretora.Application.Interfaces;
using Corretora.Domain.Core;
using Corretora.Domain.Core.Interfaces.Services;

namespace Corretora.Application.App
{
    public class CotacaoApp : ICotacaoApp
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoApp(ICotacaoService cotacaoService)
        {
            _cotacaoService = cotacaoService;
        }

        public async Task Delete(Cotacao entity)
        {
            await _cotacaoService.Delete(entity);   
        }

        public async Task<Cotacao> Get(object id)
        {
            return await _cotacaoService.Get(id);   
        }

        public async Task<IEnumerable<Cotacao>> GetAll()
        {
            return await _cotacaoService.GetAll();
        }

        public async Task Save(Cotacao entity)
        {
            await _cotacaoService.Save(entity);
        }

        public async Task Update(Cotacao entity)
        {
            await _cotacaoService.Update(entity);   
        }
    }
}
