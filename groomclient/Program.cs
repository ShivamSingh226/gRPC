using Grpc.Net.Client;
using gRoom.gRPC.Messages;

using var channel=GrpcChannel.ForAddress("http://localhost:5038/");
var Client=new Groom.GroomClient(channel);
Console.Write("Enter room name to register: ");
var roomName=Console.ReadLine();
var resp=Client.RegisterToRoom(new RoomRegistrationRequest{RoomName=roomName});
Console.WriteLine($"Room Id : {resp.RoomId}");

Console.Read();
