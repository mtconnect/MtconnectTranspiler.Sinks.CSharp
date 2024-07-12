namespace MtconnectTranspiler.Sinks.CSharp.Example
{
    public static class TypeCache
    {
        private static Dictionary<string, string> _types = new Dictionary<string, string>();

        public static void RegisterType(string typeName, string @namespace)
        {
            if (!_types.ContainsKey(typeName))
                _types.Add(typeName, @namespace);
        }

        public static string GetTypeNamespace(string typeName)
            => _types.TryGetValue(typeName, out string foundNamespace) ? foundNamespace : null;
    }
}
