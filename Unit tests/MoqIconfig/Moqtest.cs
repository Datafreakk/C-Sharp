using Moq;
using Xunit;
using Microsoft.Extensions.Configuration;
namespace MoqIconfig;

public class Moqtest
{
  public void GetConnectionString_ReturnsCorrectValue()
  {
    //Arrange 
    var mockedobject = new Mock<IConfigurationSection>();
    mockedobject.Setup(x => x.GetValue<string>("Connectionstring")).Returns("Server=.;Database=Test;");

    var mockconfig = new Mock<IConfiguration>();
    mockconfig.Setup(x => x.GetSection("DatabaseSettings")).Returns(mockedobject.Object);

   var  _sut = new DatabaseService(mockconfig.Object);

   var result = _sut.GetConnectionString();
   
   Assert.Equal("Server=test;Database=mockdb;", result);
  }
}