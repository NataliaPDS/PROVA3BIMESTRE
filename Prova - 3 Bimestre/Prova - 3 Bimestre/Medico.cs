using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___3_Bimestre
{
    internal class Medico:Funcionario
    {
        public string CRM { get; set; }
        public double ValorExtra { get; set; }

        public string Especialidade { get; set; }
       
        public Medico() 
        { 
        }
        public Medico(string cRM, double valorExtra, string especialidade, string nome, string cpf, string matricula, DateTime datanasc, string sexo, double salario )
        :base(nome,cpf, matricula, datanasc, sexo, salario  )
         
        {
            CRM = cRM;
            ValorExtra = valorExtra;
            Especialidade = especialidade;
        }   
        public void CalcSalario(double salario)
        {
            double porcentagem = (salario * 20) / 100; //1000 = 200
            double soma = salario + porcentagem; //1000 + 200 
            Console.WriteLine($"Salario = {soma}"); //1200
        }
    }
}
