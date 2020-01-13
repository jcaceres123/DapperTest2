using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DapperTest.Repository.Models;

namespace DapperTest.Repository
{
    public class DapperTestRepository : IDapperTestRepository
    {
        private readonly string _connection;
        public DapperTestRepository(string connection)
        {
            _connection = connection;
        }

        public List<Test> getRecords()
        {
            var records = new List<Test>();
            using (var cnn = new SqlConnection(_connection))
            {
                string query = "select * from test";
                cnn.Open();
                //return cnn.Query<Test>(query);
            }

            return null;
        }
    }
}
