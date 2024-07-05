using BusinessObjects.DTO;
using BusinessObjects.DTO.Other;
using BusinessObjects.Models;

namespace Services.Interface;

public interface ICounterService
{
    public Task<PagingResponse> GetCounterPaging(int pageNumber, int pageSize);
    public Task<Counter?> GetCounterById(string id);
    public Task<int> CreateCounter(CounterDto counterDto);
    public Task<int> UpdateCounter(string id,CounterDto counterDto);
    public Task<int> DeleteCounter(string id);
}