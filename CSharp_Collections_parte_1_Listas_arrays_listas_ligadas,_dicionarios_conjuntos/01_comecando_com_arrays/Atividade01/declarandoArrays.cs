

//namespace Atividade01
//{
//    class declarandoArrays
//    {
//        static void Main(string[] args)
//        {
//            /*Coleção Array*/

//            string aulaIntro = "Introdução as coleções";
//            string aulaModelando = "Modelando a Classe Aula";
//            string aulaSets = "Trabalhando com Conjuntos";

//            //Maneira especial de declara um array existe no C#

//            string[] aulas = new string[]
//            { aulaIntro,
//              aulaModelando, 
//              aulaSets
//            };

//            // Indice igual sua posição -1 
//            // Primeira forma de declara um array quando já sei que elementos ele tem 

//            // A segunda forma é declarar explicitamente a quantidade de itens que vão ter no array

//            string[] aulasExplicitamente = new string[3];
//            aulasExplicitamente[0] = aulaIntro;
//            aulasExplicitamente[1] = aulaModelando;
//            aulasExplicitamente[2] = aulaSets;

//            Console.WriteLine(aulasExplicitamente);

//            // Forma de percorrer o array 

//            foreach (var x in aulasExplicitamente){
//                Console.WriteLine(x);
//            }

//            for (var indice = 0; indice < aulasExplicitamente.Length; indice++)
//            {
//                Console.WriteLine(aulasExplicitamente [indice]);

//                aulaIntro = "Trabalhando com array";

//                aulasExplicitamente[0] = aulaIntro;

//                Console.WriteLine(aulasExplicitamente[indice]);
//            }
//        }
//    }
//}