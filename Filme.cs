using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{

    class Filme
    {  /* Encapsulamento ele é responsavel por dá segurança no código,
     Public -> permite que acesse a propriedade fora da classe, dá pra usar em Atributo e função.
 */
        public string nome;
        public string desc;
        public int ano; // Atributos
        public string studio;
        public List<string> atores = new List<string>();
        /* Private -> Só consegue acessar a variavel dentro do aruivo da classe.
        dá mais segurança para fazer alteraçoes futuramente.*/


        // construtores -
        public Filme(string nome, string desc, int ano, string studio) //-> Parametro
        {
            this.nome = nome;
            this.desc = desc; //com "this" o atributo recebe o valor do parametro.
            this.ano = ano;
            this.studio = studio;
        }




        public void Start() // - Função dentro de classe se chama metódo.
        {
            Console.WriteLine(atores);
            Console.WriteLine("Abrindo..." + nome);
        }
        public void Pausar()
        {
            Console.WriteLine("Carregando...");
        }


        // Metódos encapsuladores para garantir a integridade do programa
        // * Validação para não acrescentar nomes com valor nulo.
        public void AddAtor(string nome)
        {
            if (nome != null)
            {
                atores.Add(nome);
            }
        }

            public void ExibirAtores()
            {  foreach(string ator in atores)
                Console.WriteLine(ator);
            }
        }
    }

// 


