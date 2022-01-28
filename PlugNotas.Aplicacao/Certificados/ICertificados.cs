using PlugNotas.Aplicacao.Certificados.Modelos;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugNotas.Aplicacao.Certificados
{
    public interface ICertificados
    {
        [Multipart]
        [Post("/certificado")]
        Task CadastrarAsync([Header("x-api-key")] string apiKey, ModeloDeCadastroDeCertificado modelo);

        [Get("/certificado")]
        Task<List<ModeloDeBuscaDeCertificado>> BuscarAsync([Header("x-api-key")] string apiKey);
    }
}
