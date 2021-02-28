using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = 1,
                FirstName = "Osman",
                LastName = "Öktem",
                DateOfBirth = new DateTime(1973, 1, 1),
                NationalityId = "22222222222"
            };
            

            BaseGamerManager baseGamerManager = new GamerManager(new GamerCheckManager());
            baseGamerManager.Add(gamer);
        }
    }
}
