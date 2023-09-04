using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Reflection;
using System.Runtime.CompilerServices;

public class Program
{
    public static Task Main(string[] args)
=> new Program().MainAsync();
    public async Task MainAsync()
    {
        _client = new DiscordSocketClient();

        _client.Log += Log;

        var token = Environment.GetEnvironmentVariable("Discord_Bot_Token");

        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();

        await Task.Delay(-1);
    }
    private Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }

    private DiscordSocketClient _client;
}
public class CommandHandler
{
    private readonly DiscordSocketClient _client;
    private readonly CommandService _commands;
    public CommandHandler(DiscordSocketClient client, CommandService commands)
    {
        _commands = commands;
        _client = client;
    }
    // hyph si a gimp
    public async Task InstallCommandsAsync()
    {
        _client.MessageReceived += HandleCommandAsync;
        await _commands.AddModulesAsync(assembly: Assembly.GetEntryAssembly(), services: null);

    }
    private async Task HandleCommandAsync(SocketMessage messageParam)
    {
        var message = messageParam as SocketUserMessage;
        if (message == null) return;
        int argPos = 0;
        if (!(message.HasCharPrefix('!', ref argPos) || 
            message.HasMentionPrefix(_client.CurrentUser, ref argPos)) ||
            message.Author.IsBot)
            return;
        var context = new SocketCommandContext(_client, message);
        await _commands.ExecuteAsync(context: context, argPos: argPos, services: null);
    }
}
public class InfoModule : ModuleBase<SocketCommandContext>
{
    //For a command to be valid, it must have a return type of Task or Task<RuntimeResult>
    // say dovla is silly -> dovla is silly
    [Command("say")]
    [Summary("Echoes a message.")]
    public Task SayAsync([Remainder][Summary("The text to echo")] string echo)
        => ReplyAsync(echo);

}