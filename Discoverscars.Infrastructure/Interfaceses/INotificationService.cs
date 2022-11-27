using Discovercars.Domain.Entity;

namespace Discoverscars.Infrastructure.Interfaceses
{
    public interface INotificationService
    {
        public Task<bool> Notification(Reservation reservation);
    }
}
