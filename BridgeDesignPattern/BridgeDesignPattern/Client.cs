using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class Client
    {
        // Exceto pela fase de inicialização, onde um objeto é relacionado
        // a um objeto específico de Implementação, o código do cliente deveria
        // depender apenas da classe Abstrata. Assim, o código d ocliente
        // pode suportar qualquer combinação Abstração - Implementação
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}
