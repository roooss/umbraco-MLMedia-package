using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Dashboards;

namespace MLMediaPackage.Package.Dashboards
{
    [Weight(2)]
    public class MLMediaLibraryMainDashboard : IDashboard
    {
        public string[] Sections => new string[] { "MLMediaLibrarySection" };

        public IAccessRule[] AccessRules
        {
            get
            {
                var rules = new IAccessRule[]
                {
                    new AccessRule {Type = AccessRuleType.Grant, Value = Constants.Security.AdminGroupAlias}
                };

                return rules;
            }
        }


        public string Alias => "MyDashoard";

        public string View => "/App_Plugins/MLMediaLibrary/html/MyDashboard.html";
    }
}
