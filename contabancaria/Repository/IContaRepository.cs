using contabancaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabancaria.Repository
{
    public interface IContaRepository
    {
        //métodos crud
        public void ProcurarPorN(int numero);
        public void ListarTodas();
        public void Cadastrar(Conta conta);
        public void Atualizar(Conta conta);
        public void Deletar(int numero);

        //métodos bancários
        public void Sacar(int numero, decimal valor);
        public void Depositar(int numero, decimal valor);
        public void transferir(int numeroOrigem, int numeroDestino, decimal valor);
    }
}
