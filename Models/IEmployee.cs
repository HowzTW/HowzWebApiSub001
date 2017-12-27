using System;
namespace HowzWebApiSub001.Models
{
    public interface IEmployee
    {
        long Id { get; set; }

        string Name { get; set; }

        string Password { get; set; }

        string PersonId { get; set; }

        long Create();

        bool Read(long id);

        bool Update();

        bool Delete();
    }
}
