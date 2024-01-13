using System.Text;

namespace Cssx;

public static class Cssx
{
    public static string Parse(string raw)
    {
        var cssx = new StringBuilder();
        int bracePrev = 0;

        for (
            var braceSrt = raw.IndexOf('{');
            braceSrt > -1;
            braceSrt = raw.IndexOf('{', braceSrt + 1))
        {
            var braceEnd = raw.IndexOf('}', braceSrt);
            cssx.Append(raw[bracePrev..braceSrt]);

            ExecFragment(raw[(braceSrt+1)..braceEnd], cssx);

            bracePrev = braceEnd+1;
        }

        cssx.Append(raw[bracePrev..]);
        return cssx.ToString();
    }

    static void ExecFragment(string fragment, StringBuilder cssx){
        cssx.Append(fragment);
    }
}
