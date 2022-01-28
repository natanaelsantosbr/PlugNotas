using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugNotas.Aplicacao.Certificados.Modelos
{
    public class ModeloDeRetornoDeCadastroDeCertificado
    {
        public ModeloDeRetornoDeCadastroDeCertificado()
        {
            this.data = new Data();
        }

        public string message { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
    }
}
