namespace CTWAnalysis.Domain.Events;

using CTWAnalysis.Domain.Common;

public sealed record SpawnEvent(
    double Time, 
    int ParticipantId, 
    Position Position
) : GameEvent(Time, ParticipantId, Position);