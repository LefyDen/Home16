using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home16
{
    class Program
    {
        static void Main(string[] args)
        {
            SSnake Hope = new SSnake();
            while (true)
            {
                if (Hope.Lose ==true)
                {
                    Console.WriteLine("You lose!");
                    break;

                }
                Hope.CircleAdd();
                Hope.PrintAll();
                Hope.NextMove();
                Console.WriteLine("\n/////////////////////////////");

            }

        }

    }
    class SSnake
    {
        int Snake = 1;
        bool LMuve = false;
        bool RMuve = false;
        bool UMuve = false;
        bool DMuve = true;
        public bool Lose = false;
        bool Randomize = false;
        Random rnd = new Random();
        int coordinateX = 5;
        int coordinateY = 5;

        List<int> LineX = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> LineY = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int foodX = 5;
        int foodY = 5;

        public void CircleAdd()
        {

            if (DMuve == true)
            {
                coordinateY = coordinateY+1;
                if (coordinateY<0 ^  coordinateY>=10)
                {
                   
                    Lose = true;
                }
            }
            else if (LMuve == true)
            {
                coordinateX = coordinateX-1;
                if (coordinateX < 0 ^ coordinateX >= 10)
                {
                   
                    Lose = true;
                }
            }
            else if (RMuve == true)
            {
                coordinateX = coordinateX +1;
                if (coordinateX < 0 ^ coordinateX >= 10)
                {
                   
                    Lose = true;
                }
            }
            else if (UMuve == true)
            {
                coordinateY = coordinateY -1;
                if (coordinateY < 0 ^  coordinateY >= 10)
                {
                   
                    Lose = true;
                }
            }

            if (Randomize == true)
            {
                foodX = rnd.Next(1, 10); 
                foodY = rnd.Next(1, 10);
                if (coordinateX == foodX && coordinateY== foodY)
                {
                     foodX = rnd.Next(1, 10);
                    foodY = rnd.Next(1, 10);
                }
                else Randomize = false;
            }
        }
        public void PrintAll()
        {
            for (int o = 0; o <= 9; o++)
            {
                Console.Write("\n") ;
                for (int i = 0; i <= 9; i++)
                {
                    if (coordinateY == o && coordinateX == i && foodY == o && foodX == i)
                    {
                        Snake++;
                        Console.Write(" " + Snake + " ");
                        i++;
                        Randomize = true;
                        continue;
                    }
                    


                    if (coordinateY == o && coordinateX == i)
                    {                    
                            Console.Write(" "+Snake+" ");
                            i++;                      
                    }
                    if (foodY == o && foodX == i)
                    {                       
                            Console.Write(" " + "+" + " ");
                            i++;                       
                    }

                    Console.Write(" = ");

                }
            }
        }
        public void NextMove()
        {
            Console.WriteLine("Your Next move: 1-Up 2-Down 3-Left 4-Right");
            int m =Convert.ToInt32( Console.ReadLine());
            if (m==1)
            {
                 UMuve = true;

                DMuve = false;
                LMuve = false;
                RMuve = false;
            }
            else if (m == 2)
            {
                DMuve = true;
                UMuve = false;
                LMuve = false;
                RMuve = false;
            }
            else if (m == 3)
            {
                LMuve = true;
                UMuve = false;
                RMuve = false;
                DMuve = false;
            }
            else if (m == 4)
            {
                RMuve = true;
                LMuve = false;
                UMuve = false;
                DMuve = false;
            }
        }
    }


}
