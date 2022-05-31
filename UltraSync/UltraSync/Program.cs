using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;
using Microsoft.Xna.Framework;

namespace UltraSync
{
    [ApiVersion(2, 1)]
    public class UltraSyncPlugin : TerrariaPlugin
    {
        public override string Author => "Ozz5581";

        public override string Description => "Ultra sync plugin";

        public override string Name => "UltraSync";

        public override Version Version => new Version(1, 0, 0, 0);

        public UltraSyncPlugin(Main game) : base(game)
        {

        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("survivalhelper.ultrasync", UltraSync, "ultrasync", "usync")
            {
                HelpText = "Syncs tiles, but ultra large"
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Deregister hooks here
            }
            base.Dispose(disposing);
        }

        private void UltraSync(CommandArgs args)
        {
            args.Player.SendTileSquareCentered(args.Player.TileX, args.Player.TileY, 84);
            args.Player.SendMessage($"Ultra Sync'd", Color.Coral);
            return;
        }
    }
}