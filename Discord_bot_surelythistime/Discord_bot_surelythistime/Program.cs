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
        {//name commands
            if (e.Message.Content.ToLower().StartsWith("!dovla"))
                await e.Message.RespondAsync("is stupid!");
            if (e.Message.Content.ToLower().StartsWith("!moop"))
                await e.Message.RespondAsync("is the cutest boy ever :3");
            if (e.Message.Content.ToLower().StartsWith("!hyph"))
                await e.Message.RespondAsync("is the only smart brit out there lul");
            if (e.Message.Content.ToLower().StartsWith("!dotty"))
                await e.Message.RespondAsync("she's busy in battlegrounds sorry");
            if (e.Message.Content.ToLower().StartsWith("!floyz"))
                await e.Message.RespondAsync("who, the bollywood pooper?");
            if (e.Message.Content.ToLower().StartsWith("!swep"))
                await e.Message.RespondAsync("busy in his 16th split of the week sry");
            if (e.Message.Content.ToLower().StartsWith("!stitch"))
                await e.Message.RespondAsync("is sleepwalking but awake");
            if (e.Message.Content.ToLower().StartsWith("!rogue"))
                await e.Message.RespondAsync("Sims:\nhttps://wowsims.github.io/wotlk/rogue/\n BisList:\n<https://wowtbc.gg/wotlk/bis-list/combat-rogue/>");

      
        };
        await discord.ConnectAsync();
        await Task.Delay(-1);
    }
}
