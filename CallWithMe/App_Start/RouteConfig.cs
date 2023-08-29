using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CallWithMe
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "sendMail",
                url: "sendMail",
                defaults: new { controller = "Home", action = "sendMail", title = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "faHome",
               url: "fa/{title}",
               defaults: new { controller = "Home", action = "faIndex", title = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "tanaTeam",
               url: "fa/team/{title}",
               defaults: new { controller = "Home", action = "faTanaTeam", title = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "contactTana",
               url: "fa/contact/{title}",
               defaults: new { controller = "Home", action = "faContactTana", title = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "serviceTana",
               url: "fa/service/{title}",
               defaults: new { controller = "Home", action = "faServiceTana", title = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "internetTana",
               url: "fa/internet/{title}",
               defaults: new { controller = "Home", action = "faInternetTana", title = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "voipTana",
               url: "fa/voip/{title}",
               defaults: new { controller = "Home", action = "faVoipTana", title = UrlParameter.Optional }
            );
            routes.MapRoute(
              name: "vasTana",
              url: "fa/vas/{title}",
              defaults: new { controller = "Home", action = "faVasTana", title = UrlParameter.Optional }
           );
            routes.MapRoute(
             name: "termsTana",
             url: "fa/terms/{title}",
             defaults: new { controller = "Home", action = "faTerms", title = UrlParameter.Optional }
          );
            routes.MapRoute(
              name: "mobileTana",
              url: "fa/mobile/{title}",
              defaults: new { controller = "Home", action = "faMobileTana", title = UrlParameter.Optional }
           );
            routes.MapRoute(
             name: "webTana",
             url: "fa/web/{title}",
             defaults: new { controller = "Home", action = "faWebTana", title = UrlParameter.Optional }
          );
        
            routes.MapRoute(
             name: "ebTana",
             url: "fa/EBusiness/{title}",
             defaults: new { controller = "Home", action = "faEBusinessTana", title = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "hardwareTana",
             url: "fa/hardware/{title}",
             defaults: new { controller = "Home", action = "faHardwareTana", title = UrlParameter.Optional }
          );
            routes.MapRoute(
               name: "planTana",
               url: "fa/plan/{title}",
               defaults: new { controller = "Home", action = "faPlanTana", title = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "enPlanTana",
               url: "plan/{title}",
               defaults: new { controller = "Home", action = "enPlanTana", title = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}