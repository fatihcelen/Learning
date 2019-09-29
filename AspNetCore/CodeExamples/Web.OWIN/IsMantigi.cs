 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
 
namespace Web.OWIN
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    public class IsMantigi
    {
        private readonly AppFunc birSonrakiKatman;

        public IsMantigi(AppFunc birSonrakiKatman)
        {
            if (birSonrakiKatman == null)
            {
                throw new ArgumentNullException("birSonrakiKatman");
            }

            this.birSonrakiKatman = birSonrakiKatman;
        }

        public Task Invoke(IDictionary<string, object> environment)
        {
            System.Diagnostics.Trace.WriteLine("İstek iş mantığınca işleniyor");

            return birSonrakiKatman(environment);
        }
    }
}