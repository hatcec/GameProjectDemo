using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class GamerManager :BaseGamerManager
    {
        IUserCheckService _userCheckService;

        public GamerManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_userCheckService.Validate(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
        }
        public override void Delete(Gamer gamer)
        {
            if (_userCheckService.Validate(gamer))
            {
                base.Delete(gamer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
         
        }
        public override void Update(Gamer gamer)
        {
            if (_userCheckService.Validate(gamer))
            {
                base.Update(gamer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
        }
    }
}
