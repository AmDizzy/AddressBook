using System.IO;

namespace WpfApp_MVVM.Services;

internal class FileService
{
    private string _filePath;
    public FileService(string filePath)
    {
        _filePath = filePath;
    }




    //public string FilePath { get; set; } = null!;
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
