using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

class Program
{
    private DiscordSocketClient _client;

    public static async Task Main(string[] args)
    {
        var program = new Program();
        await program.RunBotAsync();
    }

    public async Task RunBotAsync()
    {
        _client = new DiscordSocketClient();

        _client.Log += LogAsync;
        _client.Ready += ReadyAsync;

        await _client.LoginAsync(TokenType.Bot, MTE0NzIwMDgyNzA1Mjc4OTgzMQ.GIa1EX.6WYll6bcXaUa7dWkPnvmr - P4eCn6N56aNx4fvg);
        await _client.StartAsync();

        await Task.Delay(-1);
    }

    private Task LogAsync(LogMessage log)
    {
        Console.WriteLine(log);
        return Task.CompletedTask;
    }

    private async Task ReadyAsync()
    {
        Console.WriteLine("Bot is connected and ready!");

        // Your bot's code goes here.
    }
}
