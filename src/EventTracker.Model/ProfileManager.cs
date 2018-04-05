using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using jonathanwalton720.Lib.Data;

namespace jonathanwalton720.Lib
{
    public static class ProfileManager
    {

        public static Profile CreateProfile(string username, string password)
        {
            EntityContext context = new EntityContext();

            string salt = CreatePasswordSalt();

            string passwordHash = CreatePasswordHash(password, salt);

            Profile profile = new Profile()
            {
                Username = username,
                Password = passwordHash,
                PasswordSalt = salt
            };

            context.Profiles.Add(profile);
            context.SaveChanges();

            return profile;
        }

        private static string CreatePasswordHash(string password, string salt)
        {
            HashAlgorithm hash = MD5.Create();
            StringBuilder sb = new StringBuilder();

            byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password + salt));

            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }

        private static string CreatePasswordSalt()
        {
            Random random = new Random();
            string salt = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                salt += random.Next(0, 9).ToString();
            }
            return salt;
        }

        public static Profile GetProfile(string username, string password, bool isHashed = false)
        {
            EntityContext context = new EntityContext();

            Profile profile = context.Profiles
                .Where(p => p.Username == username)
                .SingleOrDefault();

            if (profile != null)
            {
                string passwordHash = isHashed 
                    ? password 
                    : CreatePasswordHash(password, profile.PasswordSalt);

                if (profile.Password != passwordHash)
                {
                    profile = null;
                }
            }

            return profile;
        }

        public static bool IsUsernameValid(string username)
        {
            EntityContext context = new EntityContext();

            var profile = context.Profiles
                .Where(p =>
                    p.Username.ToLower() == username.ToLower()
                ).SingleOrDefault();
            return profile == null;
        }

    }
}
