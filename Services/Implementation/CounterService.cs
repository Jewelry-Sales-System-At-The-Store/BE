using System.Diagnostics.Metrics;
using BusinessObjects.DTO;
using BusinessObjects.Dto.Counter;
using BusinessObjects.Dto.Other;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class CounterService(ICounterRepository counterRepository) : ICounterService
    {
        private ICounterRepository CounterRepository { get; } = counterRepository;

        public async Task<IEnumerable<Counter>?> GetCounters()
        {
            return await CounterRepository.Gets();
        }

        public async Task<Counter?> GetCounterById(string id)
        {
            return await CounterRepository.GetById(id);
        }

        public async Task<int> CreateCounter(CounterDto counterDto)
        {
            return await CounterRepository.Create(counterDto);
        }
        public async Task CreateCounterMongo(CounterStatus counterDto)
        {
            await CounterRepository.AddMongo(counterDto);
        }

        public async Task<int> UpdateCounter(string id, UpdateCounter counterDto)
        {
            return await CounterRepository.Update(id, counterDto);
        }

        public async Task<int> DeleteCounter(string id)
        {
            return await CounterRepository.Delete(id);
        }
        
        public async Task<IEnumerable<CounterStatus>> GetAvailableCounters()
        {
            return await CounterRepository.GetAvailableCounters();
        }
    }
}