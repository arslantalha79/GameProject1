using GameProject1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject1.Entity
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public long NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
