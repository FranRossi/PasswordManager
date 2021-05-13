
namespace Obligatorio1_DA1.Utilities
{
    public interface IDataBreach<T>
    {
        T Data { set; }
        string GetDataBreachString();
    }
}
