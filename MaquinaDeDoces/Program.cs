using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    internal class Program
    {
        static void Main(string[] args)
        {
        ControlProtudo controlProd = new ControlProtudo();

            //Chamar o Metodo principal
            controlProd.Operacao();

            Console.ReadLine(); //Manter a jamela aberta

        } //Fim do projeto
    } //Fim da classe
}//fim dp projeto
