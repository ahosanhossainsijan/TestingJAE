using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingJAE.Utility
{
    public class JsonUtils
    {
        public static string GetConfigData(string key)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\.."));
            string configFilePath = Path.Combine(projectRoot, "Data", "Config.json");
            string jsonData = File.ReadAllText(configFilePath);
            JObject testData = JObject.Parse(jsonData);
            return (string)testData[key];
        }
    }
}
