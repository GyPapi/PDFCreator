﻿namespace pdfforge.PDFCreator.Utilities.Ftp
{
    public interface IFtpClient
    {
        void Connect();

        void Disconnect();

        bool FileExists(string filePath);

        void CreateDirectory(string path);

        bool DirectoryExists(string directory);

        void UploadFile(string file, string path);
    }
}
