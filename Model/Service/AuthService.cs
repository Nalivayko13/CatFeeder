using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Model.Service
{
    public class AuthService : IAuthService
    {
        SHA256 sha256Hash = SHA256.Create();

        private static Random random = new Random();

        private IRepository<User> _userrepository;
        public AuthService(IRepository<User> userrepository)
        {
            _userrepository = userrepository;
        }
        public short Login(string username, string password)
        {
            if (username == null) return 0;

            User user = _userrepository.Get(username);

            if (user == null) return 0;

            password += user.password_salt;

            

            if (VerifyHash(sha256Hash, password, user.password_hash))
            {
                return user.account_type; 
            }
            return 0; 
        }

        public short Register(string username, string password, string confirm_password)
        {

            if (username == null) return 1;

            User user = _userrepository.Get(username);
            if (user != null) return 2;
            else if (password.Length < 8) return 3;

            string salt = RandomString(5);

            password += salt;
            confirm_password += salt;

            string pass_hash = GetHash(sha256Hash, password);

            if (VerifyHash(sha256Hash, confirm_password, pass_hash))
            {
                short user_type = 1;
                if (username == "admin") user_type = 2;
                User new_user = new User(username, pass_hash, salt, user_type);
                _userrepository.Add(new_user);
                return 0;
            }
            else
            {
                return 4; //hash did not match
            }

        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            var hashOfInput = GetHash(hashAlgorithm, input);
            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
