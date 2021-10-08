using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class UserValidationManager : IUserCheckService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (Convert.ToInt64(gamer.Tc), gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), gamer.BirthOfDate.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
