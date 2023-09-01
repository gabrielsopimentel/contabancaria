using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabancaria.Model
{
    public class ContaPoupanca : Conta
    {
        private int aniversario;
        private decimal limite;
        public ContaPoupanca(int numero, int agencia, int tipo, string titular, decimal saldo, int aniversario, decimal limite) : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }

        public int GetAniversario() { return aniversario; }
        public void SetAniversario(int aniversario) { this.aniversario = aniversario; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Aniversário: {this.aniversario}");
        }

        public override bool Sacar(decimal valor)
        {
            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("Saldo insuficente");
                return false;
            }

            this.SetSaldo(this.GetSaldo() - valor);
            return true;
        }
    }
}
