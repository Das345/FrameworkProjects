using System.IO;
using System.Reflection;

namespace DavidBerry.Framework.Util
{
    public static class EmbeddedResourceUtil
    {


        public static string ReadEmbeddedResourceTextFile(this Assembly assembly, string filename)
        {
            var resourceName = $"{assembly.GetName().Name}.{filename}";

            using (StreamReader reader = new(assembly.GetManifestResourceStream(resourceName)))
            {
                string contents = reader.ReadToEnd();
                return contents;
            }
        }





    }
}
