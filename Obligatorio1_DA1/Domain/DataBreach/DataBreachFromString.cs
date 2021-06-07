
namespace Obligatorio1_DA1.Domain
{
    public class DataBreachFromString : DataBreach<string>
    {
        public string Data { set; private get; }

        public string GetDataBreachString()
        {
            return this.Data;
        }
    }
}
