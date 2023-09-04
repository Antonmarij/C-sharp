using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class MyFirstModule : BaseCommandModule
{
    [Command("guide")]
    public async Task GreetCommand(CommandContext ctx, string playerClass)
    {
        switch(playerClass)
        await ctx.RespondAsync($"Greetings!, {name}! You're ugly as fuck");
    }
}
