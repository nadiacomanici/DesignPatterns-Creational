using System.IO;

namespace FactoryMethod_Logger_Begin.Classes
{
    public class FileLogSource
    {
        private readonly string _fullFilePath;
        public FileLogSource(string fullFilePath)
        {
            _fullFilePath = fullFilePath;

            // assure that directory exists
            var parentDir = Path.GetDirectoryName(fullFilePath);
            if (Directory.Exists(parentDir) == false)
            {
                Directory.CreateDirectory(parentDir);
            }
        }

        public void AddMessage(MessageType messageType, string message)
        {
            using (var streamWriter = File.AppendText(_fullFilePath))
            {
                streamWriter.WriteLine($"Write {messageType} in file: {message}");
            }
        }
    }
}
