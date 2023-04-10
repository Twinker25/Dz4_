using TicTacToeGame;

namespace Dz4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Write("Enter number of task (1 - 4): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                        break;
                    case 2:
                        TicTacToe ticTacToe = new TicTacToe();
                        ticTacToe.Play();
                        break;
                    case 3:
                        Console.Write("\nEnter text: ");
                        string in1 = Console.ReadLine();
                        string out1 = InMorze.Inmorze.inmorze(in1);
                        Console.Write("\nResult: " + out1);
                        break;
                    case 4:
                        Console.Write("\nEnter text: ");
                        string in2 = Console.ReadLine();
                        string out2 = OutMorze.Outmorze.outmorze(in2);
                        Console.Write("\nResult: " + out2);
                        break;
                    default:
                        Console.WriteLine("\nError! Please try again!");
                        break;
                }
            } while (choice < 1 || choice > 4);
        }
    }
}