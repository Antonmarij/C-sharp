using System;
using System.Threading.Tasks;
using DSharpPlus;

class Program
{

    static async Task Main(string[] args)
    {
        var discord = new DiscordClient(new DiscordConfiguration()
        {
            Token = Environment.GetEnvironmentVariable("Discord_Bot_Token"),
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.AllUnprivileged | DiscordIntents.MessageContents
        });
        
        discord.MessageCreated += async (s, e) =>
        {
            if (e.Message.Content.ToLower().StartsWith("ping"))
                await e.Message.RespondAsync("pong!"); 
        };
        await discord.ConnectAsync();
        await Task.Delay(-1);
    }
}
