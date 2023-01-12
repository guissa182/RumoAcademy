using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5.Entidades
{
    internal class Fluxo
    {
        public Cliente ExecutarCadastro()
        {
            SistemaCadastro sistemaCadastro = new SistemaCadastro();
            Cliente cliente = sistemaCadastro.CadastrarCliente();
            return cliente;
        }
        public void ExecutarListarClientes(List<Cliente> clientes)
        {
            SistemaCadastro sistemaCadastro = new SistemaCadastro();
            sistemaCadastro.ListarClientes(clientes);
        }
        public void ExecutarBuscarCliente(string cpf, List<Cliente> clientes)
        {
            SistemaCadastro sistemaCadastro = new SistemaCadastro();
            sistemaCadastro.BuscarCliente(cpf, clientes);
        }
        public void ExecutarBuscaAniversariantes(List<Cliente> clientes)
        {
            SistemaCadastro sistemaCadastro = new SistemaCadastro();
            sistemaCadastro.BuscaAniversariantes(clientes);
        }
    }
}
