﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoymonOnline
{
    public static class DataProviderFactory
    {
        public static IWhatsNewDataProvider GetWhatsNewDataProvider()
        {
            return new GitHubDataProvider();
        }
        public static IWhoAmIDataProvider GetWhoAmIDataProvider()
        {
            return new GitHubDataProvider();
        }
        public static Lazy<IProjectDataProvider> ProjectsDataProvider = new Lazy<IProjectDataProvider>(() => new GitHubDataProvider());
    }
}
