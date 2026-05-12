namespace CTWAnalysis.Domain.Events;

using CTWAnalysis.Domain.Common;

public sealed record TouchEvent(
    double Time, 
    int ParticipantId, 
    Position Position,
    int ObjectiveId
) : GameEvent(Time, ParticipantId, Position);