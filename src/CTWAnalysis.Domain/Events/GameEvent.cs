namespace CTWAnalysis.Domain.Events;

using CTWAnalysis.Domain.Common;

public abstract record GameEvent(double Time, int ParticipantId, Position Position);