using System;
using Xunit;
using Models;

namespace UnitTest
{
    public class ProductValidation
    {
        Products testProduct = new Products();
        [Fact]
        public void ProductNameIsValid()
        {
            var name = "Football";
            testProduct.ProductName = name;
            Assert.NotNull(testProduct.ProductName);
            Assert.Equal(name, testProduct.ProductName);
        }
        [Theory]
        [InlineData("F@@tolkjh")]
        [InlineData("%*&@*&")]
       
        public void ProductNameThrowsExceptionOnInvalid(string input)
        {
            Assert.Throws<Exception>(() => testProduct.ProductName = input);
        }
        [Fact]
        public void ProductDescriptionIsValid()
        {
            var name = "Officially licensed NFL football";
            testProduct.ProductDescription = name;
            Assert.NotNull(testProduct.ProductDescription);
            Assert.Equal(name, testProduct.ProductDescription);
        }
        [Theory]
        [InlineData("F@@tolkjh")]
        [InlineData("%*&@*&")]
       
        public void ProductDescriptionThrowsExceptionOnInvalid(string input)
        {
            Assert.Throws<Exception>(() => testProduct.ProductDescription = input);
        }

        [Fact]
        public void ProductCategoryIsValid()
        {
            var name = "Sporting goods";
            testProduct.ProductCategory = name;
            Assert.NotNull(testProduct.ProductCategory);
            Assert.Equal(name, testProduct.ProductCategory);
        }
      
      
    }
}