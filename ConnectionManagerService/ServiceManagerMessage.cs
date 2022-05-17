using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCompilerSettingsModels.ConnectionManagerService
{
    public class ServiceManagerMessage
    {
        public ServiceManagerMessage(MessageHandlingLevel messageLevel, string message)
        {
            MessageLevel = messageLevel;
            Message = message;
        }

        public MessageHandlingLevel MessageLevel{ get; set; }
        public string Message { get; set; }
    }

    public enum MessageHandlingLevel
    {
        ServiceInfo,
        ServiceError
    }
}
