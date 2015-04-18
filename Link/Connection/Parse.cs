using System.Linq;
using BlackSea.Movement;
using BlackSea.World;

namespace BlackSea.Link
{
    public partial class Connection
    {
        public void MessageParse(EEMessage m)
        {
            OnMessage(m);
            switch (m.Type)
            {
                case "b":
                    OnBlockPlaced(Host.Players.GetByID(m.GetInt(4)), Host.WorldMap.GetBlock(m.GetInt(0), new Position(m.GetInt(1), m.GetInt(2))));
                    break;
                case "bc":
                case "bs":
                case "br":
                case "lb":
                case "wp":
                case "ts":
                    OnBlockPlaced(Host.Players.GetByID(m.GetInt(4)), Host.WorldMap.GetBlock(0, new Position(m.GetInt(0), m.GetInt(1))));
                    break;
                case "pt":
                    OnBlockPlaced(Host.Players.GetByID(m.GetInt(4)), Host.WorldMap.GetBlock(0, new Position(m.GetInt(0), m.GetInt(1))));
                    break;
                case "add":
                    OnPlayerJoined(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "left":
                    OnPlayerLeft(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "m":
                    OnPlayerMoved(Host.Players.GetByID(m.GetInt(0)), new Move(m));
                    break;
                case "c":
                    OnCoinCollected(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "k":
                    OnCrownTaken(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "ks":
                    OnTrophyTaken(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "wu":
                    OnWootGiven(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "face":
                    OnSmileyChanged(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "mod":
                case "guardian":
                case "god":
                    OnGodStateChanged(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "say":
                    OnPlayerSpoken(Host.Players.GetByID(m.GetInt(0)), m.GetString(1), false);
                    if (m.GetString(1)[0] == '!')
                    {
                        string[] args = m.GetString(1).Split(' ').ToArray();
                        string Action = args[0].Substring(1).ToLower();
                        for (int i = 0; i < args.Length; i++)
                            args[i] = args[i].ToLower();
                        OnActionRequested(Host.Players.GetByID(m.GetInt(0)), Action, args.Skip(1).ToArray());
                    }
                    break;
                case "tele":
                    OnPlayerTeleported(Host.Players.GetByID(m.GetInt(1)));
                    break;
                case "kill":
                    OnPlayerDied(Host.Players.GetByID(m.GetInt(0)));
                    break;
                case "access":
                    OnAccessReceived();
                    break;
                case "lostaccess":
                    OnLostAccess();
                    break;
                case "clear":
                    OnLevelErased();
                    break;
                case "reset":
                    OnLevelLoaded();
                    break;
                case "saved":
                    OnLevelSaved();
                    break;
                case "p":
                    OnPotionDrank(Host.Players.GetByID(m.GetInt(0)), m.GetInt(1));
                    break;
                case "updatemeta":
                    OnMetaUpdated();
                    break;
                case "show":
                    switch (m.GetString(0))
                    {
                        case "red":
                            OnDoorClosed(DoorType.Red);
                            break;
                        case "green":
                            OnDoorClosed(DoorType.Green);
                            break;
                        case "blue":
                            OnDoorClosed(DoorType.Blue);
                            break;
                        case "cyan":
                            OnDoorClosed(DoorType.Cyan);
                            break;
                        case "magenta":
                            OnDoorClosed(DoorType.Magenta);
                            break;
                        case "yellow":
                            OnDoorClosed(DoorType.Yellow);
                            break;
                        case "timedoor":
                            OnDoorClosed(DoorType.Time);
                            break;
                    }
                    break;
                case "hide":
                    switch (m.GetString(0))
                    {
                        case "red":
                            OnDoorOpened(DoorType.Red);
                            break;
                        case "green":
                            OnDoorOpened(DoorType.Green);
                            break;
                        case "blue":
                            OnDoorOpened(DoorType.Blue);
                            break;
                        case "cyan":
                            OnDoorOpened(DoorType.Cyan);
                            break;
                        case "magenta":
                            OnDoorOpened(DoorType.Magenta);
                            break;
                        case "yellow":
                            OnDoorOpened(DoorType.Yellow);
                            break;
                        case "timedoor":
                            OnDoorOpened(DoorType.Time);
                            break;
                    }
                    break;
            }
        }
    }
}
