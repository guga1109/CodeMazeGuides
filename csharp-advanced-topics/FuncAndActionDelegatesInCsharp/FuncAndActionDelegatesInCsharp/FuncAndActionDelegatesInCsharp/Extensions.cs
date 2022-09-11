namespace FuncAndActionDelegatesInCsharp;

public static class Extensions
{
    public static List<T> NewWhere<T>(this List<T> list, Func<T, bool> func)
    {
        List<T> returnList = new List<T>();

        foreach (T element in list)
        {
            if (func(element))
                returnList.Add(element);
        }

        return returnList;
    }

    public static void ConvertToUppercaseAndDoAction(this string inputString, Action<string> action)
    {
        action(inputString.ToUpper());
    }
}