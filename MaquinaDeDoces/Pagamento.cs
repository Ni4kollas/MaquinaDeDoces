using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        //Definição das variaveis
        private int codigo;
        private string descricao;
        private double valorTotal;
        private int formaDePagamento;
        private DateTime datahora;
        private int codCartao;
        private int bandeiraCartao;

        //Metodo concuido
        public Pagamento()
        {
            ModificarCodigo             =    0;
            ModificarDescricao          =   "";
            ModificarValorTotal         =   0 ;                          // isso é um construtor sem parametro pois eu dei valor as variaveis
            ModificarFormaDePagamento   =   0 ;
            ModificarDataHora           =   new DateTime(); //0000/00/00 00:00:00
            ModificarCodCartao          =   0;
            ModificarBandeiraCartao     =   0;
         
        }//Fim do metodo construtor

        // Metodo Construtor com parametro

        public Pagamento(int codigo, string descricao, double valorTotal, int formaDePagamento, DateTime datahora, int codCartao, int bandeiraCartao)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;
            ModificarValorTotal = valorTotal;                   // O this ele faz referencia para o codigo ai ele entende que um lado e variavel e o outro é parametro
            ModificarFormaDePagamento = formaDePagamento;
            ModificarDataHora = datahora;
            ModificarCodCartao = codCartao;
            ModificarBandeiraCartao = bandeiraCartao;

        } // Fim do metodo construtor com parametro

        //Metodo get e set
        //Metodo de acesso e modificação

        public int ModificarCodigo
        {
            get
            { 
                return this.codigo;
                
            }//Fim do get / Retornar codigo

            set
            {
                this.codigo  = value; 
            }//Fim do set / Retornar codigo
        }//Fim do ModificarCodigo

        public string ModificarDescricao
        {
            get
            {
                return this.descricao;

            }// Fim do get / Retornar descricao

            set
            {
                this.descricao = value;
            }
        } // Fim ModificarDescricao

        public double ModificarValorTotal
        {
            get
            {
                return this.valorTotal;

            }//Fim do get / Retornar valorTotal

            set
            {
                this.valorTotal = value;
            }
        }//Fim ModificarValorTotal

        public int ModificarFormaDePagamento
        {
            get 
            { 
            return this.formaDePagamento;

            }//Fim do get / Retornar formaDepagamento

            set
            {
                this.formaDePagamento = value;
            }
        }//Fim de ModificarFormaDePagamento 

        public DateTime ModificarDataHora
        {
            get
            {
                return this.datahora;

            }//Fim do get / Retornar Datahora

            set
            {
                this.datahora = value;
            }
        }//Fim de ModificarDataHora

        public int ModificarCodCartao
        {
            get
            {
                return this.codCartao;

            }//Fim do get / Retornar Codcartao

            set
            {
                this.codCartao = value;
            }
        }//Fim de ModificarCodCartao

        public int ModificarBandeiraCartao
        {
            get
            {
                return this.bandeiraCartao;

            }//Fim do get / Retornar Bandeiracartao

            set
            {
                this.bandeiraCartao = value;
            }
        }//Fim de ModificarBandeiraCartao

            // Consultar Produto
            public string ConsultarPagamento(int codigo)
            {
                string msg = ""; //Criando uma variavel local



                if (ModificarCodigo == codigo)     // if quer dezer "se"
                {
                    msg = "\nCodigo: " + ModificarCodigo +
                    "\nDescricao: " + ModificarDescricao +
                    "\nFicarValorTotal: " + ModificarValorTotal +
                    "\nFormaDePagamento: " + ModificarFormaDePagamento +
                    "\nDataHora: " + ModificarDataHora +
                    "\nCodCartao: " + ModificarCodCartao +
                    "\nBandeiraCartao: " + ModificarBandeiraCartao;



                }
                else        // serve como "se nao"
                {
                    msg = "O código digitado não exixte!";
                }

                return msg;

            } // FIm do metodo

    }//Fim da classe
}//Fim do procedimento
