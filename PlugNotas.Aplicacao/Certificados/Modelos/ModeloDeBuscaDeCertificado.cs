using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugNotas.Aplicacao.Certificados.Modelos
{
    public class ModeloDeBuscaDeCertificado
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string hash { get; set; }
        public string vencimento { get; set; }
        public string email { get; set; }
    }
}
