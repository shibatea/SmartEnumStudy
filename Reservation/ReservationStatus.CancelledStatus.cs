namespace SmartEnumStudy.Reservation
{
    public abstract partial class ReservationStatus
    {
        private sealed class CancelledStatus : ReservationStatus
        {
            public CancelledStatus() : base("Cancelled", 3)
            {
            }

            public override bool CanTransitionTo(ReservationStatus next)
            {
                return false;
            }
        }
    }
}