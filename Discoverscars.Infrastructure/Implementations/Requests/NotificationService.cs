using Discovercars.Domain.Entity;
using Discoverscars.Infrastructure.Interfaceses;

namespace Discoverscars.Infrastructure.Implementations.Requests
{
    public class NotificationService : INotificationService
    {
        public async Task<bool> Notification(Reservation reservation) => await Task.FromResult(true);
    }

}

