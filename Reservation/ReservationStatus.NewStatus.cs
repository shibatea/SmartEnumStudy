namespace SmartEnumStudy.Reservation
{
    public abstract partial class ReservationStatus
    {
        private sealed class NewStatus : ReservationStatus
        {
            public NewStatus() : base("New", 0)
            {
            }

            public override bool CanTransitionTo(ReservationStatus next)
            {
                return next == Accepted || next == Cancelled;
            }
        }
    }
}