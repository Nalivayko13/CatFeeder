using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IFeederService
    {
        short Activate_feeder(string user_id, string feeder_id);
        short Update_feeder(string feeder_id, string feeder_name);
    }

}
