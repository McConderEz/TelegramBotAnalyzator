using PRTelegramBot.Attributes;
using PRTelegramBot.Models;
using PRTelegramBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotAnalyzatorBL.Controller
{
    public class CommandController
    {

        [ReplyMenuHandler("/start")]
        public static async Task MessageHandler(ITelegramBotClient botClient, Update update)
        {
            var menuList = new List<KeyboardButton>();
            var menuListString = new List<string>();

            menuList.Add(new KeyboardButton("Мониторинг"));
            menuList.Add(new KeyboardButton("Сравнение"));
            menuList.Add(new KeyboardButton("Анализ"));
            menuList.Add(new KeyboardButton("Подписаться на уведомление"));
            menuList.Add(new KeyboardButton("Список желаемого"));
            menuList.Add(new KeyboardButton("Получить рекомендации"));
            menuList.Add(new KeyboardButton("Помощь"));

            var menu = MenuGenerator.ReplyKeyboard(1, menuList);
            var option = new OptionMessage();
            option.MenuReplyKeyboardMarkup = menu;

            var message = "Добро пожаловать!Я бот-анализатор цен на компьютерные комплектующие." +
                "Я помогу собирать тебе актуальную информацию о ценах со всех маркетплейсов и подобрать лучший вариант!";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);
        }

        /// <summary>
        /// Команда для запуска мониторинга цен.Бот будет регулярно проверять цены 
        /// на заданные компьютерные комплектующие и обновлять информацию.
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        [ReplyMenuHandler("/monitor", "Мониторинг")]
        public static async Task Monitor(ITelegramBotClient botClient, Update update)
        {
            var message = "Функция мониторинга в разработке";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

        /// <summary>
        /// Команда для сравнения цен. Бот предоставит сравнительный 
        /// анализ цен на различные компьютерные 
        /// комплектующие и поможет выбрать наилучший вариант.
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        [ReplyMenuHandler("/compare", "Сравнение")]
        public static async Task Compare(ITelegramBotClient botClient, Update update)
        {
            var message = "Функция сравнения цен в разработке";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

        /// <summary>
        /// Команда для анализа рынка. Бот предоставит обзор текущего состояния рынка 
        /// компьютерных комплектующих, включая тренды, популярные модели и динамику цен.
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        [ReplyMenuHandler("/analyze", "Анализ")]
        public static async Task MarketAnalyze(ITelegramBotClient botClient, Update update)
        {
            var message = "Функция анализа рынка в разработке";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

        /// <summary>
        /// Команда для подписки на уведомления. Бот будет отправлять уведомления
        /// о снижении цен на заданные
        /// компьютерные комплектующие или о появлении новых интересных предложений.
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        [ReplyMenuHandler("/subscribe", "Подписаться на уведомление")]
        public static async Task Subscribe(ITelegramBotClient botClient, Update update)
        {
            var message = "Функция подписи на уведомления в разработке";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

        /// <summary>
        /// Команда для создания списка желаемых комплектующих. Вы можете добавлять интересующие
        /// вас товары в список желаемого, и бот будет следить за изменениями
        /// цен и отправлять уведомления при их изменении.
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        [ReplyMenuHandler("/wishlist", "Список желаемого")]
        public static async Task GetWishList(ITelegramBotClient botClient, Update update)
        {
            var message = "Функция получения списка желаемых комплектующих в разработке";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

        /// <summary>
        /// Команда для получения рекомендаций. Бот предложит персонализированные
        /// рекомендации на основе ваших предпочтений
        /// и бюджета, помогая выбрать оптимальные компьютерные комплектующие.
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        [ReplyMenuHandler("/recommendations", "Получить рекомендации")]
        public static async Task GetRecommendations(ITelegramBotClient botClient, Update update)
        {
            var message = "Функция получения рекомендаций в разработке";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

        /// <summary>
        /// Команда для получения справочной информации и помощи по использованию бота.
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        [ReplyMenuHandler("/help","Помощь")]
        public static async Task GetHelp(ITelegramBotClient botClient, Update update)
        {
            var message = "Функция получения справочной информации и помощи в разработке";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

    }
}
