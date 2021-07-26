using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace korsback.dotnet.extensions
{

    public static class TestExtensions
    {
        public static StringContent ToStringContent<T>(this T e) where T : class
        {
            return new StringContent(JsonConvert.SerializeObject(e), Encoding.UTF8, "application/json");
        }

        public static T ToEntity<T>(this string s)
        {
            return JsonConvert.DeserializeObject<T>(s);
        }
    }
}