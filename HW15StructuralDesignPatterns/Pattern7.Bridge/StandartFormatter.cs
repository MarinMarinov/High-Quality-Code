namespace Pattern7.Bridge
{
    internal class StandartFormatter :IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, value);
        }
    }
}
