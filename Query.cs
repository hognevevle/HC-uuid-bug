using System;

namespace HcGuid
{
    public class Query
    {
        public string GetFoo(Guid id) => $"Hey {id}";
    }
}