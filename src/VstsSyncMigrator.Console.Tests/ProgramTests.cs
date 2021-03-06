using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using VstsSyncMigrator.Engine.Configuration;
using VstsSyncMigrator.Engine.Configuration.FieldMap;
using System.IO;

namespace VstsSyncMigrator.Console.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestSeraliseToJson()
        {
            string json = JsonConvert.SerializeObject(EngineConfiguration.GetDefault(),
                    new FieldMapConfigJsonConverter(),
                    new ProcessorConfigJsonConverter());
            StreamWriter sw = new StreamWriter("vstsbulkeditor.json");
            sw.WriteLine(json);
            sw.Close();

        }

        [TestMethod]
        public void TestDeseraliseFromJson()
        {
            EngineConfiguration ec;
            StreamReader sr = new StreamReader("vstsbulkeditor.json");
            string vstsbulkeditorjson = sr.ReadToEnd();
            sr.Close();
            ec = JsonConvert.DeserializeObject<EngineConfiguration>(vstsbulkeditorjson,
                new FieldMapConfigJsonConverter(),
                new ProcessorConfigJsonConverter());

        }
    }
}
