using Microsoft.Extensions.Localization;
using testdata.Business.Concrete;

namespace testdata.Business.Contract
{
    public class CommonResource<T> : ICommonResource<T> where T: class
    {
        private readonly IStringLocalizer<T> _localizer;

        public CommonResource(IStringLocalizer<T> localizer)
        {
            _localizer = localizer;
        }

        public string GetString(string name)
        {
            return _localizer[name];
        }
    }
}
