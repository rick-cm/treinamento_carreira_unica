using System;
using Model;

namespace treinamento_poo.Service
{

    public class ContaInvestimentoService : ContaService
    {
        private ContaInvestimento ci;
        public ContaInvestimentoService(ref ContaInvestimento ci)
        {
            this.ci = ci;
        }
        public void OperacaoResgate()
        {
            Console.Clear();
            Console.WriteLine("########## CONTA INVESTIMENTO - RESGATE ##########\n");
            Console.WriteLine();
            Console.WriteLine("Informe o valor que deseja resgatar: ");
            var valor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe a senha da conta: ");
            var senha = Int32.Parse(Console.ReadLine());
            if (validaSenha(this.ci.Senha, senha))
            {
                resgatar(valor);
            }
        }

        public void OperacaoAplicacao()
        {
            Console.Clear();
            Console.WriteLine("########## CONTA INVESTIMENTO - APLICACAO ##########\n");
            Console.WriteLine();
            Console.WriteLine("Informe o valor que deseja aplicar: ");
            var valor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe a senha da conta: ");
            var senha = Int32.Parse(Console.ReadLine());
            if (validaSenha(this.ci.Senha, senha))
            {
                aplicar(valor);
            }
        }

        public void VisualizarProjecao()
        {
            Console.Clear();
            Console.WriteLine("########## CONTA INVESTIMENTO - PROJEÇÃO ##########\n");
            double saldo = this.ci.Saldo;
            double rendimento = this.ci.RendimentoMensal;
            for(int i=1; i<13; i++){
                saldo += saldo*rendimento;
                Console.WriteLine("MES "+i+", SALDO: "+saldo.ToString("N2"));
            }
            pausa();
        }

        public void imprimeDados(){
            imprimeDadosConta((Conta)this.ci);
            Console.WriteLine("RENDIMENTO MENSAL: " + this.ci.RendimentoMensal + "\n");
            pausa();
        }

        private void resgatar(int valor){
            if (ValidaSaldo(valor, this.ci.Saldo))
            {
                this.ci.Saldo -= valor;
                imprimResgateRealizado(this.ci.Saldo);
            }
        }

        private void aplicar(int valor){
            this.ci.Saldo += valor;
            imprimeAplicacaoRealizada(this.ci.Saldo);
        }

    }
}