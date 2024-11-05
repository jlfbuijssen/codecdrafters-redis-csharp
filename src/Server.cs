using System.Net;
using System.Net.Sockets;

TcpListener server = new TcpListener(IPAddress.Any, 6379);
server.Start();
Socket socket = server.AcceptSocket(); // wait for client

String msg = "+PONG\r\n";
char[] chars = msg.ToCharArray();
byte[] buffer = new byte[chars.Length];
for (int i = 0; i < chars.Length; i++)
{
    buffer[i] = (byte)chars[i];
}
socket.Send(buffer);
socket.Close();
