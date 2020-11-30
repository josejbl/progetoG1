using System;

namespace Progeto_de_gerenciamemto
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] produtos = new string[10];
            float[] preco = new float[10];
         

            //menu
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("---- Progeto de gerenciamento ----");
            Console.WriteLine("----------------------------------");

            bool[] emPromocao =new bool[10] ;

            
             //Criar menu
            int escolha;
            int contador = 0;
            do
            {

                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecionar uma opção");
                Console.WriteLine("[1] - Cadastrar o produto");
                Console.WriteLine("[2] - Listar prduto");
                Console.WriteLine("[3] - Sair");
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        //Cadastrar a Passagem
                            string resposta;

                            do
                            {
                                if(contador<5)
                                {
                                    Console.WriteLine($"Digite o nome do {contador+1}°Produto");
                                    produtos[contador] = Console.ReadLine();
                                   
                                   Console.WriteLine($"Digite o Preço {contador+1}°Preco");
                                    preco[contador] = float.Parse(Console.ReadLine());

                                    Console.WriteLine($"Digite true ou false {contador+1}°Promocao");
                                    emPromocao[contador] =bool.Parse(Console.ReadLine());
                                    
                                }else{
                                    Console.WriteLine("Produto sem desconto");
                                    break;

                                }
                                Console.WriteLine("Gostaria de cadastrar um novo produto?/n");
                                resposta = Console.ReadLine();
                            } while (resposta == "s");
                        break;
                    case 2:
                        
                                for (var i = 0; i < 10; i++)
                                {
                                    Console.WriteLine($"produto; {produtos[i]}");
                                    Console.WriteLine($"preco;{preco[i]}");
                                    Console.WriteLine($"Em promocao;{emPromocao[i]}");
                                    
                                }
                                break;
                    case 0:
                        //Sair
                        Console.WriteLine("Obrigado Volte sempre!");
                        break;
                    default:
                         Console.WriteLine("Opção invalida");
                        break;
                }
                
            } while (escolha != 0 );


                //fim efetuar login
        }
    }
}
