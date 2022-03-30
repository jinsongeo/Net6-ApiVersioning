using Microsoft.AspNetCore.Mvc;

namespace Net6_ApiVersioning.Code
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class V1Attribute : ApiVersionAttribute
    {
        public V1Attribute() : base(new ApiVersion(1, 0)) { }
    }
}
