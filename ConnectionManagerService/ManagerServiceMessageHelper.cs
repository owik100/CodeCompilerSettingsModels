using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCompilerSettingsModels.ConnectionManagerService
{

        public class ManagerServiceMessageHelper
        {
            public Type Type { get; set; }
            public JToken Value { get; set; }

            public static ManagerServiceMessageHelper FromValue<T>(T value)
            {
                return new ManagerServiceMessageHelper { Type = typeof(T), Value = JToken.FromObject(value) };
            }

            public static string Serialize(ManagerServiceMessageHelper message)
            {
                return JToken.FromObject(message).ToString();
            }

            public static ManagerServiceMessageHelper Deserialize(string data)
            {
                return JToken.Parse(data).ToObject<ManagerServiceMessageHelper>();
            }
        }
}
