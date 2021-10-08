using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public interface IOrderService
    {
        void Sales(Gamer gamer, Game game, Campaign campaign);
    }
}
