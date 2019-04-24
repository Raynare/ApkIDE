using System;
using System.IO;

public class CodeFile
{
	public CodeFile(String path)
	{
        codeLines = File.ReadAllLines(path);
        /* Such delimeter won't work on MacOS */
        name = path.Substring(path.LastIndexOf("\\") + 1);
	}

    public String[] GetCodeLines()
    {
        return codeLines;
    }

    public String GetFileName()
    {
        return name;
    }

    private String name;
    private String[] codeLines;
}
