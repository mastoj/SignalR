﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Web;
using System.Web.Routing;

namespace Microsoft.AspNet.SignalR.Hosting.AspNet.Routing
{
    public class IncomingOnlyRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (routeDirection == RouteDirection.IncomingRequest)
            {
                return true;
            }
            return false;
        }
    }
}
