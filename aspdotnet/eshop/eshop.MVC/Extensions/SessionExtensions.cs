using Newtonsoft.Json;

namespace eshop.MVC.Extensions
{
    public static class SessionExtensions
    {
        public static void SetJson<T>(this ISession session, string key, T value)
        {
            var serialized = JsonConvert.SerializeObject(value);
            session.SetString(key, serialized);

        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var serialized = session.GetString(key);
            return string.IsNullOrEmpty(serialized) ? default(T) : JsonConvert.DeserializeObject<T>(serialized);

        }
    }
}
