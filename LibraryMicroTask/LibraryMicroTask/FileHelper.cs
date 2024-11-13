namespace LibraryMicroTask
{
    public class FileHelper
    {
        public string Path { get; }
        public FileHelper(string path)
        {
           this.Path = path;    
        }
        public async Task AppendAsync(string text)
        {
            using StreamWriter sw = new StreamWriter(Path, true);
            await sw.WriteAsync(text);
        }
        public async Task ReplaceAsync(string text)
        {
            using StreamWriter sw = new StreamWriter(Path, false);
            await sw.WriteAsync(text);
        }
        public async Task<string > ReadAsync()
        {
            using StreamReader sr = new StreamReader(Path);
            return await sr.ReadToEndAsync();
        }


    }
}
