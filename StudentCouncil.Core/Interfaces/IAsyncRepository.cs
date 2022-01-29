namespace StudentCouncil.Core.Interfaces
{
    public interface IAsyncRepository<T> where T:class
    {
        public Task<T> GetAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> CreateAsync(T model);
        public Task<T> UpdateAsync(int id, T model);
        public Task DeleteAsync(int id);
    }
}