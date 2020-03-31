using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.Converters
{
#pragma warning disable CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>”
    public class SingleOrArrayConverter<T>: JsonConverter
#pragma warning restore CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>”
    {
#pragma warning disable CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>.CanConvert(Type)”
        public override bool CanConvert(Type objectType)
#pragma warning restore CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>.CanConvert(Type)”
        {
            return (objectType == typeof(List<T>));
        }

#pragma warning disable CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>.ReadJson(JsonReader, Type, object, JsonSerializer)”
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
#pragma warning restore CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>.ReadJson(JsonReader, Type, object, JsonSerializer)”
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<List<T>>();
            }
            return new List<T> { token.ToObject<T>() };
        }

#pragma warning disable CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>.WriteJson(JsonWriter, object, JsonSerializer)”
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
#pragma warning restore CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>.WriteJson(JsonWriter, object, JsonSerializer)”
        {
            List<T> list = (List<T>)value;
            if (list.Count == 1)
            {
                value = list[0];
            }
            serializer.Serialize(writer, value);
        }

#pragma warning disable CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>.CanWrite”
        public override bool CanWrite
#pragma warning restore CS1591 // Brak komentarza XML dla widocznego publicznie typu lub składowej „SingleOrArrayConverter<T>.CanWrite”
        {
            get { return true; }
        }
    }
}
