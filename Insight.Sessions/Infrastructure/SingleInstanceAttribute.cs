using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Sessions.Infrastructure {
    [AttributeUsage(AttributeTargets.Class)]
    public class SingleInstanceAttribute : Attribute {
        public static bool IsSingleInstance(Type type) {
            return type.IsDefined(typeof(SingleInstanceAttribute), true);
        }
    }
}
