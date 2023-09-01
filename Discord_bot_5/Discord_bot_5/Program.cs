using System;
using System.Net.WebSockets;
using System.Net;
using System.Threading.Tasks;
using Discord;
using Discord.Net.Queue;
using Discord.Net;
using Discord.WebSocket;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Discord.Commands;
using System.Windows.Input;

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

        string botToken = Environment.GetEnvironmentVariable("Discord_Bot_Token");

        await _client.LoginAsync(TokenType.Bot, botToken);
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
        
    }
    private async Task HandleCommandAsync(SocketMessage arg)
    {
        var message = arg as SocketUserMessage;
        var context = new SocketCommandContext(_client, message);

        if (message.Author.IsBot) return;

        int argPos = 0;
        if (message.HasStringPrefix("!", ref argPos))
        {
            var result = await _commands.ExecuteAsync(context, argPos, _services);
            if (!result.IsSuccess)
                Console.WriteLine(result.ErrorReason);
        }
    }

    [Command("hello")]
    public async Task HelloCommand()
    {
        await _context.Channel.SendMessageAsync("Hello! How can I assist you today?");
    }
}
