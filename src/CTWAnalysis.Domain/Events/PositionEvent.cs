namespace CTWAnalysis.Domain.Events;

using CTWAnalysis.Domain.Common;

public sealed record PositionEvent(
    double Time, 
    int ParticipantId, 
    Position Position,
    Inventory Inventory
) : GameEvent(Time, ParticipantId, Position);