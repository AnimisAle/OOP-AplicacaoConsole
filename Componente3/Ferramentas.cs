using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Esse método só pode ser acessado dentro deste assembly componentes";
        }

        public string MetodoParaTodosQueUtilizarOAssembly()
        {
            return "Esse método é para todos";
        }

        public bool ValidarCPF(string cpf)
        {
            return true;
        }
    }
}
