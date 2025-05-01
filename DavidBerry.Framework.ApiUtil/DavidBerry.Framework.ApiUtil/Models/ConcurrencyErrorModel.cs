namespace DavidBerry.Framework.ApiUtil.Models
{
    public class ConcurrencyErrorModel<T>
    {

        public string Message { get; set; }

        public T CurrentObject { get; set; }
    }
}
