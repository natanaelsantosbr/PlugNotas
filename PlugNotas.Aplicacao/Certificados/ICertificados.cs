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
        /// <summary>
        /// Cadastre um certificado digital e vincule a sua Empresa, para que possa iniciar a emissão de notas. 
        /// Quando houver a necessidade do compartilhamento do certificado digital (matriz/filial), não é necessário
        /// subir várias vezes o mesmo certificado, um mesmo ID pode ser vinculado a diversas empresas.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="modelo"></param>
        /// <returns></returns>
        [Multipart]
        [Post("/certificado")]
        Task CadastrarAsync([Header("x-api-key")] string apiKey,  ModeloDeCadastroDeCertificado modelo);

        /// <summary>
        /// Lista todos os certificados vinculados a sua organização.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        [Get("/certificado")]
        Task<ApiResponse<List<ModeloDeBuscaDeCertificado>>> BuscarTodosAsync([Header("x-api-key")] string apiKey);

        /// <summary>
        /// Utilize para buscar os dados de um certificado específico já cadastrado
        /// </summary>
        /// <param name="idCertificado"></param>
        /// <returns></returns>
        [Get("/certificado/{idCertificado}")]
        Task<ApiResponse<ModeloDeBuscaDeCertificado>> BuscarPorIdAsync([Header("x-api-key")] string apiKey, string idCertificado);

    }
}
