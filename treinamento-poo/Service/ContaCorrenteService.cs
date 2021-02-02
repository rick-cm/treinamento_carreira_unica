using System;
using Model;

namespace treinamento_poo.Service
{
    /// <summary>
    /// Nesta classe vamos manter todas as regras de negócio da nossa pequena aplicação
    /// </summary>

    public class ContaCorrenteService : ContaService
    {
        private ContaCorrente cc;
        public ContaCorrenteService(ref ContaCorrente cc)
        {
            this.cc = cc;
        }
        public void OperacaoSaque()
        {
            Console.Clear();
            Console.WriteLine("########## CONTA CORRENTE - SAQUE ##########\n");
            Console.WriteLine();
            Console.WriteLine("Informe o valor que deseja sacar: ");
            var valor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe a senha da conta: ");
            var senha = Int32.Parse(Console.ReadLine());
            if (validaSenha(this.cc.Senha, senha))
            {
                Sacar(valor);
            }
        }

        public void OperacaoDeposito()
        {
            Console.Clear();
            Console.WriteLine("########## CONTA CORRENTE - DEPOSITO ##########\n");
            Console.WriteLine();
            Console.WriteLine("Informe o valor que deseja depositar: ");
            var valor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe a senha da conta: ");
            var senha = Int32.Parse(Console.ReadLine());
            if (validaSenha(this.cc.Senha, senha))
            {
                Depositar(valor);
            }
        }

        public void OperacaoTransferencia()
        {
            Console.Clear();
            Console.WriteLine("########## CONTA CORRENTE - TRANSFERENCIA ##########\n");
            Console.WriteLine("Informe o Pix da Conta de destino: ");
            var pix = Console.ReadLine();
            Console.WriteLine("Informe o valor que deseja transferir: ");
            var valor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe a senha da conta: ");
            var senha = Int32.Parse(Console.ReadLine());
            if (validaSenha(this.cc.Senha, senha))
            {
                Transferir(pix, valor);
            }
        }

        public void imprimeDados()
        {
            imprimeDadosConta((Conta)this.cc);
            Console.WriteLine("CHAVE PIX: " + this.cc.ChavePix + "\n");
            pausa();
        }

        // criar os métodos Sacar, Depositar e Transferir como private

        private void Sacar(int valor)
        {
            if (ValidaSaldo(valor, this.cc.Saldo))
            {
                this.cc.Saldo -= valor;
                imprimeSaqueRealizado(this.cc.Saldo);
            }
        }

        private void Depositar(int valor)
        {
            this.cc.Saldo += valor;
            imprimeDepositoRealizado(this.cc.Saldo);
        }

        private void Transferir(string pix, int valor)
        {
            if (ValidaSaldo(valor, this.cc.Saldo))
            {
                this.cc.Saldo -= valor;
                imprimeTransferenciaRealizada(this.cc, pix, valor);
            }
        }
    }
}
