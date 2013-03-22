﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNet.SignalR;
using Owin;

namespace LeveledUp
{
    public class LevelUpStartup
    {
        public void Configuration(IAppBuilder app)
        {
            // Turn cross domain on 
            var config = new HubConfiguration { EnableCrossDomain = true };
            app.MapHubs(config);
            
        }
    }
}
