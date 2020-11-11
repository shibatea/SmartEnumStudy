using Ardalis.SmartEnum;

namespace SmartEnumStudy.Reservation
{
    /// <summary>
    /// 現在の状態から遷移が許可されている場合に true を返すクラス()
    /// </summary>
    public abstract partial class ReservationStatus : SmartEnum<ReservationStatus>
    {
        public static readonly ReservationStatus New = new NewStatus();
        public static readonly ReservationStatus Accepted = new AcceptedStatus();
        public static readonly ReservationStatus Paid = new PaidStatus();
        public static readonly ReservationStatus Cancelled = new CancelledStatus();

        private ReservationStatus(string name, int value) : base(name, value)
        {
        }

        public abstract bool CanTransitionTo(ReservationStatus next);
    }
}