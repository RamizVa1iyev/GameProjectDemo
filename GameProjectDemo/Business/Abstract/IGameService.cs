using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity.Concrete;

namespace GameProjectDemo.Business.Abstract
{
    public interface IGameService
    {
        void BuyGame(Game game, User user, Campaign campaign = null);
    }
}
