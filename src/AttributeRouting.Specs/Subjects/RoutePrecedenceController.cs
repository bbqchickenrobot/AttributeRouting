using System.Web.Mvc;
using AttributeRouting.Web.Mvc;

namespace AttributeRouting.Specs.Subjects
{
    public class RoutePrecedenceAmongRoutesController : Controller
    {
        [GET("Index/Second", Order = 2)]
        [GET("Index/Third", Order = 3)]
        [GET("Index/First", Order = 1)]
        [GET("Index/Fourth")]
        [GET("Index/Seventh", Order = -1)]
        [GET("Index/Fifth", Order = -3)]
        [GET("Index/Sixth", Order = -2)]
        public string Index()
        {
            return "";
        }    
    }

    public partial class RoutePrecedenceAmongActionsController : Controller
    {
        [GET("Route1", Precedence = 1)]
        public string Route1() { return ""; }

        [GET("Route3", Precedence = 3)]
        public string Route3() { return ""; }

        [GET("Route5", Precedence = -3)]
        public string Route5() { return ""; }

        [GET("Route7", Precedence = -1)]
        public string Route7() { return ""; }
    }

    public partial class RoutePrecedenceAmongActionsController
    {
        [GET("Route2", Precedence = 2)]
        public string Route2() { return ""; }
        
        [GET("Route4")]
        public string Route4() { return ""; }
        
        [GET("Route6", Precedence = -2)]
        public string Route6() { return ""; }
    }

    public class RoutePrecedenceAmongControllers3Controller : Controller
    {
        [GET("Controller3/Index")]
        public ActionResult Index()
        {
            return Content("");
        }
    }

    public class RoutePrecedenceAmongControllers1Controller : Controller
    {
        [GET("Controller1/Index")]
        public ActionResult Index()
        {
            return Content("");
        }
    }

    public class RoutePrecedenceAmongControllers2Controller : Controller
    {
        [GET("Controller2/Index")]
        public ActionResult Index()
        {
            return Content("");
        }
    }

    public class RoutePrecedenceAmongTheSitesRoutesController : Controller
    {
        [GET("I-Am-The-First-Route", SitePrecedence = 1)]
        public string IAmTheFirstRoute()
        {
            return "yay!";
        }
    }

    public abstract class RoutePrecedenceAmongDerivedControllersBaseController : Controller { }
    
    public class RoutePrecedenceAmongDerivedControllers1 : RoutePrecedenceAmongDerivedControllersBaseController
    {
        [GET("DerivedController1/Index")]
        public ActionResult Index()
        {
            return Content("");
        }
    }
    
    public class RoutePrecedenceAmongDerivedControllers2 : RoutePrecedenceAmongDerivedControllersBaseController
    {
        [GET("DerivedController2/Index")]
        public ActionResult Index()
        {
            return Content("");
        }
    }
}