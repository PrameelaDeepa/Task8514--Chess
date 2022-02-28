using System;
using System.Threading.Tasks;
using Grpc.Core;
using Google.Protobuf;

namespace ChessBoard
{
    public class ChessBoardImp2 : AreYouAlive.AreYouAliveBase
    {
        public override Task<Connection> GetConnection(ConnectionRequest request, ServerCallContext context)
        {
            // HealthCheck check = new HealthCheck();

            //check = " Hello client " + Connection.request;

            // return Task.FromResult(check.GetConnection(request));

            return Task.FromResult(new Connection
            {
                Message = request.Message +  " /n Server : Hello Client" + "   Iam Alive" 
            }
            ) ;

      
        }
       

    }
}



