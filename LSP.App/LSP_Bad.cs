using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.App.Bad
{
    // abstract 
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Call Phone");
        }

        public abstract void TakePhoto();
    }

    public class IPhone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Take photo");
        }
    }
    public class Nokia3310 : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
