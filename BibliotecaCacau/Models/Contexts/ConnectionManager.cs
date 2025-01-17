﻿using BibliotecaBookHub.Models.Contracts.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaBookHub.Models.Contexts
{
    public class ConnectionManager : IConnectionManager
    {
        private static readonly string _connectionName = "biblioteca";
        private static SqlConnection connection = null;

        public ConnectionManager(IConfiguration configuration)
        {
            var connStr = configuration.GetConnectionString(_connectionName);
            if(connection == null)
            {
                connection = new SqlConnection(connStr);
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
