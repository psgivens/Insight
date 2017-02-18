using Insight.Sessions.Infrastructure;
using PhillipScottGivens.Library.AppSessionFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Sessions {
    [ResolvableBaseType]
    public abstract class ToolViewModelBase : SessionBase {
        public ToolViewModelBase(string title) {
            Title = title;
        }
        public string Title { get; private set; }
    }
}
