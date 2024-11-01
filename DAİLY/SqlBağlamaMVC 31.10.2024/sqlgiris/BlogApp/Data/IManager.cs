using System;

namespace BlogApp.Data;

public interface IManager<T>
{
    public IEnumerable<T> GetAll();
}
