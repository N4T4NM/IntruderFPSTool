using System.Text.RegularExpressions;

namespace IntruderFPSTool.Utils
{
    public static class Extensions
    {
        public delegate void OnTaskDispatch<T>(T value);
        public static void DispatchAsyncTask<T>(this Control control, Task<T> task, OnTaskDispatch<T> dispatch)
        {
            new Task(async () =>
            {
                T result = await task;
                try { control.Invoke(dispatch, result); } catch (Exception ex) { }
            }).Start();
        }

        static Regex tagRegex = new(@"<\/?(.*?)>");
        public static string RemoveTags(this string str)
            => tagRegex.Replace(str, "");

        public static Dictionary<TKey, TValue> Clone<TKey, TValue>(this Dictionary<TKey, TValue> dict) where TKey : notnull
        {
            Dictionary<TKey, TValue> clone = new();

            foreach (TKey? key in dict.Keys)
                clone.Add(key, dict[key]);

            return clone;
        }
    }
}
