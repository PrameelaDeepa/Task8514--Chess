using System;
using System.Threading.Tasks;
using Grpc.Core;
using Google.Protobuf;

namespace ChessBoard
{
    public class ChessBoardImp: GiveMeATaskToSolve.GiveMeATaskToSolveBase
    {
        public override Task<Dimensions> GetBoardSize(GetDimensions request ,ServerCallContext context)
        {
            Random random = new Random();
            Console.WriteLine("Could you caliculate the grains on the  ChessBoard of the size below ");

            return Task.FromResult(new Dimensions
            {
                
                Horizontal = random.Next(2,4),
                Vertical = random.Next(2,4)

            }
            ); 


        }

    }
}


