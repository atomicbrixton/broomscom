﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DirectiveHub.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Map
            config.MapHttpAttributeRoutes();
        }
    }
}
