static class LogLine
{
    public static string Message(string logLine)
    {
        var  l = logLine.Split(":");
        var x1 = l[1];
        var ms = x1.Trim();
        return  ms;
    }

    public static string LogLevel(string logLine)
    {
        var Lv = logLine.Split(":");
        var Lv1 = Lv[0];
        var t = Lv1.Replace("[","").Replace("]","");
        var p = t.ToLower();
        return p;
    }

    public static string Reformat(string logLine)
    {
       return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
