using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DavidBerry.Framework.ApiUtil.Results
{

    /// <summary>
    /// Returns a status 500 (Internal Server Error) result with no message
    /// </summary>
    public class InternalServerErrorResult : StatusCodeResult
    {

        public InternalServerErrorResult() : base(StatusCodes.Status500InternalServerError)
        {

        }

    }
}
