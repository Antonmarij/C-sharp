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
            if (e.Message.Content.ToLower().StartsWith("!dovla"))
                await e.Message.RespondAsync("is stupid!");
            if (e.Message.Content.ToLower().StartsWith("!moop"))
                await e.Message.RespondAsync("is the cutest boy ever :3");
            if (e.Message.Content.ToLower().StartsWith("!hyph"))
                await e.Message.RespondAsync("is the only smart brit out there lul");
        };
        await discord.ConnectAsync();
        await Task.Delay(-1);
    }
}
