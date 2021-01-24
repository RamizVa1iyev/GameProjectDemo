using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Business.Abstract;
using GameProjectDemo.Entity.Concrete;

namespace GameProjectDemo.Business.Concrete
{
    public class CampaignManager:ICampaignService
    {
        public decimal CalculateGamePrice(Campaign campaign, Game game)
        {
            return campaign == null ? game.Price : (1-campaign.Percent) * game.Price;
        }

        public void Add(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} added");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} updated");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} deleted");
        }
    }
}
