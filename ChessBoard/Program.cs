// See https://aka.ms/new-console-template for more information
//
//Console.WriteLine("Hello, World!");

using System;
using Google.Protobuf;
using Grpc.Core;
namespace ChessBoard
{
 
  class Program
    {
        const int Port = 50053;
        public static void Main(string[] args)
        {
            try
            {
                Server server = new Server
                {
                   Services = { AreYouAlive.BindService(new ChessBoardImp2()) , 
                        GiveMeATaskToSolve.BindService(new ChessBoardImp()) ,
                    SendSolutionForProblem.BindService(new ChessBoardImp3())},
                   // Services = {  },

                    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
                };
                server.Start();
                Console.WriteLine("ChessBoard server listening on port " + Port);
                Console.WriteLine("Press any key to stop the server...");
                Console.ReadKey();
                server.ShutdownAsync().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            }
        }
    }
}

