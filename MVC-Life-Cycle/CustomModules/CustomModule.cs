using System.Diagnostics;
using System.Web;

namespace MVC_Life_Cycle.CustomModules
{
    public class CustomModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.LogRequest += Context_LogRequest;
        }

        private void Context_LogRequest(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Item Logged Successfully");
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}