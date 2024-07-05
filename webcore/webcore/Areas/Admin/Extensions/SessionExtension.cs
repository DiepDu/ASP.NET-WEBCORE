using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace webcore.Areas.Admin.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session,string key, object Value) {
            session.SetString(key, JsonConvert.SerializeObject(Value, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }));
        }
        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default: JsonConvert.DeserializeObject<T>(value);
        }
    }
}
