using System.Linq;
using System.Reflection;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApi.Controllers;
using TestDataAccessLayer;

namespace Test.Tests.Given_The_TestAPI_Assembly
{
    [TestClass]
    public class When_Selecting_The_Referenced_Assemblies
    {
        private Assembly sut; 
        private AssemblyName[] result;
        
        [TestInitialize]
        public void Setup()
        {
            sut = Assembly.GetAssembly(typeof(ValuesController));
            result = sut.GetReferencedAssemblies();
        }
        [TestMethod]
        public void Then_It_Should_Not_Contain_The_Repo_Assembly()
        {
            var repoAssembly = Assembly.GetAssembly(typeof(Repository));

            result
                .Any(a => a.FullName == repoAssembly.FullName)
                .Should().BeFalse("An API should not reference the repository assembly directly.");
        }
    }
}
