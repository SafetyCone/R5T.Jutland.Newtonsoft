using System;

using R5T.T0064;


namespace R5T.Jutland.Newtonsoft
{
    [ServiceImplementationMarker]
    public class NewtonsoftJsonFileSerializationOperator : IJsonFileSerializationOperator, IServiceImplementation
    {
        public T Deserialize<T>(string jsonFilePath)
        {
            var jsonSerializer = Utilities.GetStandardJsonSerializer();

            var value = jsonSerializer.Deserialize<T>(jsonFilePath);
            return value;
        }

        public void Serialize<T>(string jsonFilePath, T value)
        {
            var jsonSerializer = Utilities.GetStandardJsonSerializer();

            jsonSerializer.Serialize(jsonFilePath, value);
        }
    }
}
