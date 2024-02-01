using GameProject1.Abstract;
using GameProject1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject1.Concrete
{
    public class GamerManager:IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.GameName + " adlı kullanıcı sisteme eklendi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GameName + " adlı kullanıcının sistem bilgileri güncellendi!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GameName + " adlı kullanıcı sistemden silindi!");
        }
    }
}
