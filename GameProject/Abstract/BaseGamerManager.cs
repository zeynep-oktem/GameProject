using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public class BaseGamerManager : IGamerService
    {
       
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" kayıt edildi");
        }
               
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " güncellendi");
        }
    }
}
