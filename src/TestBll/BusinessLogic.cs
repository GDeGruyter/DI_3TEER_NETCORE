using System;
using TestDataAccessLayer;

namespace TestBusinessLogicLayer
{
    public interface IBusinessLogic
    {
        string[] DoSomeBusinessLogic();
    }

    public class BusinessLogic : IBusinessLogic
    {
        private readonly IRepository repository;

        public BusinessLogic(IRepository repository)
        {
            this.repository = repository;
        }

        public string[] DoSomeBusinessLogic()
        {
            Console.WriteLine("Something written to the storage.");
            Console.WriteLine("And write it to the repo.");
            return new[]
            {
                repository.StoreSomeThing(),
                "Something from the business layer."
            };
        }
    }
}