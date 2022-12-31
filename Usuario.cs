using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace POO2
//{   HERANÇA 
    /*class Usuario // Classe pai, no Csharp só pode ter uma classe pai.
    {
        public string nome;
        public string email;
        public string password;
        protected string Teste;
// Modificador de acesso - Protected - Exemplo se voce cria uma na classe pai, ela irá funcionar tanto na classe pai como nas filhas.

        public void Logar()
        {
            Console.WriteLine("Logando...");
        }

        public void Exibir()
        {
            Console.WriteLine($"Email:{email}");
            Console.WriteLine($"Nome:{nome}");
            Console.WriteLine($"Senha:{password}");
        }





    }  //  Filho - Pai
    class Aluno : Usuario // os : significa "herda" - Aluno herda de usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";

    }    // filho - pai
    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();
        public string periodo = "Integral";

    }

}

}*/

    // dá pra fazer com construtor - Herança com construtor

  
    { 
    class Usuario // Classe pai, no Csharp só pode ter uma classe pai.
    {
        public string nome;
        public string email;
        public string password;
        

        public Usuario(string nome, string email, string password)
        {
            this.nome = nome;
            this.email = email;
            this.password = password;
        }

        public void Logar()
        {
            Console.WriteLine("Logando...");
        } // polimofirsmo de sobrecarga - é basicamente voce ter multiplas versoes de um método.
        // as assinaturas não podem ser iguais, exemplo: Logar(string)  e Logar(string) 
        public void Logar(string email, string senha)
        {
            Console.WriteLine("Logando com email e senha...");
        }
       

        public void Exibir()
        {
            Console.WriteLine($"Email:{email}");
            Console.WriteLine($"Nome:{nome}");
            Console.WriteLine($"Senha:{password}");
        }





    }  //  Filho - Pai
    class Aluno : Usuario // os : significa "herda" - Aluno herda de usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";

        public Aluno(string nome, string email, string password, string turno) : base(nome, email, password) 
            // Base é uma palavra reservada do csharp ue faz referencia a classe pai
        {
            this.turno = turno;
        }
    }  
    
    
    
    // filho - pai
    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();
        public string periodo = "Integral";

        public Zelador(string nome, string email, string password) : base(nome, email, password)
        {
            this.periodo = periodo;
        }
    }

}




