using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Filters
{
    public class IsExistingAttribute : TypeFilterAttribute
    {
        public IsExistingAttribute() : base(typeof(IsExistsFilter))
        {

        }
    }
}
