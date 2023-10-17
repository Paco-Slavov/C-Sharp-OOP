namespace MuOnline.Repositories.Interfaces
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        IReadOnlyCollection<T> Repository { get; }

        void Add(T item);

        bool Remove(T item);

        T Get(string item);
    }
}