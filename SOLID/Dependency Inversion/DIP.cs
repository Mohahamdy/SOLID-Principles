////Problems The FileProcessor Class is Tightly Coupling With FileReader and FileWriter Classes and is Dependant on them as we use new
//public class FileProcessor
//{
//    private FileReader _fileReader;
//    private FileWriter _fileWriter;
//    public FileProcessor()
//    {
//        _fileReader = new FileReader();
//        _fileWriter = new FileWriter();
//    }
//    public void ProcessFile(string inputFilePath, string outputFilePath)
//    {
//        string fileContent = _fileReader.ReadFile(inputFilePath);
//        // Process the file content
//        _fileWriter.WriteFile(outputFilePath, fileContent);
//    }
//}

//public class FileReader
//{
//    public string ReadFile(string filePath)
//    {
//        // Code to read file content
//        return "File content";
//    }
//}
//public class FileWriter
//{
//    public void WriteFile(string filePath, string content)
//    {
//        // Code to read file content
//    }
//}

/*Need To apply DIP As we need To inject the services in the Constructor so we will Replace the new keyord with our props and let IOC Registers our services*/
public class FileProcessor
{
    private readonly FileWriter fileWriter;
    private readonly FileReader fileReader;

    public FileProcessor(FileWriter fileWriter,FileReader fileReader)
    {
        this.fileWriter = fileWriter;
        this.fileReader = fileReader;
    }
    public void ProcessFile(string inputFilePath, string outputFilePath)
    {
        string fileContent = fileReader.ReadFile(inputFilePath);
        // Process the file content
        fileWriter.WriteFile(outputFilePath, fileContent);
    }
}

public class FileReader
{
    public string ReadFile(string filePath)
    {
        // Code to read file content
        return "File content";
    }
}
public class FileWriter
{
    public void WriteFile(string filePath, string content)
    {
        // Code to read file content
    }
}


