using TelegramBotAnalyzatorBL.Controller;

const string EXIT_COMMAND = "exit";

TelegramBotController tgBotController = new TelegramBotController();

while (true)
{
    var result = Console.ReadLine();
    if(result.ToLower() == EXIT_COMMAND)
    {
        Environment.Exit(0);
    }
}