using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.App.Good
{

    public interface ITakePhoto
    {
        void TakePhoto();
    }

    // abstract 
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Call Phone");
        }

    }

    public class IPhone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Take Photo");
        }
    }
    public class Nokia3310 : BasePhone
    {
       
    }
}
