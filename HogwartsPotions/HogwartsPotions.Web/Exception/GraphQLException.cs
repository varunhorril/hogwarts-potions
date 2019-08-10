using System;

namespace HogwartsPotions.Web.Exception
{
    public class GraphQLException : ApplicationException
    {
        public GraphQLException(string message) : base(message)
        {

        }
    }
}
