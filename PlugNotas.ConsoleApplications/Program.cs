using PlugNotas.Aplicacao.Ceps;
using PlugNotas.Aplicacao.Certificados;
using PlugNotas.Aplicacao.Github;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugNotas.ConsoleApplications
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hubCertificado = RestService.For<ICertificados>("https://api.sandbox.plugnotas.com.br");
            var resultado = await hubCertificado.BuscarAsync("2da392a6-79d2-4304-a8b7-959572c7e44d");


            if (resultado != null)
            {

            }

        }
    }
}
