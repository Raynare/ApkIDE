using System;
using System.IO;

public class CodeFile
{
	public CodeFile(string path)
	{
        codeLines = File.ReadAllLines(path);
        /* Such delimeter won't work on MacOS */
        name = path.Substring(path.LastIndexOf("\\") + 1);
	}

    public string[] GetCodeLines()
    {
        return codeLines;
    }

    public string GetFileName()
    {
        return name;
    }

    private string name;
    private string[] codeLines;
}
