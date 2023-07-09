using System;
using Sandbox;
using Sandbox.UI;

namespace Tetros;

public partial class TetrosGame : GameManager
{
    public TetrosGame()
    {
        if(Game.IsClient)
        {
            // Init HUD
            Game.RootPanel?.Delete(true);
            Game.RootPanel = new GameHud();
        }
    }

    public override void ClientJoined(IClient client)
    {
        base.ClientJoined(client);

        // Create a pawn
        var pawn = new TetrosPlayer();
        client.Pawn = pawn;
    }
}
