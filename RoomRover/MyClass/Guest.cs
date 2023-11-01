using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRover.AddBase
{
    public partial class Guest
    {
        public string MessagerNameguest
        {
            get
            {
                return $" {Name_guest} {id_room}";
            }
        }

       

    }
}
