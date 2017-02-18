using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Sessions.Configuration {
    [ConfigurationCollection(typeof(AppReference), AddItemName = "app", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class AppReferences : ConfigurationElementCollection {
        [ConfigurationProperty("default", IsRequired = false)]
        public AppReference Default {
            get {
                return (AppReference)base["default"];
            }
        }

        public IEnumerable<AppReference> GetAppReferences() {
            foreach (var appReference in this) {
                yield return (AppReference)appReference;
            }
        }

        protected override ConfigurationElement CreateNewElement() {
            return new AppReference();
        }

        protected override object GetElementKey(ConfigurationElement element) {
            return ((AppReference)element).AppAssemblyName;
        }
    }
}
