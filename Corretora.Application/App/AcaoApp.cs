using Corretora.Application.Interfaces;
using Corretora.Domain.Core;
using Corretora.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corretora.Application.App
{
    public class AcaoApp : IAcaoApp
    {
        private readonly IAcaoService _acaoService;

        public AcaoApp(IAcaoService acaoService)
        {
            _acaoService = acaoService;
        }

        public async Task Delete(Acao entity)
        {
            await _acaoService.Delete(entity);
        }

        public async Task<Acao> Get(object id)
        {
            return await _acaoService.Get(id);
        }

        public async Task<IEnumerable<Acao>> GetAll()
        {
            return await _acaoService.GetAll();   
        }

        public async Task Save(Acao entity)
        {
            await (_acaoService.Save(entity));   
        }

        public async Task Update(Acao entity)
        {
            await _acaoService.Update(entity);  
        }
    }
}
