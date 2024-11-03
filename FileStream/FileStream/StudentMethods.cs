using FileStream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream
{
    class StudentMethods
    {
        public string Path { get; }
        public StudentMethods(string path)
        {
            Path = path;
        }
        public async Task AddAsync(string name)
        {
           

        }
        public async Task<bool> ExistAsync(string name)
        { 
        
        }
        public async Task UpdateAsync(int index, string newName)
        { 
        
        }
        public async Task DeleteAsync(int index)
        { 
        
        }


        public async Task AppendAsync(string text)
        {
            using StreamWriter sw = new StreamWriter(Path, true);
            await sw.WriteLineAsync(text);
        }
        public async Task ReplaceAsync(string text)
        {
            using StreamWriter sw = new StreamWriter(Path,false);
            await sw.WriteLineAsync(text);
        }
        public async Task<string> ReadAsync()
        {
            using StreamReader sr = new StreamReader(Path);
            return await sr.ReadToEndAsync();
        }
    }
}










