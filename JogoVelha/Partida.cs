
namespace JogoVelha
{
    class Partida
    {
        // Possibilidades de resultados do jogo
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public int Empates { get; set; }

        //Contar o placar de vitorias, derrotas e empates
        public void Contagem(int resultado)
            {
                    if (resultado == 1)
                    {
                        Vitorias++;
                    }
                    else if (resultado == 2)
                    {
                        Derrotas++;
                    }
                    else
                    {
                        Empates++;
                    }
            }

        //Vetifica se o usuario quer jogar novamente 
        public int Rejogar()
            {
            int v = 0;
            while(true)
            {
                System.Console.Write("Deseja jogar novamente [S/N]: ");
                string x = Console.ReadLine().ToUpper();
                if (x == "S")
                {
                    v = 1;
                    break;
                }
                else if(x == "N")
                {
                    v = 0;
                    break;
                }
                else
                {
                    System.Console.WriteLine("Opição invalida");
                    System.Console.WriteLine();
                }
            } 
            return v;
            }    

        //Vai escrever o placar no final do jogo
        public override string ToString()
         {
         return "Vitorias:  "+Vitorias+" / Derrotas: "+ Derrotas +" / Velhas: "+ Empates;
           
         }
    
    
    }
}