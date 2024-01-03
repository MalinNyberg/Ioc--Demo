namespace IoccDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailHandler emailHandler = new EmailHandler(); 
            ChatService chatService = new ChatService(emailHandler);
            chatService.SendMessageTo("Adrian", "hiiii!");


        }
    }
}