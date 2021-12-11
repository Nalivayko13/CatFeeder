using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Entity;
using Model.Repository;
using Model.Service;
using Ninject;
using Presenter;
using test_project;

namespace CatFeeder
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            kernel.Bind<Ihome_user>().To<home_user>();
            kernel.Bind<Ilogin>().To<Form1>();
            kernel.Bind<Iadd_feeder>().To<add_feeder>();
            kernel.Bind<Imanage_timetables>().To<manage_timetables>();
            kernel.Bind<Iedit_timetable>().To<edit_timetable>();
            kernel.Bind<Ihome_admin>().To<home_admin>();
            kernel.Bind<Iedit_feeder>().To<edit_feeder>();
            kernel.Bind<Ireg_screen>().To<reg_screen>();
            kernel.Bind<Ifeeder_id_list>().To<feeder_id_list>();

            kernel.Bind<IFeederService>().To<FeederService>();
            kernel.Bind<IAuthService>().To<AuthService>();
            kernel.Bind<ITimetableService>().To<TimetableService>();

            kernel.Bind<IRepository<User>>().To<UserRepository>();
            kernel.Bind<IRepository<Timetable>>().To<TimetableRepository>();
            kernel.Bind<IRepository<Feeder>>().To<FeederRepository>();

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<loginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}