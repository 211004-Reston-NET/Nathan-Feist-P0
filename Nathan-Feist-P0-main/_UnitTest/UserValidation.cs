using System;
using Xunit;
using Models;

namespace UnitTest
{
    public class UserValidation
    {
        Users testUser = new Users();

        [Fact]
        public void UserNameIsValid()
        {
            var name = "Joe";
            testUser.UserName = name;
            Assert.NotNull(testUser.UserName);
            Assert.Equal(testUser.UserName, name);
        }

        [Theory]
        [InlineData("Abc123")]
        [InlineData("adb@#$")]
        
        public void UserNameThrowsException(string input)
        {
            Assert.Throws<Exception>(() => testUser.UserName = input);
        }

       

        [Theory]
        [InlineData("!234 test")]
        [InlineData("@234 jkljfs")]
        
        public void InvalidAddressThrowsException(string input)
        {
            Assert.Throws<Exception>(() => testUser.UserAddress = input);
        }

       
        [Theory]
        [InlineData("joe!@gmail.com")]
        [InlineData("joe=@gmail.com")]
        [InlineData("joe#@gmail.com")]
        
        public void EmailThrowsExceptionOnInvalid(string input)
        {
            Assert.Throws<Exception>(() => testUser.UserEmail = input);
        }
    }
}
