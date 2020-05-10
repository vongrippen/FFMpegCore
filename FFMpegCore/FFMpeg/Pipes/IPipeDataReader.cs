﻿using System.Threading.Tasks;

namespace FFMpegCore.Pipes
{
    public interface IPipeDataReader
    {
        void ReadData(System.IO.Stream stream);
        Task ReadDataAsync(System.IO.Stream stream);
        string GetFormat();
    }
}