using PRTelegramBot.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotAnalyzatorBL.Controller
{
    public class TelegramBotController
    {
        PRBot telegramBot;

        public TelegramBotController()
        {
            telegramBot = new PRBot(option =>
            {
                option.Token = "6704352372:AAE3HkkV4x4wwGmITJutehTF1AzAfEROfNk";
                option.ClearUpdatesOnStart = true;
                option.WhiteListUsers = new List<long>() { };
                option.Admins = new List<long>() { };
                option.BotId = 0;
            });

            telegramBot.OnLogCommon += Telegram_OnLogCommon;
            telegramBot.OnLogError += Telegram_OnLogError;
            Start();
        }

        private async void Start()
        {
            await telegramBot.Start();
        }

        private void Telegram_OnLogError(Exception ex, long? id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string errorMsg = $"{DateTime.Now}: {ex}";
            Console.WriteLine(errorMsg);
            Console.ResetColor();
        }

        private void Telegram_OnLogCommon(string msg, PRBot.TelegramEvents typeEvent, ConsoleColor color)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string message = $"{DateTime.Now}: {msg}";
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
