﻿namespace Discoverscars.Infrastructure.Interfaceses.Requests
{
    public interface IRequestService
    {
        public Task<Tout> GetAsync<Tout>(string url);

        public Task<Tout> Send<Tout, Tin>(string url, Tin request);
    }
}
