using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DiscordBot
{
        public class Program
        {
            public static void Main(string[] args)
                => new Program().MainAsync().GetAwaiter().GetResult();

            public async Task MainAsync()
            {
            var client = new DiscordSocketClient();

            client.Log += Log;

            string token = "Mjg4MDI2NDQzMTUyMzU5NDI0.DAIinw.xtpiXGa9GgrrFd2fEXBwAgEU-Jc"; // keep this shit private 
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();
            client.MessageReceived += MessageRecieved;

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }
        public static void Sleep(int seconds)
        {
            seconds = seconds * 1000;
            Thread.Sleep(seconds);
        }

        private async Task MessageRecieved(SocketMessage message)
        {
            if (message.Content == ".ping")
            {
                await message.Channel.SendMessageAsync("PONNNGGGG");
            }
            if(message.Content == ".keith")
            {
                Random rand = new Random();
                int randomNum = rand.Next(1, 40);
                if (randomNum >= 1 && randomNum <= 10)
                {
                    await message.Channel.SendMessageAsync("cars.com");
                }
                if(randomNum >= 11 && randomNum <= 20)
                {
                    await message.Channel.SendMessageAsync("I exclusively fuck miata owners.");
                }
                if(randomNum >= 21 && randomNum <= 30)
                {
                    await message.Channel.SendMessageAsync("memes, dreams, puns and guns");
                }
                if(randomNum >= 31 && randomNum <= 40)
                {
                    await message.Channel.SendMessageAsync("\"automatic transmissions are better for gas mileage\"");
                    Sleep(2);
                    await message.Channel.SendMessageAsync("http://imgur.com/a/d41n7");
                    Sleep(1);
                    await message.Channel.SendMessageAsync("auTomAtiC tRAnsmisSiOns aRe beTTer FOr gAs milEagE");
                }
            }
            if(message.Content == ".adhd")
            {
                await message.Channel.SendMessageAsync("http://i.imgur.com/wjeVN3h.jpg");
            }
            if(message.Content == ".matt")
            {
                Random rand = new Random();
                int matt = rand.Next(1, 40);
                if(matt >= 1 && matt <= 10)
                {
                    await message.Channel.SendMessageAsync("https://s-media-cache-ak0.pinimg.com/736x/05/f9/e4/05f9e4517116bbba3859486f2e7bd7f1.jpg");
                }
                if(matt >= 11 && matt <= 20)
                {
                    await message.Channel.SendMessageAsync("the garbage collector is here");
                    Sleep(1);
                    await message.Channel.SendMessageAsync("http://imgur.com/a/PY8jq");
                }
                if (matt >= 21 && matt <= 30)
                {
                    await message.Channel.SendMessageAsync("MATTHEW IS MANAGER");
                }
                if (matt >= 31 && matt <= 40)
                {
                    await message.Channel.SendMessageAsync("http://imgur.com/a/rI6jT");
                }
            }
        }
        private Task Log(LogMessage msg)
            {
                Console.WriteLine(msg.ToString());
                return Task.CompletedTask;
            }
        }


}
