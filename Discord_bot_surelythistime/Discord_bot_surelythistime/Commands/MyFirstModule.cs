using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class MyFirstModule : BaseCommandModule
{
    [Command("guide")]
    public async Task GreetCommand(CommandContext ctx, string playerClass)
    {
        switch (playerClass.ToLower())
        {
            case "rogue":
                await ctx.RespondAsync($"{playerClass} bislist:\n<https://wowtbc.gg/wotlk/bis-list/combat-rogue/>\nsims:\n<https://wowsims.github.io/wotlk/rogue/>");
                break;

            default:
                await ctx.RespondAsync($"{playerClass} does not exist yet, try another one!");
                break;

        }
    }
}

public class MySecondModule : BaseCommandModule
{
    [Command("name")]
    public async Task NameCommand(CommandContext ctx, string name)
    {
        switch (name.ToLower())
        {
            case "floyz":
                await ctx.RespondAsync($"who, {name}, the bollywood pooper?");
                break;

            case "hyph":
                await ctx.RespondAsync("beast unleashed");
                break;
            default:
                await ctx.RespondAsync($"wh :omegalul:");
                break;
        }
    }
}





