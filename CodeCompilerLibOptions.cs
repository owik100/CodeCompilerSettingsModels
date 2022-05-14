using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCompilerSettingsModels
{
    public class CodeCompilerLibOptions
    {
        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public bool BuildToConsoleApp { get; set; }
    }
}
