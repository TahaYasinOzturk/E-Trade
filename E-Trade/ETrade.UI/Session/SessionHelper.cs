using ETrade.Ent;
using Newtonsoft.Json;

namespace ETrade.UI.Session
{
    public static class SessionHelper
    {

        //null olabilir ?LoginUser;
        public static Users ?LoginUser;

        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            //setstring string atıyor. setInt var int atıyor. nesne saklarız genelde 
            //onun icin bir key vercez user nesnesini key olarak vercez. value da bizim user olacak.user ı jsona cevirecek.
            
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            //okurkende  deserialiez yaparak user nesnesi olarak geri alacaz.
            
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
