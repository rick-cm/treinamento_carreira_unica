using System;
using Model;

namespace treinamento_poo.Service
{

    public class ContaService
    {

        public bool validaSenha(int senha, int senhaFornecida)
        {
            if (senha == senhaFornecida)
            {
                return true;
            }
            else
            {
                imprimeSenhaIncorreta();
                return false;
            }
        }

        public bool ValidaSaldo(int valor, double saldo)
        {
            if (valor > saldo)
            {
                imprimeSaldoInsuficiente(saldo, valor);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void imprimeDadosConta(Conta conta){
            Console.Clear();
            Console.WriteLine("\n#############################");
            Console.WriteLine("###### DADOS DA CONTA #######");
            Console.WriteLine("#############################" + "\n");
            Console.WriteLine("TITULAR: "+conta.Titular);
            Console.WriteLine("BANCO: "+conta.Banco);
            Console.WriteLine("AGENCIA: "+conta.Agencia);
            Console.WriteLine("NUMERO: "+conta.Numero);
            Console.WriteLine("SALDO: "+conta.Saldo);
            Console.WriteLine("SENHA: "+conta.Senha);
        }

        public void imprimeSenhaIncorreta(){
            Console.Clear();
            Console.WriteLine("\n#############################");
            Console.WriteLine("###### SENHA INCORRETA ######");
            Console.WriteLine("#############################" + "\n\n");
            pausa();
        }

        public void imprimeSaqueRealizado(double saldo)
        {
            Console.Clear();
            Console.WriteLine("\n###############################");
            Console.WriteLine("# SAQUE REALIZADO COM SUCESSO #");
            Console.WriteLine("###############################" + "\n");
            Console.WriteLine("SALDO DA CONTA: " + saldo + "\n");
            pausa();
        }

        public void imprimeDepositoRealizado(double saldo)
        {
            Console.Clear();
            Console.WriteLine("\n##################################");
            Console.WriteLine("# DEPOSITO REALIZADO COM SUCESSO #");
            Console.WriteLine("##################################" + "\n");
            Console.WriteLine("SALDO DA CONTA: " + saldo + "\n");
            pausa();
        }

        public void imprimeTransferenciaRealizada(ContaCorrente cc, string pix, int valor)
        {
            Console.Clear();
            Console.WriteLine("\n#######################################");
            Console.WriteLine("# TRANSFERENCIA REALIZADA COM SUCESSO #");
            Console.WriteLine("#######################################" + "\n");
            Console.WriteLine("CHAVE PIX ORIGEM: " + cc.ChavePix);
            Console.WriteLine("CHAVE PIX DESTINO: " + pix);
            Console.WriteLine("VALOR TRANSFERIDO: " + valor);
            Console.WriteLine("SALDO ATUAL DA CONTA: " + cc.Saldo + "\n");
            pausa();
        }

        public void imprimeAplicacaoRealizada(double saldo)
        {
            Console.Clear();
            Console.WriteLine("\n##################################");
            Console.WriteLine("# APLICACAO REALIZADA COM SUCESSO #");
            Console.WriteLine("##################################" + "\n");
            Console.WriteLine("SALDO DA CONTA: " + saldo + "\n");
            pausa();
        }

        public void imprimResgateRealizado(double saldo)
        {
            Console.Clear();
            Console.WriteLine("\n##################################");
            Console.WriteLine("# RESGATE REALIZADO COM SUCESSO #");
            Console.WriteLine("##################################" + "\n");
            Console.WriteLine("SALDO DA CONTA: " + saldo + "\n");
            pausa();
        }

        public void imprimeSaldoInsuficiente(double saldo, int valor)
        {
            Console.Clear();
            Console.WriteLine("\n#############################");
            Console.WriteLine("#### SALDO INSULFICIENTE ####");
            Console.WriteLine("#############################" + "\n");
            Console.WriteLine("#### SALDO DISPONIVEL: " + saldo);
            Console.WriteLine("#### VALOR REQUISITADO: " + valor + "\n");
            pausa();
        }

        public void pausa()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}