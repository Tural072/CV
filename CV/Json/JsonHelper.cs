﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    public static class JsonFileHelper
    {
        public const string fileName = "database.json";
        public static void JsonSerialization(DB database)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonTextWriter, database);
                }
            }
        }
        public static void JsonDeSerialization(ref DB database)
        {
            var serializer = new JsonSerializer();

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    database = serializer.Deserialize<DB>(jsonTextReader);
                }
            }
        }

    }
}
