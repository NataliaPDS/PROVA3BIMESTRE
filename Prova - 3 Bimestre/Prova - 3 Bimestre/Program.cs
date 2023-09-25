using Prova___3_Bimestre;

public class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> fun = new List<Funcionario>();
        List<Medico> med = new List<Medico>();
        List<Administrativo> admin = new List<Administrativo>();    
        while (true)
        {
            Console.WriteLine("Escolha uma destas opções abaixo: ");
            Console.WriteLine("1 - Cadastrar Funcionario");
            Console.WriteLine("2 - Cadastrar Medico");
            Console.WriteLine("3 - Cadastrar Administrativo");
            Console.WriteLine("4 - Fechar");
            Console.WriteLine("Digite o número da opção escolhida: ");
            int opcaoE = Convert.ToInt32(Console.ReadLine());

            if (opcaoE == 1)
            {
                
              
                Funcionario a = new Funcionario();
                Console.WriteLine("Informe seu nome: ");
                a.Nome = Console.ReadLine();
                Console.WriteLine("Informe seu cpf: ");
                a.Cpf = Console.ReadLine();
                Console.WriteLine("Informe seu numero de matricula: ");
                a.Matricula = Console.ReadLine();
                Console.WriteLine("Informe sua data de nascimento: ");
                a.DataNasc = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Informe seu sexo: ");
                a.Sexo = Console.ReadLine();
                Console.WriteLine("Informe o valor do seu salário: ");
                a.Salario = Convert.ToDouble(Console.ReadLine());
                fun.Add(a);

            }
            else if (opcaoE == 2)
            {
                Medico b = new Medico();
                Console.WriteLine("Informe seu nome: ");
                b.Nome = Console.ReadLine();
                Console.WriteLine("Informe seu cpf: ");
                b.Cpf = Console.ReadLine();
                Console.WriteLine("Informe seu numero de matricula: ");
                b.Matricula = Console.ReadLine();
                Console.WriteLine("Informe sua data de nascimento: ");
                b.DataNasc = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Informe seu sexo: ");
                b.Sexo = Console.ReadLine();
                Console.WriteLine("Informe o valor do seu salário: ");
                b.Salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe seu CRM: ");
                b.CRM = Console.ReadLine();
                Console.WriteLine("Informe seu valor de trabalho extra: ");
                b.ValorExtra = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe sua especialidade: ");
                b.Especialidade = Console.ReadLine();

                med.Add(b);
            }
            else if (opcaoE == 3)
            {

                Administrativo c = new Administrativo();
                Console.WriteLine("Informe seu nome: ");
                c.Nome = Console.ReadLine();
                Console.WriteLine("Informe seu cpf: ");
                c.Cpf = Console.ReadLine();
                Console.WriteLine("Informe seu numero de matricula: ");
                c.Matricula = Console.ReadLine();
                Console.WriteLine("Informe sua data de nascimento: ");
                c.DataNasc = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Informe seu sexo: ");
                c.Sexo = Console.ReadLine();
                Console.WriteLine("Informe o valor do seu salário: ");
                c.Salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe sua função: ");
                c.Funcao = Console.ReadLine();
                
                admin.Add(c);
            }
            else if (opcaoE == 4)
            {
                break;
            }
            foreach (Funcionario a in fun)
            {
                Console.WriteLine(a);
            }
            foreach (Medico b in med)
            {
                Console.WriteLine(b);
            }
            foreach (Administrativo c in admin)
            {
                Console.WriteLine(c);
            }

        }






    }
}