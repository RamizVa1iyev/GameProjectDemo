using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity.Concrete;

namespace GameProjectDemo.Business.Abstract
{
    public interface ICampaignService
    {
        decimal CalculateGamePrice(Campaign campaign,Game game);
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
