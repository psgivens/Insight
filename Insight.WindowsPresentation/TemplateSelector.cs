using Insight.Sessions.Configuration;
using PhillipScottGivens.Library.AppSessionFramework.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Insight.WindowsPresentation {
    public class DefaultTemplateSelector : UserControlTemplateSelector {
        public DefaultTemplateSelector()
            : base(_userInterfaceAssemblies.ToArray().FirstOrDefault(), "") { }

        private static readonly List<Assembly> _userInterfaceAssemblies = new List<Assembly>();

        public static void AddAssemblies(IEnumerable<Assembly> assemblies) {
            _userInterfaceAssemblies.AddRange(assemblies);
        }

        private static Assembly[] GetUIAssemblies() {
            var config = InsightConfiguration.Instance;
            var appReferences = config.AppReferencesElement.GetAppReferences();
            return appReferences
                .Select(item => Assembly.LoadWithPartialName(item.UIAssemblyName))
                .ToArray();
        }
    }
}
