using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AddressBook.Services.Interfaces
{
    public interface IImageService
    {
        Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}