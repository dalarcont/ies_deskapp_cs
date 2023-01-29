using ies_admin_academ.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Controller.DAO
{
    public class API_Users
    {

        /// <summary>
        /// API Consumption to validate user credentials match 
        /// </summary>
        /// <param name="data">Encoded user credentials</param>
        public static appLogin validateAccess(string data) {
            //Result set
            appLogin rs = null;

            //API URI
            string API_URI = apiRouter.URL_SERVICE + apiRouter.USERPATH + data + apiRouter.VALIDATE_USER_MATCH;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API_URI);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            HttpResponseMessage response = null;

            try
            {
                response = client.GetAsync(API_URI).Result;
                if (response.IsSuccessStatusCode)
                {
                    //API consumption successful
                    var dataObjects = response.Content.ReadAsAsync<bool>().Result;
                    //Save single result object (Defined by API service)
                    rs = new appLogin(dataObjects, 200, "Usuario válido");
                }
                else
                {
                    //There is an error, API consumption with fails
                    var errorObject = response.Content.ReadAsStringAsync().Result;
                    var errorString = errorObject.ToString();
                    rs = JsonConvert.DeserializeObject<appLogin>(errorString);
                }
            }
            catch (AggregateException e)
            {
                //Server isn't available
                MessageBox.Show(
                    "No se puede conectar al servidor de servicio." +
                    Environment.NewLine +
                    "Contacte al administrador del servidor."
                    ,
                    "Acceso al sistema"
                    ,
                    MessageBoxButtons.OK
                    ,
                    MessageBoxIcon.Error
                    );
            }

            //Close connection
            client.Dispose();

            //Return package
            return rs;
        }

        /// <summary>
        /// API Consumption to validate user access permission to DESKAPP 
        /// </summary>
        /// <param name="data">Encoded user credentials</param>
        public static appLogin validateAccessDeskapp(string data)
        {
            //Result set
            appLogin rs = null;

            //API URI
            string API_URI = apiRouter.URL_SERVICE + apiRouter.USERPATH + data + apiRouter.VALIDATE_DESKAPP_ACCESS;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API_URI);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            HttpResponseMessage response = null;

            try
            {
                response = client.GetAsync(API_URI).Result;
                if (response.IsSuccessStatusCode)
                {
                    //API consumption successful
                    var dataObjects = response.Content.ReadAsAsync<bool>().Result;
                    //Save single result object (Defined by API service)
                    rs = new appLogin(dataObjects, 200, "Usuario válido");
                }
                else
                {
                    //There is an error, API consumption with fails
                    var errorObject = response.Content.ReadAsStringAsync().Result;
                    var errorString = errorObject.ToString();
                    rs = JsonConvert.DeserializeObject<appLogin>(errorString);
                }
            }
            catch (AggregateException e)
            {
                //Server isn't available
                MessageBox.Show(
                    "No se puede conectar al servidor de servicio." +
                    Environment.NewLine +
                    "Contacte al administrador del servidor."
                    ,
                    "Acceso al sistema"
                    ,
                    MessageBoxButtons.OK
                    ,
                    MessageBoxIcon.Error
                    );
            }

            //Close connection
            client.Dispose();

            //Return package
            return rs;
        }

        /// <summary>
        /// API Consumption to get user profile data 
        /// </summary>
        /// <param name="data">Encoded user credentials</param>
        public static userProfile[] getUserProfileData(string data)
        {
            //Result set
            userProfile[] rs = null;

            //API URI
            string API_URI = apiRouter.URL_SERVICE + apiRouter.USERPATH + data + apiRouter.GET_PROFILE_DATA;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API_URI);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            HttpResponseMessage response = null;

            try
            {
                response = client.GetAsync(API_URI).Result;
                
                if (response.IsSuccessStatusCode)
                {
                    //API consumption successful
                    var dataObjects = response.Content.ReadAsAsync<userProfile[]>().Result; //Read result
                    rs = dataObjects; //Load result in object
                }
                else
                {
                    //There is an error, API consumption with fails
                    var errorObject = response.Content.ReadAsStringAsync().Result;
                    var errorString = errorObject.ToString();
                    appLogin tempRes = JsonConvert.DeserializeObject<appLogin>(errorString);
                    //Display error
                    MessageBox.Show(
                        "Error API-"+tempRes.Code+
                        Environment.NewLine +
                        tempRes.Message+
                        Environment.NewLine
                        ,
                        "Solicitud de datos"
                        ,
                        MessageBoxButtons.OK
                        ,
                        MessageBoxIcon.Error
                        );
                }
            }
            catch (AggregateException e)
            {
                //Server isn't available
                MessageBox.Show(
                    "No se puede conectar al servidor de servicio de usuario." +
                    Environment.NewLine +
                    e.Message +
                    Environment.NewLine +
                    "Contacte al administrador del servidor."
                    ,
                    "Solicitud de datos"
                    ,
                    MessageBoxButtons.OK
                    ,
                    MessageBoxIcon.Error
                    );
            }

            //Close connection
            client.Dispose();

            //Return package
            return rs;
        }

        /// <summary>
        /// API Consumption to set last access date of an user 
        /// </summary>
        /// <param name="data">Encoded user credentials</param>
        public static void setLastAccessRecord(string data)
        {
            //Result set
            appLogin rs = null;

            //API URI
            string API_URI = apiRouter.URL_SERVICE + apiRouter.USERPATH + data + apiRouter.SET_RECORDACCESS;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API_URI);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            HttpResponseMessage response = null;

            try
            {
                response = client.GetAsync(API_URI).Result;
                if (!response.IsSuccessStatusCode)
                {
                    //There is an error, API consumption with fails
                    var errorObject = response.Content.ReadAsStringAsync().Result;
                    var errorString = errorObject.ToString();
                    appLogin tempRes = JsonConvert.DeserializeObject<appLogin>(errorString);
                    //Display error
                    MessageBox.Show(
                        "Error API-" + tempRes.Code +
                        Environment.NewLine +
                        tempRes.Message +
                        Environment.NewLine
                        ,
                        "Proceso interno"
                        ,
                        MessageBoxButtons.OK
                        ,
                        MessageBoxIcon.Error
                        );
                }
            }
            catch (AggregateException e)
            {
                //Server isn't available
                MessageBox.Show(
                    "No se puede conectar al servidor de servicio de usuario." +
                    Environment.NewLine +
                    "Contacte al administrador del servidor."
                    ,
                    "Acceso al sistema"
                    ,
                    MessageBoxButtons.OK
                    ,
                    MessageBoxIcon.Error
                    );
            }

            //Close connection
            client.Dispose();

            //Return package
            //return rs;
        }

        /// <summary>
        /// API Consumption to get user app permissions
        /// </summary>
        /// <param name="data">Encoded user credentials</param>
        public static AppPermissions[] getUserAppPermissions(string data)
        {
            //Result set
            AppPermissions[] rs = null;

            //API URI
            string API_URI = apiRouter.URL_SERVICE + apiRouter.USERPATH + data + apiRouter.GET_APPS_PERMISSIONS;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API_URI);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            HttpResponseMessage response = null;

            try
            {
                response = client.GetAsync(API_URI).Result;

                if (response.IsSuccessStatusCode)
                {
                    //API consumption successful
                    var dataObjects = response.Content.ReadAsAsync<AppPermissions[]>().Result; //Read result
                    rs = dataObjects; //Load result in object
                }
                else
                {
                    //There is an error, API consumption with fails
                    var errorObject = response.Content.ReadAsStringAsync().Result;
                    var errorString = errorObject.ToString();
                    appLogin tempRes = JsonConvert.DeserializeObject<appLogin>(errorString);
                    //Display error
                    MessageBox.Show(
                        "Error API-" + tempRes.Code +
                        Environment.NewLine +
                        tempRes.Message +
                        Environment.NewLine
                        ,
                        "Solicitud de datos"
                        ,
                        MessageBoxButtons.OK
                        ,
                        MessageBoxIcon.Error
                        );
                }
            }
            catch (AggregateException e)
            {
                //Server isn't available
                MessageBox.Show(
                    "No se puede conectar al servidor de servicio de usuario." +
                    Environment.NewLine +
                    e.Message +
                    Environment.NewLine +
                    "Contacte al administrador del servidor."
                    ,
                    "Solicitud de datos"
                    ,
                    MessageBoxButtons.OK
                    ,
                    MessageBoxIcon.Error
                    );
            }

            //Close connection
            client.Dispose();

            //Return package
            return rs;
        }


    }
}
