
namespace Obligatorio1_DA1.Utilities
{
    public class DataBreachFromString : IDataBreach<string>
    {
        public string Data { set; private get; }

        public string GetDataBreachString()
        {
            return this.Data;
        }
    }
}
