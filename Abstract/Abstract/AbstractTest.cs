using System;
using System.IO;
using Xunit;
using FluentAssertions;
using Abstract;
using Abstract;

public class AbstractTest
{
    [Fact]
    public void Constructor_ShouldSetNameCorrectly()
    {
        var car = new Car("Tesla");
        car.Name.Should().Be("Tesla");
    }

    [Fact]
    public void StartEngine_PrintsCorrectMessage()
    {
        var car = new Car("Tesla");
        var sw = new StringWriter();
        Console.SetOut(sw);
        car.Drive();
        sw.ToString().Trim().Should().Be("Driving from car Tesla");
    }
}