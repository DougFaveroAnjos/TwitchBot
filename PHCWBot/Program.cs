using System;
using System.Threading;
using TwitchTools;

namespace PHCWBot
{
    class Program
    {
        static string oauth = "oauth:(oauth Token)";
        static TwitchChatHandle chat = new TwitchChatHandle(oauth, "PHCWB");

        static void Main(string[] args)
        {
            while (true)
            {
                var lerMensagem = chat.Read();
                string mensagem = lerMensagem.Message;

                if(mensagem.Contains("!phcwbot") || mensagem.Contains("!PHCWBot") || mensagem.Contains("!PHCWBOT"))
                {
                    chat.Write("mensagem");
                }
            }
        }
    }
}