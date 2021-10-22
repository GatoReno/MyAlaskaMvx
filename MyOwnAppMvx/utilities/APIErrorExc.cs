using System;
using System.Net;

namespace MyOwnAppMvx.utilities
{
    public class APIErrorExc : Exception
    {
        public string ApiError { get; private set; }
        public HttpStatusCode HttpStatusCode { get; private set; }

        public APIErrorExc(string error, HttpStatusCode httpStatusCode)
        {
            ApiError = error;
            HttpStatusCode = httpStatusCode;
        }
    }
}
