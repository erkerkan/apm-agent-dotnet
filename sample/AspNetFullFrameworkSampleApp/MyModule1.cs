﻿using Elastic.Apm.DiagnosticSource;
using System;
using System.Web;

namespace AspNetFullFrameworkSampleApp
{
    public class MyModule1 : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            //start listening for outgoing HTTP requests in the Elastic APM Agent.
            new ElasticCoreListeners().Start();

            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            context.LogRequest += new EventHandler(OnLogRequest);
            context.BeginRequest += Context_BeginRequest;
            context.EndRequest += Context_EndRequest;
        }

        private void Context_BeginRequest(object sender, EventArgs e)
        {
            //Start transaction here
        }

        private void Context_EndRequest(object sender, EventArgs e)
        {
            //End Transaction here
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}