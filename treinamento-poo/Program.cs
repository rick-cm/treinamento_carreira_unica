using System;
using System.Collections.Generic;
using treinamento_poo.Service;
using Model;


namespace treinamento_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = true;
            ContaCorrente cc = new ContaCorrente()
            {
                Id = 0,
                Titular = "Rick Camelo",
                Banco = "CAIXA",
                Agencia = 0010,
                Numero = 1010,
                Saldo = 0,
                Senha = 2323,
                ChavePix = "000.000.000-00"
            };
            ContaInvestimento ci = new ContaInvestimento()
            {
                Id = 0,
                Titular = "Gabriel Ferreira",
                Banco = "Modal",
                Agencia = 0001,
                Numero = 2020,
                Saldo = 0,
                Senha = 2121,
                RendimentoMensal = 0.004
            };

            while (sair)
            {
                Console.Clear();
                Console.WriteLine(" ..::::: INTERNET BANKING :::::..");
                Console.WriteLine();
                Console.WriteLine("1 - Conta Corrente");
                Console.WriteLine("2 - Conta Investimento");
                Console.WriteLine("3 - Sair");

                var opcao = Console.ReadKey();

                switch (opcao.KeyChar)
                {
                    case '1':
                        contaCorrente(ref cc);
                        break;

                    case '2':
                        contaInvestimento(ref ci);
                        break;

                    case '3':
                        sair = false;
                        break;
                }
            }
        }

        private static void contaCorrente(ref ContaCorrente cc)
        {
            ContaCorrenteService service = new ContaCorrenteService(ref cc);
            Console.Clear();
            Console.WriteLine("########## CONTA CORRENTE ##########\n");
            Console.WriteLine();
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Consultar Dados");
            Console.WriteLine("5 - Voltar");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    service.OperacaoDeposito();
                    break;

                case '2':
                    service.OperacaoSaque();
                    // new ContaCorrenteService().OperacaoSaque();
                    break;

                case '3':
                    service.OperacaoTransferencia();
                    // cc = new ContaCorrenteService().OperacaoTransferencia(cc);
                    break;
                case '4':
                    service.imprimeDados();
                    // cc = new ContaCorrenteService().imprimeDados(cc);
                    break;
                case '5':
                    break;
            }
        }

        private static void contaInvestimento(ref ContaInvestimento ci)
        {
            // Exibe menu de opções para o usuário selecionar

            ContaInvestimentoService service = new ContaInvestimentoService(ref ci);
            Console.Clear();
            Console.WriteLine("########## CONTA INVESTIMENTO ##########\n");
            Console.WriteLine();
            Console.WriteLine("1 - Aplicacao");
            Console.WriteLine("2 - Resgate");
            Console.WriteLine("3 - Visualizar projeção");
            Console.WriteLine("4 - Consultar Dados");
            Console.WriteLine("5 - Voltar");

            // obtem a opção selecionada pelo usuário
            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    service.OperacaoAplicacao();
                    break;

                case '2':
                    service.OperacaoResgate();
                    break;

                case '3':
                    service.VisualizarProjecao();
                    break;
                case '4':
                    service.imprimeDados();
                    // cc = new ContaCorrenteService().imprimeDados(cc);
                    break;
                case '5':
                    break;
            }
        }

    }
}
