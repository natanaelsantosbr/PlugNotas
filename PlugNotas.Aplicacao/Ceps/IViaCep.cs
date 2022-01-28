using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugNotas.Aplicacao.Ceps
{
    public interface IViaCep
    {
        [Get("/{cep}/json")]
        Task<CepResponse> GetCep(string cep);
    }
}
