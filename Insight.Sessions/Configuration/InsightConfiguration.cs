using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Sessions.Configuration {
    public class InsightConfiguration : ConfigurationSection {
        private static object syncObject = new object();
        private static InsightConfiguration _instance;

        [ConfigurationProperty("apps", IsRequired = true)]
        public AppReferences AppReferencesElement {
            get { return (AppReferences)base["apps"]; }
            set { base["apps"] = value; }
        }

        public static InsightConfiguration Instance {
            get {
                lock (syncObject) {
                    if (_instance == null) {
                        _instance = (InsightConfiguration)System.Configuration.ConfigurationManager.GetSection("insight");
                        if (_instance == null) {
                            throw new ConfigurationException("'insight' section not found in configuration file.");
                        }
                    }
                    return _instance;
                }
            }
        }
    }
}
