using BusinessObjects.DTO;
using BusinessObjects.DTO.Other;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class CounterService(ICounterRepository counterRepository) : ICounterService
    {
        private ICounterRepository CounterRepository { get; } = counterRepository;

        public Task<PagingResponse> GetCounterPaging(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<Counter?> GetCounterById(string id)
        {
            return await CounterRepository.GetById(id);
        }

        public Task<int> CreateCounter(CounterDto counterDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateCounter(string id, CounterDto counterDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteCounter(string id)
        {
            throw new NotImplementedException();
        }
    }
}