namespace TonberryBot.services
{
    using Discord.Addons.Hosting;
    using Discord.WebSocket;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    public abstract class TonberryBaseService : DiscordClientService
    {
        public readonly DiscordSocketClient Client;
        public readonly ILogger<TonberryBaseService> Logger;
        public readonly IConfiguration Configuration;

        public TonberryBaseService(DiscordSocketClient client, ILogger<TonberryBaseService> logger, IConfiguration configuration) : base (client, logger)
        {
            Client = client;
            Logger = logger;
            Configuration = configuration;
        }
    }
}