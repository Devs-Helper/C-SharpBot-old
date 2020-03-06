using Discord;
using Discord.Net;
using Discord.WebSocket;
using Discord.Commands;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace C_SharpBot.Test.Modules
{
    public class Commands : ModuleBase
    {
        [Command("hello")]
        public async Task HelloCommand()
        {
            // initialize empty string builder for reply
            var sb = new StringBuilder();

            var user = Context.User;
            sb.AppendLine($"You are -> [{user.Username}");
            sb.AppendLine($"I must now say, World!");

            // send simple string reply
            await ReplyAsync(sb.ToString());
        }
    }
}
