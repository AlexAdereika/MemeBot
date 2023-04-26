using System;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace MemeBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("6172519880:AAHWUJA4T9aIy_Cm5aYczNwI8FhPfCeQBm4");

            client.StartReceiving(Update, Error, null);
            Console.ReadLine();
        }

        

        async private static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var messages = new List<string>() { "привет", "здорова", "hello", "hi", "хай"};
            var message = update.Message;
            if (message.Text != null)
            {
                foreach (var item in messages) 
                {
                    if (message.Text.ToLower().Contains(item))
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id, "Ну здравствуй! \nКак тебя зовут?");
                    }
                }
            }

            if (message.Text.ToLower().Contains("юля"))
            {
                await botClient.SendStickerAsync(message.Chat.Id, "D:\\MemeBot\\MemeBot\\MemeBot\\src\\chpic.su_-_PeachCatPack22_008.webm");
            }
        }

        async private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    }
}