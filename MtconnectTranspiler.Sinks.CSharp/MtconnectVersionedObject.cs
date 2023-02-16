using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi;

namespace MtconnectTranspiler.Sinks.CSharp
{
    public class MtconnectVersionedObject : VersionedObject
    {
        public MtconnectVersionedObject(MTConnectModel model, XmiElement source) : base(model, source) { }

        protected override string lookupMtconnectVersion(string version)
        {
            return MTConnectHelperMethods.LookupMtconnectVersions(version);
        }
    }
}