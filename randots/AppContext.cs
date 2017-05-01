using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randots
{
    /// <summary>
    /// Eigener AppContext um Beenden der Anwendung nach Schließen des ersten Fensters zu unterbinden
    /// </summary>
    public class AppContext : ApplicationContext
    {
        public AppContext()
        {
            new SplashScreenWindow().Show();
        }

    }
}
