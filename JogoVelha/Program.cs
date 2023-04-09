
namespace JogoVelha
{
    class Program
    {
        static void Main(string[] args) 
        {
            Partida partida = new Partida(); // Inicia o placar do jogo
            while(true)
            {
                Jogo jogo = new Jogo(); // Inicia o tabuleiro do joo
                while (true)
                {
                    jogo.Print(); //Escreve o tabuleiro
                    jogo.Jogada(); //Permite o usuario jogar
                    if (jogo.Verificacao() != 0)// Verifica se tem um ganhador
                    {
                        break;
                    }
                    jogo.Oponente();// A maquina faz a sua jogada
                    if (jogo.Verificacao() != 0)
                    {
                        break;
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();
                System.Console.WriteLine("====================");
                jogo.Print(); // Escreve o tabulerio final
                if (jogo.Verificacao() == 1)//Verifica se o usuario ganhou
                {
                    System.Console.WriteLine("Vc venceu!");
                }
                else if(jogo.Verificacao() == 2)//Verifica se a maquina ganhou
                {
                    System.Console.WriteLine("Vc perdeu!");
                }
                else//Verifica se foi empate
                    {
                    System.Console.WriteLine("Deu velha!");
                    }
                System.Console.WriteLine();
                partida.Contagem(jogo.Verificacao());//Verifica o resultado da partida
                if (partida.Rejogar() == 0) //Verifica se o usuario quer jogar novamente
                {
                    System.Console.WriteLine(partida);
                    break;
                }
                else
                {
                    System.Console.WriteLine("//////////////////////////////////");
                    System.Console.WriteLine("           Novo Jogo!");
                    System.Console.WriteLine("//////////////////////////////////");
                }

            
            }
        }
    }
}
