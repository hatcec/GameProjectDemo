using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} Kampanyası Eklendi.",campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} Kampanyası Silindi.", campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} Kampanyası Güncellendi.", campaign.CampaignName);
        }
    }
}
