namespace CTWAnalysis.Domain.Events;

using CTWAnalysis.Domain.Common;

public sealed record KillEvent(
    double Time, 
    int ParticipantId, 
    Position Position,
    Inventory Inventory,
    int VictimId
) : GameEvent(Time, ParticipantId, Position);