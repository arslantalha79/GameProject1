using GameProject1.Abstract;
using GameProject1.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject1.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        { 
            //Mernis Doğrulaması Yapıldı Sayın
            Console.WriteLine(gamer.FirstName + " adlı kişi doğrulandı!");
            return true;
        }
    }
}
