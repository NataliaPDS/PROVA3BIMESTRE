using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___3_Bimestre
{
    internal class Administrativo:Funcionario
    {

        public string Funcao { get; set; }

        public Administrativo() { }

        public Administrativo(string funcao, string nome, string cpf, string matricula, DateTime datanasc, string sexo, double salario)
        :base(nome, cpf, matricula, datanasc, sexo, salario )
        { 
          Funcao = funcao;
        }
        public void Calcular(double salario)
        {
              double ValeTransporte = 150;
               double ValeAlimentacao = (salario * 15) / 100; //150

            double soma = salario + ValeTransporte; //500 + 150 = 650
            double salario1 = soma + ValeAlimentacao;
            Console.WriteLine($"Salario = {salario1}"); //1300
        }
        
    }
}
