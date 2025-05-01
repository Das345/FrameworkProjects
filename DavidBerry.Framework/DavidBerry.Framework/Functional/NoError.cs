namespace DavidBerry.Framework.Functional
{
    public sealed class NoError : Error
    {

        private NoError() : base(string.Empty)
        {

        }



        public static readonly NoError NO_ERROR = new();


    }
}
