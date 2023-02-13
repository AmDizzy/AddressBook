using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Services;

internal class FileService
{
    private string _filePath;
    public FileService(string filePath)
    {
        _filePath = filePath;
    }

    public void Save(string content)
    {
        using var sw = new StreamWriter(_filePath);
        sw.WriteLine(content);
    }

    public string Read()
    {
        try
        {
            using var sr = new StreamReader(_filePath);
            return sr.ReadToEnd();
        }
        catch { return null!; }
    }
}
