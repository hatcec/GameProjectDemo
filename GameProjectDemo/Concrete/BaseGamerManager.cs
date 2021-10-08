using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("{0} isimli oyuncu Kayıt Edildi",gamer.FirstName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} isimli oyuncu silindi", gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("{0} isimli oyuncu güncellendi", gamer.FirstName);
        }
    }
}
