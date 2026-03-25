using CycloneDX.Json;
using CycloneDX.Models;
using LL.MDE.Components.Qvt.Common.DataModels;
using System;
using System.IO;

namespace MDD4All.QVT.Transformations.CycloneDxTest1.Configuration
{
    public class CycloneDxJsonSerializer : IDomainJsonSerializer
    {
        public void SerializeToJsonFile(string path, Type type, object data)
        {
            if (data is Bom)
            {
                string json = Serializer.Serialize((Bom)data);
                File.WriteAllText(path, json);
            }
        }
    }
}
