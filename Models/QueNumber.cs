using Microsoft.Extensions.ObjectPool;
using TicketShop.Models.Service;

namespace TicketShop.Models
{
    //Singelton pattern  
    public class QueNumber : IQueNumber
    {
        private static volatile QueNumber instance;
        private static readonly object lockObject = new object();
        private int _queNumber;
        private QueNumber()
        {
            
        }
        public static QueNumber Instace
        {
            get
            {
                //Checking if instance has been declared
                if(instance == null)
                {
                    lock (lockObject)
                    {
                        if(instance == null)
                        {
                            instance = new QueNumber();
                        }
                    }
                }
                return instance;
            }
        }
        public int GetQueNumber()
        {
            return _queNumber;
        }

        public void SetQueNumber(int queNumber)
        {
            _queNumber = queNumber;
        }
    }
}
