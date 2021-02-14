using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests
{
   public class CommandTests:IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do Something",
                Platform = "Some Platform",
                CommandLine = "Some CommandLine"
            };
        }

      public void Dispose()
        {
            testCommand = null;
        }


        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange

            //Act
            testCommand.HowTo = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Arrange

            //Act
            testCommand.Platform = ".NET Core";

            //Assert
            Assert.Equal(".NET Core", testCommand.Platform);
        }


        [Fact]

        public void CanChangeCommandLine()
        {
            //Arrange

            //Act

            testCommand.CommandLine = ".NET CLI";

            //Assert
            Assert.Equal(".NET CLI", testCommand.CommandLine);
        
        }
    }
}
