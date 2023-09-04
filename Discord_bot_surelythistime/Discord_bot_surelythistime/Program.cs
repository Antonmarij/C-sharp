using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;

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
        var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
        {
            StringPrefixes = new[] {"!"}
        }
            );
        commands.RegisterCommands<MyFirstModule>();
        
       
        //discord.MessageCreated += async (s, e) =>
        //{
        //    if (e.Message.Content.ToLower().StartsWith("!dovla"))
        //        await e.Message.RespondAsync("is stupid!");
        //    if (e.Message.Content.ToLower().StartsWith("!moop"))
        //        await e.Message.RespondAsync("is the cutest boy ever :3");
        //    if (e.Message.Content.ToLower().StartsWith("!hyph"))
        //        await e.Message.RespondAsync("is the only smart brit out there lul");
        //    if (e.Message.Content.ToLower().StartsWith("!dotty"))
        //        await e.Message.RespondAsync("she's busy in battlegrounds sorry");
        //    if (e.Message.Content.ToLower().StartsWith("!floyz"))
        //        await e.Message.RespondAsync("who, the bollywood pooper?");
        //    if (e.Message.Content.ToLower().StartsWith("!swep"))
        //        await e.Message.RespondAsync("busy in his 16th split of the week sry");
        //    if (e.Message.Content.ToLower().StartsWith("!stitch"))
        //        await e.Message.RespondAsync("is sleepwalking but awake");
        //    if (e.Message.Content.ToLower().StartsWith("!rogue"))
        //        await e.Message.RespondAsync("Sims:\nhttps://wowsims.github.io/wotlk/rogue/\n BisList:\n<https://wowtbc.gg/wotlk/bis-list/combat-rogue/>");
        //    if (e.Message.Content.ToLower().StartsWith("goodmorning"))
        //        await e.Message.RespondAsync("Top of the morning to yousir!");
        //    if (e.Message.Content.ToLower().StartsWith("goodnight"))
        //        await e.Message.RespondAsync("Sleep well sir!");
        //    if (e.Message.Content.ToLower().StartsWith("!thanoice"))
        //        await e.Message.RespondAsync("he's busy overanalysing dune2 trailer");

      
        //};
        await discord.ConnectAsync();
        await Task.Delay(-1);
    }
}
