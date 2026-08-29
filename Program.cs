class splits
{
    public static String[] nonulls(String strings, String separator)
    {
        String[] s = { };
        int i = 0;
        String ss = strings;
        String s1 = "";
        while (true)
        {
            i = ss.IndexOf(separator);
            if (i == -1)
            {
                
                ss=ss.Trim();
                if (ss.Length != 0) 
                {
                    Array.Resize(ref s, s.Length + 1);
                    s[s.Length - 1] = ss;
                }
                
                break;
            }
            s1 = ss.Substring(0, i);
            s1 = s1.Trim();
            if (s1.Length != 0)
            {
                //Console.WriteLine(ss.Length);
                Array.Resize(ref s, s.Length + 1);
                s[s.Length - 1] = s1;
            }
            if (i + separator.Length >= ss.Length - 1) break;
            ss = ss.Substring(i + separator.Length);




        }


        return s;



    }



}

class splitstests
{
    public static void mainloop()

    {
        String s = "<!><!>0<!>01<!>012<!>0123<!>01234<!>012345<!>0123456<!>01234567<!>012345678<!>0123456789<!>0123456789A<!>";
        String[] ss = splits.nonulls(s, "<!>");
        foreach (var sss in ss)
        {
            Console.WriteLine(sss);


        }


    }



}











class snonull


{
    public static void Main()
    {

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        splitstests.mainloop();



    }




}

