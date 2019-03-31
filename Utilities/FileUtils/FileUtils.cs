using System.Diagnostics.Contracts;
using System.IO;
using Utilities.Attributes;

namespace Utilities
{
    public static class FileUtils
    {
        /// <summary>
        /// Returns the size of file in bytes, given an abstract file path.
        /// </summary>
        /// <param name="filePath">The path to the file</param>
        /// <returns>The size of the file in bytes</returns>
        [ContractInvariantMethod]
        [Beta]
        public static long GetFileSize(this string filePath) => new FileInfo(filePath).Length;

        /// <summary>
        /// Returns the size of a directory in bytes, given an abstract file path.
        /// </summary>
        /// <param name="dirPath">The path to the directory</param>
        /// <returns>The size of the directory in bytes</returns>
        [Beta]
        public static long GetDirectorySize(this string dirPath)
        {
            long length = 0;
            FileInfo[] fi_arr = new DirectoryInfo(dirPath).GetFiles();
            DirectoryInfo[] di_arr = new DirectoryInfo(dirPath).GetDirectories();
           
            foreach(FileInfo indv in fi_arr)
            {
                length += indv.Length;
            }
            foreach (DirectoryInfo indv in di_arr)
            {
                length += GetDirectorySize(indv.FullName);
            }
            return length;
        }
    }
}
