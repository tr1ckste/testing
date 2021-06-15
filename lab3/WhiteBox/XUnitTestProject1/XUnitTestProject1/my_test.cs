using System;
using Xunit;
using IIG.PasswordHashingUtils;


namespace PasswordHashingTests
{

    public class Tests
    {
        [Fact]
        public void test_1_1_1()
        {
            string password = null;
            string salt = "abc";
            uint adlerMod32 = 12;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.Null(actual);
        }

        [Fact]
        public void test_1_2_1_nullSalt()
        {
            string password = null;
            string salt = null;
            uint adlerMod32 = 12;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.Null(actual);
        }

        [Fact]
        public void test_1_2_1_emptySalt()
        {
            string password = null;
            string salt = "";
            uint adlerMod32 = 12;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.Null(actual);
        }

        [Fact]
        public void test_1_2_2()
        {
            string password = null;
            string salt = "abc";
            uint adlerMod32 = 0;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.Null(actual);
        }

        [Fact]
        public void test_2_1_1()
        {
            string password = "password";
            string salt = "abc";
            uint adlerMod32 = 12;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(actual);
        }

        [Fact]
        public void test_2_2_1_nullsalt()
        {
            string password = "password";
            string salt = null;
            uint adlerMod32 = 12;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(actual);
        }

        [Fact]
        public void test_2_2_1_emptySalt()
        {
            string password = "password";
            string salt = "";
            uint adlerMod32 = 12;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(actual);
        }

        [Fact]
        public void test_2_2_2_emptySalt()
        {
            string password = "password";
            string salt = "";
            uint adlerMod32 = 0;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(actual);
        }

        [Fact]
        public void test_2_2_2_nullSalt()
        {
            string password = "password";
            string salt = null;
            uint adlerMod32 = 0;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(actual);
        }

        [Fact]
        public void test_2_1_2()
        {
            string password = "password";
            string salt = "salt";
            uint adlerMod32 = 78;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(actual);
        }

        [Fact]
        public void test_1_1_2()
        {
            string password = null;
            string salt = "salt";
            uint adlerMod32 = 0;
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.Null(actual);
        }
    }
}
