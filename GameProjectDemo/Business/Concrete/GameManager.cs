using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Business.Abstract;
using GameProjectDemo.Entity.Concrete;

namespace GameProjectDemo.Business.Concrete
{
    public class GameManager:IGameService
    {
        private readonly ICampaignService _campaignService;

        public GameManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void BuyGame(Game game, User user, Campaign campaign = null)
        {
            var price = _campaignService.CalculateGamePrice(campaign, game);
            Console.WriteLine($"{user.FirsName} bought the {game.Name} for {price} dollar");
        }

    }
}
