using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class OrderManager : IOrderService
    {
        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("{0} isimli kullanıcıya {1} oyunu {2}  ile satılmıştır.",gamer.FirstName,game.GameName,campaign.CampaignName);
        }
    }
}
