using System;
using DotNetCore.CAP;
using University.Students.Application.Events;

namespace University.Students.Api
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