using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class OperacoesComArray
    {
        static void Main(string[] args)
        {
            /*Nesta aula vamos procurar um elemento dentro do array */
            string aulaIntro = "Introdução as coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            string[] aulas = new string[]
            { aulaIntro,
              aulaModelando,
              aulaSets
            };

            foreach (var aux in aulas){
                Console.WriteLine($"A aula modelando está no indice {Array.IndexOf(aulas, aulaModelando)}");
                Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));
                Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

                // invertendo modifica a ordem do array
                Array.Reverse(aulas);
                Console.WriteLine(aulas);

                // modificar o tamanho do array

                Array.Resize(ref aulas, 2);

                Console.WriteLine(aulas);
            }
        }
    }
}
