using StudentCouncil.Core.Interfaces;

namespace StudentCouncil.Core.Repositories
{
    public class FileStructureRepository : IAsyncRepository<FileStructure>
    {
        public Task<FileStructure> CreateAsync(FileStructure model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileStructure>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FileStructure> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FileStructure> UpdateAsync(int id, FileStructure model)
        {
            throw new NotImplementedException();
        }
    }
}