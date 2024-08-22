using Telegram.Bot;

namespace WTelegramBotTest;

public class WTelegramEngine
{
    private readonly WTelegramBotClient botClient;

    public WTelegramEngine(WTelegramBotClient botClient)
    {
        this.botClient = botClient;
    }
}
