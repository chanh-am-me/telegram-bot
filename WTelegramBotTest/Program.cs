using Npgsql;
using WTelegram;
using WTelegram.Types;

int apiId = 22246669;
string apiHash = "5077609944b128a707af34922df55028";
string botToken = "7428476943:AAFVt59UcYCM3lWAyj6F8CuC6SfSV1VGs20";

using NpgsqlConnection connection = new(@"Host=localhost;Port=5432;Database=telegram-bot;Username=postgres;Password=1;");
//TelegramBotClient bot = new(botToken);
using Bot bot = new(botToken, apiId, apiHash, connection);
ChatFullInfo chat = await bot.GetChat("@DRBTSolana");
List<Message> messages = await bot.GetMessagesById("@DRBTSolana", Enumerable.Range(495986, 10));
Console.WriteLine($"I fetched {messages.Count} messages from @DRBTSolana:");
foreach (Message m in messages)
{
    Console.WriteLine($"  {m.MessageId}: {m.Type} {m.Text}");
}