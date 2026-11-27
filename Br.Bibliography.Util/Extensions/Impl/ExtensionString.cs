namespace Br.Bibliography.Util.Extensions.Impl
{
    public static class ExtensionString
    {
        public static int ParseFromResource(this string s) => int.Parse(s);

        public static string FromParams(char separator, string[] array, string prefix, string enfix)
            => string.Join(separator, array.Prepend(enfix).ToArray().Prepend(prefix));

        public static string FromParams(char separator, string[] array, string prefix)
            => string.Join(separator, array.Prepend(prefix));

        public static string FromParams(char separator, string[] array)
            => string.Join(separator, array);
    }
}
