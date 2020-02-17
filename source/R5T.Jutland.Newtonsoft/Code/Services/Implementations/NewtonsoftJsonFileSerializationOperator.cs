using System;


namespace R5T.Jutland.Newtonsoft
{
    public class NewtonsoftJsonFileSerializationOperator : IJsonFileSerializationOperator
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
