using System;
using DotNetCore.CAP;
using University.Courses.Application.Events.External;

namespace University.Courses.Api
{
    public class TestSubscriber : ICapSubscribe
    {
        [CapSubscribe("StudentCreated")]
        public void CheckReceivedMessage(StudentCreated student)
        {
            Console.WriteLine("student subscriber fired");
        }
    }
}