using Discovercars.Domain.Entity;

namespace Discovercars.ApplicationServices.Interfaces.Request.RequestServices
{
    public interface ILocationService
    {
        public Task<IEnumerable<Location>> GetAllAsync();
    }
}
