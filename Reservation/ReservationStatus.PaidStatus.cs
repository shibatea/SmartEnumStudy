namespace SmartEnumStudy.Reservation
{
    public abstract partial class ReservationStatus
    {
        private sealed class PaidStatus : ReservationStatus
        {
            public PaidStatus() : base("Paid", 2)
            {
            }

            public override bool CanTransitionTo(ReservationStatus next)
            {
                return next == Cancelled;
            }
        }
    }
}