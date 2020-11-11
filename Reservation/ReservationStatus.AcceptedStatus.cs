namespace SmartEnumStudy.Reservation
{
    public abstract partial class ReservationStatus
    {
        private sealed class AcceptedStatus : ReservationStatus
        {
            public AcceptedStatus() : base("Accepted", 1)
            {
            }

            public override bool CanTransitionTo(ReservationStatus next)
            {
                return next == Paid || next == Cancelled;
            }
        }
    }
}