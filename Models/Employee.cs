using System;
using Google.Cloud.Datastore.V1;

namespace HowzWebApiSub001.Models
{
    public class Employee : IEmployee
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string PersonId { get; set; }

        public long Create()
        {
            return 0;
        }


        public bool Read(long id)
        {
            return true;
        }

        public bool Update()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }

        public Employee()
        {
        }

        public Employee(Entity employeeEntity)
        {
            Id = employeeEntity.Key.Path[0].Id;
            Name = (string)employeeEntity["Name"];
            Password = (string)employeeEntity["Password"];
            PersonId = (string)employeeEntity["PersonId"];
        }
    }
}
