using Barbarosoft.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            //We used Fluently to configure NHibernate instead of XML
            return Fluently
                .Configure()
                .Database(MsSqlConfiguration
                    .MsSql2012
                    .ConnectionString("Data Source=DESKTOP-1AC67OU\\SQLEXPRESS; Database=SiteManagementDb;Integrated Security=True"))
                .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }
    }
}
