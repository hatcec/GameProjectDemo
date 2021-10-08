using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public interface IUserCheckService
    {
        public bool Validate(Gamer gamer);
    }
}
