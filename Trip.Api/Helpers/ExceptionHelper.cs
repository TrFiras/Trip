using System;

namespace Trip.API.Helpers
{
    public static class ExceptionHelper
    {
        public static string GetExceptionMassage(Exception exception)
        {
            return exception.InnerException != null ? exception.InnerException.Message : exception.Message;
        }
    }
}
