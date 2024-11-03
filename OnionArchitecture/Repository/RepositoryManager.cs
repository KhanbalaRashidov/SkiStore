using Contracts;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {

        private readonly RepositoryContext _repositoryContext;
       

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IProductRepository ProductRepository => throw new NotImplementedException();

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();

    }
}
