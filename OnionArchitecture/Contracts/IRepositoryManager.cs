namespace Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        Task SaveAsync();
    }
}
