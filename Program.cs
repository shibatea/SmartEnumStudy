using System;
using System.Linq;
using SmartEnumStudy.Reservation;

namespace SmartEnumStudy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                var fromName = TestEnum.FromName("One");
                Console.WriteLine($"Name:{fromName.Name}, Value:{fromName.Value}"); // Name:One, Value:1
                var fromValue = TestEnum.FromValue(2);
                Console.WriteLine($"Name:{fromValue.Name}, Value:{fromValue.Value}"); // Name:Two, Value:2
            }

            {
                var fromName = TestEnum2.FromName("A string!");
                Console.WriteLine($"Name:{fromName.Name}, Value:{fromName.Value}"); // Name:A string!, Value:1
                var fromValue = TestEnum2.FromValue(2);
                Console.WriteLine($"Name:{fromValue.Name}, Value:{fromValue.Value}"); // Name:Another string!, Value:2
            }

            {
                var fromName = TestEnum3.FromName("Three");
                Console.WriteLine($"Name:{fromName.Name}, Value:{fromName.Value}"); // Name:Three, Value:3
                var fromValue = TestEnum3.FromValue(3);
                Console.WriteLine($"Name:{fromValue.Name}, Value:{fromValue.Value}"); // Name:AnotherThree, Value:3
            }

            {
                Console.WriteLine(GetBonusSize("Manager")); // Manager's bonus is 10000
                Console.WriteLine(GetBonusSize("Assistant")); // Assistant's bonus is 1000
            }

            {
                foreach (var oldStatus in ReservationStatus.List.OrderBy(r => r.Value))
                foreach (var newStatus in ReservationStatus.List.OrderBy(r => r.Value))
                    Console.WriteLine(
                        $"{oldStatus.Value}:{oldStatus.Name} => {newStatus.Name} = {oldStatus.CanTransitionTo(newStatus)}");
                // 0:New => New = False
                // 0:New => Accepted = True
                // 0:New => Paid = False
                // 0:New => Cancelled = True
                // 1:Accepted => New = False
                // 1:Accepted => Accepted = False
                // 1:Accepted => Paid = True
                // 1:Accepted => Cancelled = True
                // 2:Paid => New = False
                // 2:Paid => Accepted = False
                // 2:Paid => Paid = False
                // 2:Paid => Cancelled = True
                // 3:Cancelled => New = False
                // 3:Cancelled => Accepted = False
                // 3:Cancelled => Paid = False
                // 3:Cancelled => Cancelled = False
            }
        }

        private static string GetBonusSize(string managerName)
        {
            var employeeType = EmployeeType.FromName(managerName);
            return $"{employeeType.Label()} {employeeType.BonusSize}";
        }
    }
}