using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IntruderFPSTool.API
{
    public abstract class APIRequest<T>
    {
        public const string API = "https://api.intruderfps.com";
        public abstract string Path { get; }

        protected string BuildUrlParameters()
        {
            StringBuilder builder = new();
            Type type = GetType();

            foreach (PropertyInfo prop in type.GetProperties())
            {
                UrlParameterAttribute? attr = prop.GetCustomAttribute<UrlParameterAttribute>();
                if (attr == null) continue;

                object? value = prop.GetValue(this);
                if (value == null) continue;

                string? name = attr.Name == null ? prop.Name : attr.Name;
                builder.Append($"{name}={attr.Converter.Invoke(value)}&");
            }

            if (builder.Length > 0)
                builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }
        protected Uri BuildRequestUri()
        {
            string parameters = BuildUrlParameters();
            string url = $"{API}{Path}";

            if (parameters.Length > 0)
                url += $"?{parameters}";

            return new(url);
        }

        public async Task<APIResponse<T>> SendAsync()
        {
            HttpClient client = new();
            Uri uri = BuildRequestUri();

            HttpResponseMessage msg = await client.GetAsync(uri);

            if (msg.StatusCode != HttpStatusCode.OK)
                return new(default(T), await msg.Content.ReadAsStringAsync(), false);

            T? response = await JsonSerializer.DeserializeAsync<T>(await msg.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions()
                {
                    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    NumberHandling = JsonNumberHandling.AllowReadingFromString
                });

            return new(response, null, response != null);
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class UrlParameterAttribute : Attribute
    {
        public delegate string? ValueConverter(object value);
        public ValueConverter Converter { get; set; }
        public string? Name { get; set; } = null;

        public UrlParameterAttribute()
        {
            Converter = DefaultConverter;
        }

        public string? DefaultConverter(object value) => value.ToString();
    }
}
