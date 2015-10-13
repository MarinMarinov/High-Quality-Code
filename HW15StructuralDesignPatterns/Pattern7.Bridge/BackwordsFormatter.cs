using System.Linq;

namespace Pattern7.Bridge
{
    internal class BackwordsFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            string backwordsValue = new string(value.Reverse().ToArray());
            return string.Format("{0}: {1}", key, backwordsValue);
        }
    }
}