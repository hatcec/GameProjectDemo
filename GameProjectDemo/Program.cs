using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer { BirthOfDate = new DateTime(1996, 3, 12), FirstName = "**", LastName = "***", Tc = 11111111111 };
            gamerManager.Add(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { CampaignName = "%10 indirim" };
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);
            Game game = new Game();
            game.GameName = "GTA 5";
            game.GamePrice = 75;
            OrderManager orderManager = new OrderManager();
            orderManager.Sales(gamer, game, campaign);
            Console.ReadLine();
        }
    }
}
