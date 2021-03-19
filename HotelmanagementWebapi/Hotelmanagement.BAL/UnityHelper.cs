using Hotelmanagement.BAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Extension;

namespace Hotelmanagement.BAL
{
    public class UnityHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IHotel, Hotel>();
            Container.RegisterType<IRoom , Room>();
        }
    }
}
