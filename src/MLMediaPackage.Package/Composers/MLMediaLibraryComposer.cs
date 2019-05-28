using MLMediaPackage.Package.Sections;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace MLMediaPackage.Package.Composers
{
    public class MLMediaLibraryComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Sections().Append<MLMediaSection>();
        }
    }
}
