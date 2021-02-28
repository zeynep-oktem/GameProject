using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Gamer gamer, Game game, Campaign campaign)
        {
            decimal discount = game.PriceOfGame - (game.PriceOfGame * campaign.RateOfCampaign);
            Console.WriteLine(game.NameOfGame+" oyunu "+gamer.FirstName+" "+
                gamer.LastName+" adlı kullanıcıya "+discount+" fiyatına satıldı.");
        }

        public void Sales(Gamer gamer,Game game)
        {
            Console.WriteLine(game.NameOfGame+" oyunu "+gamer.FirstName+" "+
                gamer.LastName+" kullanıcısına satıldı.");
        }
    }
}
