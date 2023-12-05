using SDP_Assignment4;

internal class Program
{
    private static void Main(string[] args)
    {
        TCP_Connection tcpConnection = new TCP_Connection();

        tcpConnection.Open();       
        tcpConnection.Open();       

        tcpConnection.Establish();  
        tcpConnection.Establish();  

        tcpConnection.Listen();     
        tcpConnection.Close();      

        tcpConnection.Listen();    
        tcpConnection.Open();       
    }
}