using System;
using System.Threading.Tasks;
using Grpc.Core;
using Google.Protobuf;


namespace ChessBoard
{
    public class ChessBoardImp3: SendSolutionForProblem.SendSolutionForProblemBase
    {
        public override Task<Solution> GetTheSolution(RequestSolution request ,ServerCallContext context)
        {
            

            return Task.FromResult(new Solution
            {
                
                Grains =  36

            }
            ); 


        }

    }
}
