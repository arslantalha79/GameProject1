using GameProject1.Abstract;
using GameProject1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject1.Concrete
{
    public class SaleManager
    {
        private Campaign _campaign;

        public SaleManager(Campaign campaign) 
        {
            _campaign = campaign;
        }
        public void Sale(Gamer gamer,ICampaignService campaignService)
        {
            campaignService.Add(_campaign);
            Console.WriteLine(gamer.GameName + " adlı oyuncu " + " ''" +_campaign.CampaignName + "'' " +" adlı kampanyadan yararlanarak oyunu satın aldı!");
        }
    }
}
