using GameProject1.Abstract;
using GameProject1.Concrete;
using GameProject1.Entity;
using System;

namespace GameProject1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Game game = new Game{ Id = 1, Name = "Forza Horizon 4", Price = 329 };
            

            Campaign campaign = new Campaign();
            campaign.CampaignName = "100 lira ve üzeri alışverişlerde 2.oyun %50 Daha Uygun Fiyata!";
            campaign.Id = 1;

            Gamer gamer = new Gamer();
            gamer.FirstName = "Ömer Talha";
            gamer.GameName = "omer.uw";
            gamer.LastName = "Arslan";
            gamer.DateOfBirth = new DateTime(2005,4,4);

            IGamerCheckService gamerCheck = new GamerCheckManager();
            gamerCheck.CheckIfRealPerson(gamer);

            SaleManager saleManager = new SaleManager(campaign);
            saleManager.Sale(gamer,new CampaignManager());
        }
    }
}
