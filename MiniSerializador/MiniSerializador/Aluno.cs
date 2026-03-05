using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSerializador
{
    public class Aluno
    {
        public string Nome { get; set; }
        public AnoEscolar Ano { get; set; }
        public DateTime DataNascimento { get; set; }
        [Ocultar]
        public string Documento { get; set; }
        public Endereco Endereco { get; set; }
    }

}
