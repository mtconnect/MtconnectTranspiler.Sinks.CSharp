using Scriban.Runtime;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi.Profile;
using MtconnectTranspiler.Xmi.UML;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class MTConnectHelperMethods : ScriptObject
    {
        public static Normative LookupNormative(MTConnectModel model, string id) => MtconnectTranspiler.Contracts.MTConnectHelper.LookupNormative(model, id);
        public static Deprecated LookupDeprecated(MTConnectModel model, string id) => MtconnectTranspiler.Contracts.MTConnectHelper.LookupDeprecated(model, id);

        // TODO: Remove these references to MtconnectVersions and leave that up to MtconnectCore
        public static Dictionary<string, string> VersionEnumLookup { get; set; } = new Dictionary<string, string>()
        {
            { "1.0", "MtconnectVersions.V_1_0_1" },
            { "1.1", "MtconnectVersions.V_1_1_0" },
            { "1.2", "MtconnectVersions.V_1_2_0" },
            { "1.3", "MtconnectVersions.V_1_3_0" },
            { "1.4", "MtconnectVersions.V_1_4_0" },
            { "1.5", "MtconnectVersions.V_1_5_0" },
            { "1.6", "MtconnectVersions.V_1_6_0" },
            { "1.7", "MtconnectVersions.V_1_7_0" },
            { "1.8", "MtconnectVersions.V_1_8_0" },
            { "2.0", "MtconnectVersions.V_2_0_0" },
            { "2.1", "MtconnectVersions.V_2_1_0" }
        };
        public static string LookupMtconnectVersions(string version)
        {
            if (version == null) return null;
            if (!VersionEnumLookup.TryGetValue(version, out string versionEnum)) return null;
            return versionEnum;
        }

        public static string LookupCsharpDataType(MTConnectModel model, UmlProperty property)
        {
            if (property == null) return null;
            var dataType = LookupDataType(model, property);
            if (dataType == null)
                return "object";
            if (!UmlToCsharpDataTypes.TryGetValue(dataType.Name, out System.Type type)) return "object";
            return type.Name;
        }

        public static UmlDataType LookupDataType(MTConnectModel model, UmlProperty property)
        {
            var dataTypes = model?.AllDataTypes;
            return dataTypes
                ?.Where(o => o.Id == property?.PropertyType)
                ?.FirstOrDefault();
        }
        public static Dictionary<string, System.Type> UmlToCsharpDataTypes = new Dictionary<string, System.Type>()
        {
            { "boolean", typeof(bool) },
            { "ID", typeof(string) },
            { "string", typeof(string) },
            { "float", typeof(float) },
            { "datetime", typeof(DateTime) },
            { "integer", typeof(int) },
            { "xlinktype", typeof(string) },
            { "xslang", typeof(string) },
            { "SECOND", typeof(float) },
            { "IDREF", typeof(string) },
            { "xlinkhref", typeof(string) },
            { "MILLIMETER", typeof(float) },
            { "DEGREE", typeof(float) },
            { "x509", typeof(string) },
            { "unit", typeof(float) },
            { "CUBIC_MILLIMETER", typeof(float) },
            { "int32", typeof(int) },
            { "int64", typeof(long) },
            { "version", typeof(string) },
            { "uint32", typeof(uint) },
            { "uint64", typeof(ulong) },
        };
    }
}
