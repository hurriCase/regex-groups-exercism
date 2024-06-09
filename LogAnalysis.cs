using System;
using System.Text.RegularExpressions;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string substring) =>
        Regex.Match(
            str,
            $"{substring}(?<substring>.*)"
        ).Groups["substring"].ToString();
    
    public static string SubstringBetween(this string str, string sub1, string sub2) =>
        Regex.Match(
            str,
            $@"\{sub1}(?<substring>.*)\{sub2}"
        ).Groups["substring"].ToString();

    public static string Message(this string str) =>
        str.SubstringAfter("]: ");

    public static string LogLevel(this string str) =>
        str.SubstringBetween("[", "]");
}