using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Security.Cryptography;
using BeitragReader.LoginFolder;

namespace BeitragReader
{
    public class SqliteDataAccess
    {
        public static int SaltSize { get; private set; }
        public static int PBKDF2IterCount { get; private set; }
        public static int PBKDF2SubkeyLength { get; private set; }

        public static List<CompanyModels.CompanyModel> LoadCompanies()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CompanyModels.CompanyModel>("select * from company", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveCompany(CompanyModels.CompanyModel company)
        {
           
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into company (CompanyName, CompanyEmail, CompanyWebsite, CompanyFacebook, CompanyInsta, CompanyLogo) " +
                    "values (@CompanyName, @CompanyEmail, @CompanyWebsite, @CompanyFacebook, @CompanyInsta, @CompanyLogo)", company);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void DeleteCompany(int ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"delete from company where ID = {ID}");
            }
        }

        public static void UpdateCompany(int ID, CompanyModels.CompanyModel company)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"update company set (CompanyName, CompanyEmail, CompanyWebsite, CompanyFacebook, CompanyInsta, CompanyLogo) = (@CompanyName, @CompanyEmail, @CompanyWebsite, @CompanyFacebook, @CompanyInsta, @CompanyLogo) where ID = {ID} ", company);
            }
        }

        public static void IfExitsCompany(CompanyModels.CompanyModel company)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("select from company (CompanyName) " +
                    "values (@CompanyName)", company);
            }
        }

        public static bool CheckUserifExits(ILoginModel model)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT COUNT(*) FROM users WHERE name=@UserName";
                SQLiteCommand cmd = new SQLiteCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Username", model.UserName);
                //cmd.Parameters.AddWithValue("@PassWord", model.PassWord);
                cnn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }
                return false;
            }
                
        }

        public static void SaveUser(string username, string password)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, 20))
            {
                byte[] salt = deriveBytes.Salt;
                byte[] key = deriveBytes.GetBytes(20);

                string encodedSalt = Convert.ToBase64String(salt);
                string encodedKey = Convert.ToBase64String(key);

                ILoginModel mc = Factory.CreateUser();
                mc.UserName = username;
                mc.PassWord = password;
                mc.PassWordHash = encodedKey;
                mc.Salt = encodedSalt;

                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("insert into users (name, password, passwordhash, salt) " +
                        "values (@UserName, @PassWord, @PassWordHash, @Salt)", mc);
                }
            }
        }


        public static List<ILoginModel> LoadUserModel(string username)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var temp = new List<ILoginModel>();

                string query = "SELECT * FROM users WHERE name=@UserName";
                SQLiteCommand cmd = new SQLiteCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Username", username);
                cnn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pass = new LoginModel
                        {
                            UserName = reader["name"].ToString(),
                            PassWordHash = reader["passwordhash"].ToString(),
                            Salt = reader["salt"].ToString()
                        };

                        temp.Add(pass);
                    }
                }
                cnn.Close();
                return temp;
            }
        }

        public static bool isValidUser(ILoginModel model, string password)
        {
            string encodedSalt = model.Salt;
            string encodedKey = model.PassWordHash;

            byte[] salt = Convert.FromBase64String(encodedSalt);
            byte[] key = Convert.FromBase64String(encodedKey);

            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt))
            {
                byte[] testKey = deriveBytes.GetBytes(20); // 20-byte key

                if (!testKey.SequenceEqual(key))
                {
                    return false;
                }
                return true;

            }
        }

    }
}
