
namespace JogoVelha
{
    class Jogo 
    {
        // Contrição de todas as linhas do tabuleiro
        public string[] Linha1 = new string[3]{"1","2","3"};
        public string[] Linha2 = new string[3]{"4","5","6"};
        public string[] Linha3 = new string[3]{"7","8","9"};

        // Verifica se a jodaga escolhida pelo usuarios é valida 
        public void Jogada()
        {
            while(true)
            {
                System.Console.WriteLine("Onde dejesa jogar?");
                string x = Console.ReadLine();
                if (x == "1")
                {
                    if (Linha1[0] != "O" && Linha1[0] != "X")
                    {
                        Linha1[0] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else if (x == "2")
                {
                    if (Linha1[1] != "O" && Linha1[1] != "X")
                    {
                        Linha1[1] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else if (x == "3")
                {
                    if (Linha1[2] != "O" && Linha1[2] != "X")
                    {
                        Linha1[2] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else if (x == "4")
                {
                    if (Linha2[0] != "O" && Linha2[0] != "X")
                    {
                        Linha2[0] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else if (x == "5")
                {
                    if (Linha2[1] != "O" && Linha2[1] != "X")
                    {
                        Linha2[1] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else if (x == "6")
                {
                    if (Linha2[2] != "O" && Linha2[2] != "X")
                    {
                        Linha2[2] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else if (x == "7")
                {
                    if (Linha3[0] != "O" && Linha3[0] != "X")
                    {
                        Linha3[0] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else if (x == "8")
                {
                    if (Linha3[1] != "O" && Linha3[1] != "X")
                    {
                        Linha3[1] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else if (x == "9")
                {
                    if (Linha3[2] != "O" && Linha3[2] != "X")
                    {
                        Linha3[2] = "O";
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Jodaga invalida");
                        System.Console.WriteLine();
                    }
                }
                else
                {
                    System.Console.WriteLine("Jogada invalida");
                }
            }
        }
       
        // Mostra o tabuleiro atualizado  
        public void Print()
            {
                System.Console.WriteLine(Linha1[0]+" | "+ Linha1[1]+" | "+Linha1[2]);
                System.Console.WriteLine("-----------");
                System.Console.WriteLine(Linha2[0]+" | "+ Linha2[1]+" | "+Linha2[2]);
                System.Console.WriteLine("-----------");
                System.Console.WriteLine(Linha3[0]+" | "+ Linha3[1]+" | "+Linha3[2]);   
            }
       
        // Verifica se houve alguma ganhador ou se o jodo deu empate
        public int Verificacao()
        {
            int v=0;
            if (Linha1[0] == Linha1[1] && Linha1[1] == Linha1[2])
            {
                if (Linha1[1] == "O")
                {
                    v = 1;
                }
                else
                {
                    v = 2;
                }
            }
            else if (Linha2[0] == Linha2[1] && Linha2[1] == Linha2[2])
            {
                if (Linha2[1] == "O")
                {
                    v = 1;
                }
                else
                {
                    v = 2;
                }
            }
            else if (Linha3[0] == Linha3[1] && Linha3[1] == Linha3[2])
            {
                if (Linha3[1] == "O")
                {
                    v = 1;
                }
                else
                {
                    v = 2;
                }
            }
            else if (Linha1[0] == Linha2[0] && Linha2[0] == Linha3[0])
            {
                if (Linha1[0] == "O")
                {
                    v = 1;
                }
                else
                {
                    v = 2;
                }
            }
            else if (Linha1[1] == Linha2[1] && Linha2[1] == Linha3[1])
            {
                if (Linha1[1] == "O")
                {
                    v = 1;
                }
                else
                {
                    v = 2;
                }
            }
            else if (Linha1[2] == Linha2[2] && Linha2[2] == Linha3[2])
            {
                if (Linha1[2] == "O")
                {
                    v = 1;
                }
                else
                {
                    v = 2;
                }
            }
            else if (Linha1[0] == Linha2[1] && Linha2[1] == Linha3[2])
            {
                if (Linha1[0] == "O")
                {
                    v = 1;
                }
                else
                {
                    v = 2;
                }
            }
            else if (Linha1[2] == Linha2[1] && Linha2[1] == Linha3[0])
            {
                if (Linha1[2] == "O")
                {
                    v = 1;
                }
                else
                {
                    v = 2;
                }
            }
            else if(Linha1[0] != "1" && Linha1[1] != "2" && Linha1[2] != "3" && Linha2[0] != "4" && Linha2[1] != "5" && Linha2[2] != "6" && Linha3[0] != "7" && Linha3[1] != "8" && Linha3[2] != "9" )
            {
                v = 3;
            }
            return v;
        }

        //Ver as posibilidades de jogada da maquina 
        public void Oponente()
        {
            if (Linha1[0] == Linha1[1] && Linha1[2] != "X" && Linha1[2] != "O")
            {
                Linha1[2] = "X";
            }
            else if(Linha1[1] == Linha1[2] && Linha1[0] != "X" && Linha1[0] != "O")
            {
                Linha1[0] = "X";
            }
            else if(Linha1[0] == Linha1[2] && Linha1[1] != "X" && Linha1[1] != "O")
            {
                Linha1[1] = "X";
            }
            else if(Linha2[0] == Linha2[1] && Linha2[2] != "X" && Linha2[2] != "O")
            {
                Linha2[2] = "X";
            }
            else if(Linha2[1] == Linha2[2] && Linha2[0] != "X" && Linha2[0] != "O")
            {
                Linha2[0] = "X";
            }
            else if(Linha2[0] == Linha2[2] && Linha2[1] != "X" && Linha2[1] != "O")
            {
                Linha2[1] = "X";
            }
            else if(Linha3[0] == Linha3[1] && Linha3[2] != "X" && Linha3[2] != "O")
            {
                Linha3[2] = "X";
            }
            else if(Linha3[1] == Linha3[2] && Linha3[0] != "X" && Linha3[0] != "O")
            {
                Linha3[0] = "X";
            }
            else if(Linha3[0] == Linha3[2] && Linha3[1] != "X" && Linha3[1] != "O")
            {
                Linha3[1] = "X";
            }
            else if(Linha1[0] == Linha2[0] && Linha3[0] != "X" && Linha3[0] != "O")
            {
                Linha3[0] = "X";
            }
            else if(Linha2[0] == Linha3[0] && Linha1[0] != "X" && Linha1[0] != "O")
            {
                Linha1[0] = "X";
            }
            else if(Linha1[0] == Linha3[0] && Linha2[0] != "X" && Linha2[0] != "O")
                {
                    Linha2[0] = "X";
                }
            else if(Linha1[1] == Linha2[1] && Linha3[1] != "X" && Linha3[1] != "O")
                {
                    Linha3[1] = "X";
                }
            else if(Linha2[1] == Linha3[1] && Linha1[1] != "X" && Linha1[1] != "O")
            {
                Linha1[1] = "X";
            }
            else if(Linha1[1] == Linha3[1] && Linha2[1] != "X" && Linha2[1] != "O")
            {
                Linha2[1] = "X";
            }
            else if(Linha1[2] == Linha2[2] && Linha3[2] != "X" && Linha3[2] != "O")
            {
                Linha3[2] = "X";
            }
            else if(Linha2[2] == Linha3[2] && Linha1[2] != "X" && Linha1[2] != "O")
            {
                Linha1[2] ="X";
            }
            else if(Linha1[2] == Linha3[2] && Linha2[2] != "X" && Linha2[2] != "O")
            {
                Linha2[2] ="X";
            }
            else if(Linha1[0] == Linha2[1] && Linha3[2] != "X" && Linha3[2] != "O")
            {
                Linha3[2] = "X";
            }
            else if(Linha2[1] == Linha3[2] && Linha1[0] != "X" && Linha1[0] != "O")
            {
                Linha1[0] = "X";
            }
            else if(Linha1[0] == Linha3[2] && Linha2[1] != "X" && Linha2[1] != "O")
            {
                Linha2[1] ="X";
            }
            else if(Linha1[2] == Linha2[1] && Linha3[0] != "X" && Linha3[0] != "O")
            {
                Linha3[0] = "X";
            }
            else if(Linha2[1] == Linha3[0] && Linha1[2] != "X" && Linha1[2] != "O")
            {
                Linha1[2] = "X";
            }
            else if(Linha1[2] == Linha3[0] && Linha2[1] != "X" && Linha2[1] != "O")
            {
                Linha2[1] = "X";
            }
            else if(Linha2[1] != "X" && Linha2[1] !="O")
            {
                Linha2[1] = "X";
            }
            else
            {
                while(true)
                {
                    Random jogada = new Random();
                    int linha = jogada.Next(1,4);
                    if (linha == 1)
                    {
                        if (Linha1[0] != "O" && Linha1[0] != "X")
                        {
                            Linha1[0] = "X";
                            break;
                        }
                    }
                    else if (linha == 2)
                    {
                        if (Linha1[2] != "O" && Linha1[2] != "X")
                        {
                            Linha1[2] = "X";
                            break;
                        }
                    }
                    else if (linha == 3)
                    {
                        if (Linha3[0] != "O" && Linha3[0] != "X")
                        {
                            Linha3[0] = "X";
                            break;
                        }
                    }
                    else if(linha == 4)
                    {
                        if (Linha3[2] != "O" && Linha3[2] != "X")
                        {
                            Linha3[2] = "X";
                            break;
                        }
                    }
                }
            }

        }
    }
}
