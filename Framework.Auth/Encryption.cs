﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Auth
{
    public class Encryption
    {
        public static string HashSha256(string rawData) 
        {
            using(SHA256 sHA = SHA256.Create())
            {
                byte[] bytes = sHA.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for(int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); 
                }
                return builder.ToString();
            }
        }
    }
}
