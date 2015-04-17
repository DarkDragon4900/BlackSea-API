using BlackSea.Players;
using BlackSea.Movement;
using BlackSea.World;
using BlackSea.World.Blocks;

namespace BlackSea.Link
{
    public partial class Connection
    {
        public void TryCode(string Code)
        {
            Send("access", Code);
        }

        public void SendBlock(IBlock Block)
        {
            switch (Block.Type)
            {
                case BlockType.SimpleBlock:
                    SimpleBlock sb = Block as SimpleBlock;
                    Send(WorldMap.Key, 0, Block.Position.X, Block.Position.Y, Block.ID);
                    break;
                case BlockType.BackgroundBlock:
                    BackgroundBlock bb = Block as BackgroundBlock;
                    Send(WorldMap.Key, 1, Block.Position.X, Block.Position.Y, Block.ID);
                    break;
                case BlockType.RotatableBlock:
                    RotatableBlock rb = Block as RotatableBlock;
                    Send(WorldMap.Key, 0, Block.Position.X, Block.Position.Y, Block.ID, (int)rb.Rotation);
                    break;
                case BlockType.ValuedBlock:
                    ValuedBlock vb = Block as ValuedBlock;
                    Send(WorldMap.Key, 0, Block.Position.X, Block.Position.Y, Block.ID, vb.Value);
                    break;
                case BlockType.PortalBlock:
                    PortalBlock pb = Block as PortalBlock;
                    Send(WorldMap.Key, 0, Block.Position.X, Block.Position.Y, Block.ID, (int)pb.Rotation, pb.Identificator, pb.Target);
                    break;
            }
        }

        public void ChangeSmiley(int Smiley)
        {
            Send(WorldMap.Key + "f", Smiley);
        }

        public void GodState(bool Enable)
        {
            Send("god", Enable);
        }

        public void GetCrown()
        {
            Send(WorldMap.Key + "k");
        }

        public void GetTrophy()
        {
            Send("levelcomplete");
        }

        public void Woot()
        {
            Send("wootup");
        }

        public void Say(string Message)
        {
            Send("say", Message);
        }

        public void SaveLevel()
        {
            Send("save");
        }

        public void ClearLevel()
        {
            Send("clear");
        }

        public void LoadLevel()
        {
            Send("say", "/loadlevel");
        }

        public void ResetLevel()
        {
            Send("say", "/reset");
        }

        public void ChangeCode(string Code)
        {
            Send("key", Code);
        }

        public void ChangeTitle(string Title)
        {
            Send("name", Title);
        }

        public void AllowPotions(bool Allow)
        {
            Send("allowpotions", Allow);
        }

        public void OpenDoor(DoorType Door)
        {
            switch (Door)
            {
                case DoorType.Red:
                    Send(WorldMap.Key + "r");
                    break;
                case DoorType.Green:
                    Send(WorldMap.Key + "g");
                    break;
                case DoorType.Blue:
                    Send(WorldMap.Key + "b");
                    break;
                case DoorType.Cyan:
                    Send(WorldMap.Key + "c");
                    break;
                case DoorType.Magenta:
                    Send(WorldMap.Key + "m");
                    break;
                case DoorType.Yellow:
                    Send(WorldMap.Key + "y");
                    break;
            }
        }

        public void Ninja(Movement.Move Move)
        {
            int Ver = 0, Hor = 0;
            switch (Move.Direction)
            {
                case Movement.DirectionType.Up:
                    Ver = -1;
                    break;
                case Movement.DirectionType.Down:
                    Ver = 1;
                    break;
                case Movement.DirectionType.Left:
                    Hor = -1;
                    break;
                case Movement.DirectionType.LeftUp:
                    Hor = -1;
                    Ver = -1;
                    break;
                case Movement.DirectionType.LeftDown:
                    Hor = -1;
                    Ver = 1;
                    break;
                case Movement.DirectionType.Right:
                    Hor = 1;
                    break;
                case Movement.DirectionType.RightUp:
                    Hor = 1;
                    Ver = -1;
                    break;
                case Movement.DirectionType.RightDown:
                    Hor = 1;
                    Ver = 1;
                    break;
            }
            Send("m", Move.PrecisePosition.X, Move.PrecisePosition.Y, Move.Speed.X, Move.Speed.Y, Move.Modifier.X, Move.Modifier.Y, Hor, Ver, WorldMap.Gravity, Move.Jump);
        }

        public void Ninja(Position Position)
        {
            Send("m", Position.X * 16, Position.Y * 16, 0, 0, 0, 0, 0, 0, WorldMap.Gravity, true);
        }

        public void DrinkPotion(int Potion)
        {
            Send(WorldMap.Key + "p", Potion);
        }

        public void Touch(Players.IPlayer Player, int Potion)
        {
            Send("touch", Player.ID, Potion);
        }
    }
}
