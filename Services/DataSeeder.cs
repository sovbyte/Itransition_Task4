using Bogus;
using Itransition_Task4.Models;

namespace Itransition_Task4.Services;

public static class DataSeeder
{
    public static List<User> GetPredefinedUsers()
    {
        Randomizer.Seed = new Random(42); 

        var userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1)
            .RuleFor(u => u.Name, f => f.Name.FullName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.HashedPassword, f => "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu")
            .RuleFor(u => u.Status, f => f.PickRandom<Status>())
            .RuleFor(u => u.RegistrationDate, f => new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddDays(f.Random.Int(1, 100)));

        return userFaker.Generate(100); 
    }
}