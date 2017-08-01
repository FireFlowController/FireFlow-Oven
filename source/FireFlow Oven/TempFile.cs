using System;
using System.IO;
using System.Linq;

namespace FireFlow_Oven {
    public class TempFile {
        private string TempFileName = string.Empty;
        public bool Created = false;

        public void CreateTmpFile() {
            try {
                // Get the full name of the newly created Temporary file. 
                // Note that the GetTempFileName() method actually creates
                // a 0-byte file and returns the name of the created file.
                TempFileName = Path.GetTempFileName();

                // Craete a FileInfo object to set the file's attributes
                FileInfo fileInfo = new FileInfo(TempFileName);

                // Set the Attribute property of this file to Temporary. 
                // Although this is not completely necessary, the .NET Framework is able 
                // to optimize the use of Temporary files by keeping them cached in memory.
                fileInfo.Attributes = FileAttributes.Temporary;
                Created = true;
                Console.WriteLine("TEMP file created at: " + TempFileName);
            } catch (Exception ex) {
                Console.WriteLine("Unable to create TEMP file or set its attributes: " + ex.Message);
            }
        }

        public void UpdateTmpFile(string Data) {
            try {
                // Write to the temp file.
                StreamWriter streamWriter = File.AppendText(TempFileName);
                streamWriter.WriteLine(Data);
                streamWriter.Flush();
                streamWriter.Close();

                Console.WriteLine("TEMP file updated.");
            } catch (Exception ex) {
                Console.WriteLine("Error writing to TEMP file: " + ex.Message);
            }
        }

        public void ClearFile() {
            try {
                File.WriteAllText(TempFileName, string.Empty);
            } catch (Exception ex) {
                Console.WriteLine("Error clearing TEMP file: " + ex.Message);
            }
        }

        public string ReadTmpFile() {
            string Data = string.Empty;
            try {
                // Read from the temp file.
                StreamReader myReader = File.OpenText(TempFileName);
                Data = myReader.ReadToEnd();
                myReader.Close();
            } catch (Exception ex) {
                Console.WriteLine("Error reading TEMP file: " + ex.Message);
            }
            return Data;
        }

        public void DeleteTmpFile() {
            try {
                // Delete the temp file (if it exists)
                if (File.Exists(TempFileName)) {
                    File.Delete(TempFileName);
                    Console.WriteLine("TEMP file deleted.");
                }
            } catch (Exception ex) {
                Console.WriteLine("Error deleteing TEMP file: " + ex.Message);
            }
        }

        public void ExportTmpFile(string ExportFilePath) {
            if (File.Exists(ExportFilePath))
                File.Delete(ExportFilePath);
            File.Copy(TempFileName, ExportFilePath);
        }

        public int GetNUmberOfLines() {
            if (Created)
                return File.ReadLines(TempFileName).Count()-1;
            else
                return 0;
        }

        public string GetDataAt(int Position) {
            return File.ReadLines(TempFileName).ElementAt(Position);
        }
        public string GetLastData() {
            return File.ReadLines(TempFileName).Last();
        }
    }
}