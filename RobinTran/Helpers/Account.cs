using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobinTran.Helpers
{
    public class Account
    {
        public Account() { }
        public string MD5Encrypt(string letter)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(letter));
            string result = "";
            for (int i = 0; i <= hashedBytes.Count() - 1; i++)
            {
                result += hashedBytes[i];
            }
            return result;
        }
    }
}