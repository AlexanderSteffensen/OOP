using System;
using ExamAssignment;
using Xunit;
using Xunit.Abstractions;

namespace DashSystem.Test
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }


        [Fact]
        public void Correct_User_Test()
        {
            User testUser = new User(1212, "Alexander", "Steffensen", "alexsteff", 12.21m, "alexsteff@gmail.com");
            User testUser2 = new User(4234, "Jens", "Hansen", "andersand", 321.323m, "JensHansen@Yahoo.com");
            
        }

        public void Fail_User_Test()
        {
            
        }
        
    }
}