namespace CTWAnalysis.Domain.Events;

using CTWAnalysis.Domain.Common;

public sealed record CaptureEvent(
    double Time, 
    int ParticipantId, 
    Position Position,
    int ObjectiveId
) : GameEvent(Time, ParticipantId, Position);