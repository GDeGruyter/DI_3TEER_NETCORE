using System;

namespace TestDataAccessLayer
{
    public interface IRepository
    {
        string StoreSomeThing();
    }

    public class Repository : IRepository
    {
        public string StoreSomeThing()
        {
            Console.WriteLine("Something written to the storage.");
            return "Something from the database";
        }
    }
}