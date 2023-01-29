using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Controller.DAO
{
    public class apiRouter
    {
        private static IES iesCfg = new IES();

        //API Routes
        public static readonly string URL_SERVICE = iesCfg.ies_api_url + ":" + iesCfg.ies_api_port + "/";
        //Path for every request related to an user
        public static readonly string USERPATH = "api/ies/users/";
        //Validate user's username and password match
        public static readonly string VALIDATE_USER_MATCH = "/match";
        //Validate user's deskapp access permission
        public static readonly string VALIDATE_DESKAPP_ACCESS = "/sysinfoaccess";
        //Get user's sysinfo apps permissions
        public static readonly string GET_APPS_PERMISSIONS = "/sysinfopermissions";
        //Get user's profile data
        public static readonly string GET_PROFILE_DATA = "/profiledata";
        //Set new last access record
        public static readonly string SET_RECORDACCESS = "/recordaccess";
    }
}
