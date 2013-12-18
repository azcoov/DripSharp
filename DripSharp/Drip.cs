using System.IO;

namespace DripSharp
{
    public static class Drip
    {
        public static Event Parse(Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            var json = new StreamReader(stream).ReadToEnd();

            return DripEventUtility.Parse(json);
        }
    }
}
