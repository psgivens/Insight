using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Sessions.Configuration {
    public class AppReference : ConfigurationElement {
        [ConfigurationProperty("appAssembly", IsRequired = true)]
        public string AppAssemblyName {
            get { return (string)base["appAssembly"]; }
            set { base["appAssembly"] = value; }
        }

        [ConfigurationProperty("uiAssembly", IsRequired = true)]
        public string UIAssemblyName {
            get { return (string)base["uiAssembly"]; }
            set { base["uiAssembly"] = value; }
        }

        [ConfigurationProperty("rootType", IsRequired = false)]
        public string RootTypeName {
            get { return (string)base["rootType"]; }
            set { base["rootType"] = value; }
        }
    }
}
