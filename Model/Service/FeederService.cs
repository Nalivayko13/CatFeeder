using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model.Service
{
    public class FeederService : IFeederService
    {
        private IRepository<Feeder> _feederrepository;
        private IRepository<User> _userrepository;
        public FeederService(IRepository<Feeder> feederrepository, IRepository<User> userrepository) //check for repository injection
        {
            _feederrepository = feederrepository;
            _userrepository = userrepository;
        }

        public short Activate_feeder(string user_id, string feeder_id)
        {
            /*
                 Feeder feeder = _feederrepository.Get(feeder_id);

                  if (feeder.User_id != "") return 0;
              else
              {
                      feeder.User_id = user_id;
                      string cond = "feeder_id = '" + feeder_id + "'";
                      _feederrepository.Update(feeder, cond);
                      return 1;        
              }

                  */



            Feeder new_feeder = new Feeder(feeder_id, "");
            if (feeder_id == "") return 0;
            else
            {
                new_feeder.User_id = user_id;
                string cond = "feeder_id = '" + feeder_id + "'";
                _feederrepository.Add(new_feeder);
                return 1;
            };



            /*  if (feeder_id != "" && new_feeder.Name != null)
              {
                  new_feeder.User_id = user_id;
                  string cond = "feeder_id = '" + feeder_id + "'";
                  _feederrepository.Update(new_feeder, cond);
                  return 1;

              }       */


        }

        public short Update_feeder(string feeder_id, string feeder_name) 
        {

			if (feeder_name == "")
				return 0;
			//else
			//{

			//Feeder feeder = _feederrepository.Get(feeder_id);
			Feeder feeder = new Feeder(feeder_id, feeder_name);

               
                    feeder.Name = feeder_name;
                    string cond = "feeder_id = '"+feeder_id+"';";
                    _feederrepository.Update(feeder, cond);
                return 1;
               

            //}
        }


    }
}


