
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public static class SessionHelper
    {
        //public static void SetObjectAsJson(this ISession session, string key, object value)
        //{
        //    string objectString = JsonConvert.SerializeObject(value);
        //    session.SetString(key, objectString);
        //}

        //public static T GetObjectFromJson<T>(this ISession session, string key) where T : class
        //{
        //    string objectString = session.GetString(key);
        //    return objectString == null ? default(T) : JsonConvert.DeserializeObject<T>(objectString);
        //}
    }
}
