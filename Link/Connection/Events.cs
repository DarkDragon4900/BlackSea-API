using BlackSea.Players;
using BlackSea.Movement;
using BlackSea.World;
using BlackSea.World.Blocks;

namespace BlackSea.Link
{
    public partial class Connection
    {
        public delegate void MessageHandler(EEMessage Message);
        public event MessageHandler OnMessage;

        public delegate void PlayerJoinedHandler(IPlayer Player);
        public event PlayerJoinedHandler OnPlayerJoined;

        public delegate void PlayerLeftHandler(IPlayer Player);
        public event PlayerLeftHandler OnPlayerLeft;

        public delegate void BlockPlacedHandler(IPlayer Player, IBlock Block);
        public event BlockPlacedHandler OnBlockPlaced;

        public delegate void PlayerMovedHandler(IPlayer Player, Move Move);
        public event PlayerMovedHandler OnPlayerMoved;

        public delegate void CoinCollectedHandler(IPlayer Player);
        public event CoinCollectedHandler OnCoinCollected;

        public delegate void CrownTakenHandler(IPlayer Player);
        public event CrownTakenHandler OnCrownTaken;

        public delegate void TrophyTakenHandler(IPlayer Player);
        public event TrophyTakenHandler OnTrophyTaken;

        public delegate void WootGivenHandler(IPlayer Player);
        public event WootGivenHandler OnWootGiven;

        public delegate void SmileyChangedHandler(IPlayer Player);
        public event SmileyChangedHandler OnSmileyChanged;

        public delegate void GodStateChangedHandler(IPlayer Player);
        public event GodStateChangedHandler OnGodStateChanged;

        public delegate void PlayerSpokenHandler(IPlayer Player, string Message, bool Private);
        public event PlayerSpokenHandler OnPlayerSpoken;

        public delegate void ActionRequestedHandler(IPlayer Player, string Action, string[] Parameters);
        public event ActionRequestedHandler OnActionRequested;

        public delegate void PotionDrankHandler(IPlayer Player, int Potion);
        public event PotionDrankHandler OnPotionDrank;

        public delegate void PlayerDiedHandler(IPlayer Player);
        public event PlayerDiedHandler OnPlayerDied;

        public delegate void PlayerTeleportedHandler(IPlayer Player);
        public event PlayerTeleportedHandler OnPlayerTeleported;

        public delegate void DoorOpenedHandler(DoorType Door);
        public event DoorOpenedHandler OnDoorOpened;

        public delegate void DoorClosedHandler(DoorType Door);
        public event DoorClosedHandler OnDoorClosed;

        public delegate void AccessReceivedHandler();
        public event AccessReceivedHandler OnAccessReceived;

        public delegate void LostAccessHandler();
        public event LostAccessHandler OnLostAccess;

        public delegate void LevelErasedHandler();
        public event LevelErasedHandler OnLevelErased;

        public delegate void LevelLoadedHandler();
        public event LevelLoadedHandler OnLevelLoaded;

        public delegate void LevelSavedHandler();
        public event LevelSavedHandler OnLevelSaved;

        public delegate void MetaUpdatedHandler();
        public event MetaUpdatedHandler OnMetaUpdated;
    }
}
