using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    // A Implementation define a interface para todas as classes implementadoras.
    // Não precisa ter relação com a interface Abstraction, podendo ser completamente diferente.
    // Usualmente a interface disponibiliza apenas operações primitivas, enquanto a Abstração
    // define operações mais complexas, baseadas nessas primitivas.
    public interface IImplementation
    {
        string OperationImplementation();
    }
}
