using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {
        Pagamento pag;

        private int opcao;

        public ControlPagamento()

        {

            pag = new Pagamento();

            ModificarOpcao = -1;

        }// Fim do construtor

        // Metodo GetSet

        public int ModificarOpcao

        {

            get { return opcao; }

            set { opcao = value; }

        }// Fim do metodo GetSet

        public void Menu()

        {

            Console.Clear();

            Console.WriteLine("Escolha uma das opções abaixo: \n" + "1.Cadastrar Produto\n" + "2.Consultar um Produto\n" + "3.Atualizar um produto\n" + "4. Mudar Situacao\n");

            ModificarOpcao = Convert.ToInt32(Console.ReadLine());

        }//Fim do metodo menu



        public void Operacao()

        {

            do

            {

                Menu();// Mostrando o menu na tela

                switch (ModificarOpcao)

                {

                    case 0:

                        Console.WriteLine("Obrigado");

                        break;

                    case 1:

                        ColetarDados();

                        break;

                    case 2:

                        ConsultarDados();

                        break;

                    case 3:

                        Atualizar();

                        break;

                    case 4:

                        AlterarSituacao();

                        break;

                    default:

                        Console.WriteLine("Opção escolhida não é valida");

                        break;

                }//Fim do Switch

            } while (ModificarOpcao != 0);

        }



        //Criar um metodo para a solicitação de dados

        public void ColetarDados()

        {

            // Coletar dados

            Console.WriteLine("Informe um codigo: ");

            int codigo = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Faça uma breve descrição do Pagamento: ");

            string descricao = Console.ReadLine();



            Console.WriteLine("informar o ValorTotal do pagamento: ");

            double ValorTotal = Console.ReadLine();



            Console.WriteLine("Informe a FormaDepagamento do produto: ");

            int FormaDePagamento = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Informe a Data e hora de quando esse produto foi pago: ");

            DateTime DataHora = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Informe o Codigo do cartao: ");

            int CodCartao = Convert.ToDateTime(Console.ReadLine());



            Console.WriteLine("Informe a Bandeira do Cartao - Ativo | False - Inativo");

            int BandeiraCartao = Convert.ToBoolean(Console.ReadLine());

            //Cadastrar o Pagamento

            pag = new Pagamento (codigo, descricao, ValorTotal, FormaDePagamento, DataHora,CodCartao, BandeiraCartao);

            Console.WriteLine("Dado Registrado!");

        }// Fim do ColetarDados

        //Consultar

        public void ConsultarDados()

        {

            Console.WriteLine("\n\n\nInforme o codigo do produto que deseja consultar: ");

            int codigo = Convert.ToInt32(Console.ReadLine());

        }// Fim do metodo



        //Atualizar

        public void Atualizar()

        {

            // Atualizar Produto

            Console.WriteLine("\n\nInforme o codigo do produto que deseja atualizar");

            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regra abaixo: \n"
                + "1.Nome\n"
                + "2.Descrição\n"
                + "3.ValorTotal\n"
                + "4.FormaDePagamento\n"
                + "5.DataHora \n"
                + "6.CodCartao \n"
                + "7.BandeiraCartao");

            short campo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o novo dado: ");

            string novoDado = Console.ReadLine();

            // Chamar o metodo de atualização

            prod.AtualizarProduto(codigo, campo, novoDado);

            Console.WriteLine("Alterado!");

        }// Fim do Atualizar


        //Alterar situação
        public void AlterarSituacao()
        {

            Console.WriteLine("Informe o codigo do produto que deseja alterar o status: ");
            String novoDado = Console.ReadLine();

            //Chamar o metodo Alterar a situcao

            prod.AtualizarProduto(codigo, campo, novoDado);
            Console.WriteLine("Alterado!");

        }// Fim do Metodo
    }// Fim da Classe

}// Fim do projeto


    }
    }
}
