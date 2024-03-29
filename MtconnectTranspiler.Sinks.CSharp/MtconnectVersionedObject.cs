﻿using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.Models;
using MtconnectTranspiler.Sinks.ScribanTemplates;
using MtconnectTranspiler.Xmi;

namespace MtconnectTranspiler.Sinks.CSharp
{
    /// <inheritdoc />
    public abstract class MtconnectVersionedObject : VersionedObject
    {
        /// <inheritdoc />
        public MtconnectVersionedObject(XmiDocument model, XmiElement source) : base(model, source) { }

        /// <inheritdoc />
        protected override string lookupMtconnectVersion(string version)
        {
            return MTConnectHelperMethods.LookupMtconnectVersions(version);
        }
    }
}