﻿using Bogus;
using LessonNINE.API.Models;

namespace LessonNINE.API.FakeData
{
    public static class FakeData
    {
        private static List<User> _users;
        public static List<User> GetUsers(int number)
        {
            if (_users == null)
            {
                _users = new Faker<User>()
                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(u => u.Firstname, f => f.Name.FirstName())
                .RuleFor(u => u.Lastname, f => f.Name.LastName())
                .RuleFor(u => u.Address, f => f.Address.FullAddress())
                .Generate(number);
            }

            return _users;
        }
    }
}
