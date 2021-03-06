using System;
using Newtonsoft.Json;
using NodaTime;
using NodaTime.Serialization.JsonNet;
using Swashbuckle.Swagger;
using Xunit;

namespace MicroElements.Swashbuckle.NodaTime.Tests
{
    public class SchemasTests
    {
        private readonly JsonSerializerSettings _serializerSettings =
            new JsonSerializerSettings().ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);

        T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json, _serializerSettings);

        //void tryDeserializeExample<T>(Schema schema) =>
        //schema.example
        //|> string
        //|> JsonConvert.SerializeObject
        //|> deserialize<'T>
        //|> ignore

        [Fact]
        public void Sum()
        {
            Schemas schemas = new SchemasFactory(_serializerSettings).CreateSchemas();
        }

    }
}
