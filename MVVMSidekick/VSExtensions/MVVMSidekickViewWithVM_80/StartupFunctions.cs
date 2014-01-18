﻿using System.Reactive;
using System.Reactive.Linq;
using MVVMSidekick.ViewModels;
using MVVMSidekick.Views;
using MVVMSidekick.Reactive;
using MVVMSidekick.Services;
using MVVMSidekick.Commands;
using $rootnamespace$.ViewModels;
using System;
using System.Net;
using System.Windows;


namespace $rootnamespace$.Startups
{
    public static partial class StartupFunctions
    {
        public static void Config$safeitemname$()
        {
            ViewModelLocator<$safeitemname$_Model>
                .Instance
                .Register(new $safeitemname$_Model())
                .GetViewMapper()
                .MapToDefault<$safeitemname$>();

        }
    }
}
