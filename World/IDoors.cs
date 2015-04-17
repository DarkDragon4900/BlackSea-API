namespace BlackSea.World
{
    public enum DoorType { Red, Green, Blue, Cyan,Magenta, Yellow, Time};

    public interface IDoors
    {
        bool IsRedDoorClosed { get; }
        bool IsGreenDoorClosed { get; }
        bool IsBlueDoorClosed { get; }
        bool IsCyanDoorClosed { get; }
        bool IsMagentaDoorClosed { get; }
        bool IsYellowDoorClosed { get; }
        bool IsTimeDoorClosed { get; }
    }
}
