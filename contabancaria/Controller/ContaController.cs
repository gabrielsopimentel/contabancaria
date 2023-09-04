using contabancaria.Model;
using contabancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabancaria.Controller
{
    internal class ContaController : IContaRepository
    {
        private readonly List<Conta> listaContas = new();
        int numero = 0;

        //métodos crud
        public void Atualizar(Conta conta)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Conta conta)
        {
            listaContas.Add(conta);
            Console.WriteLine($"A conta número: {conta.GetNumero()} foi criada com sucesso!");
        }

        public void Deletar(int numero)
        {
            throw new NotImplementedException();
        }


        public void ListarTodas()
        {
            foreach (var conta in listaContas)
            {
                conta.Visualizar();
            }
        }

        public void ProcurarPorN(int numero)
        {
            throw new NotImplementedException();
        }

        //métodos bancários
        public void Sacar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }
        public void Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            throw new NotImplementedException();
        }

        //métodos auxiliares
        public int GerarNumero()
        {
            return ++numero;
        }
    }
}
