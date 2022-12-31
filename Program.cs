using POO2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Program
    {
        /*static void Main(string[] args)
        {
           //no construtor colocamos os dados dentro do objeto.
           Filme hsm = new Filme("High School Musical", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2006, "Salt Lake City");
            Console.WriteLine(hsm.nome);
            Console.WriteLine(hsm.ano);
            Console.WriteLine(hsm.desc);
            Console.WriteLine(hsm.studio);
           

            hsm.AddAtor("Zac Efron");
            hsm.AddAtor(null);
            hsm.ExibirAtores();
            Console.ReadLine();
        }
    }
}*/









        // Herança no CSharp
        /*   static void Main(string[] args)
           { // filho
               Aluno a = new Aluno();
               a.nome = "Victor";
               a.email = "Victir@laaa.com";
               a.password = "123";
               a.turno = "1235";
               a.Logar();

               a.Exibir();

               //filho
               Zelador B = new Zelador();
               B.nome = "Anderson";
               B.email = "aander@laaa.com";
               B.password = "1235";
               B.periodo = "integral";
               B.Logar();
               B.Exibir();


               Console.ReadLine();
           }
       }
   }*/



        static void Main(string[] args)
        { // Polimofirsmo  - Muitas formas
            Usuario Aluno1 = new Aluno("Miguel", "Miguel@jkl.com", "532", "Noturno");
            Usuario Zelador1 = new Zelador("Daniel", "daniel@jkl.com", "4555");



            Aluno1.Exibir();
            Zelador1.Exibir();

            // como acessar os dados de um Aluno/Zelador ue está salvo dentro da variavel do tipo usuario.
            Console.WriteLine(((Aluno)Aluno1).email);
            //  converte a variavel pai "usuário" para o tipo filho "aluno".


            //Polimofirsmo Estático  ou sobrecarga - 
            //  logar(string, string)
            Aluno1.Logar("email", "56556");

        }
    }
}

//Polimorfismo Dinâmico ou Sobreposição.
// public virtual void Exibir() -> Colocando a palavra chave "virtual", voce fala pro Csharp ue esse metodo pode ser sobreescrito nas classes filhas da classe pai.
//public override void Exibir() { base.exibir} -> Override - significa sobrepor - colocar na classe filha.

// Herança no CSharp com construtor

/*  Aluno a = new Aluno("Matutino","hshsh@jdks.com", "gshsj", "hshshs");
a.Logar();
a.Exibir();

//filho
Zelador B = new Zelador("Edson", "hshsh@jdks.com", "gshsj");

B.Logar();
B.Exibir();


Console.ReadLine();
}
}
}*/






