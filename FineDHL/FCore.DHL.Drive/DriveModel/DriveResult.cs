using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore.DHL.Drive.DriveModel
{
    public class DriveResult
    {
        public int Result { get; set; }

        public string Message { get; set; }
    }

    public class DriveResult<T> : DriveResult
    {
        public T Data { get; set; }
    }

    public static class DriveResultUnit
    {
        public static DriveResult Success() => new() { Result = 1, Message = "successful" };

        public static DriveResult Failed(string message, int result = 0) => new() { Result = result, Message = message };

        public static DriveResult<T> Success<T>(T data) => new DriveResult<T>
        {
            Result = 1,
            Message = "successful",
            Data = data
        };

        public static DriveResult<T> Failed<T>(string message, int result = 0, T data = default) => new DriveResult<T>
        {
            Result = result,
            Message = message,
            Data = data
        };
    }
}
