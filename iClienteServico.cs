using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S05_Exercício;

   public interface IClienteServico
{
    Cliente BuscarClientePorNumeroDeConta(int numeroConta);
    void CriarConta(string tipoConta);
    void ExibirClientes();
}
