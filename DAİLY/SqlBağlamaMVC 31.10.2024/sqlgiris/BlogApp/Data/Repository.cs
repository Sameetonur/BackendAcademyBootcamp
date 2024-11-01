using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace BlogApp.Data;

public class Repository<T> : IManager<T>
{
    private readonly string _connectionString;
    private readonly string _tablename;


public Repository()
{
    _connectionString="Server=.\\SQLEXPRESS; Database=Student; Integrated Security=True;TrustServerCertificate=True";
    _tablename=typeof(T).Name+"s";
}

    private IDbConnection dbConnection(){

        return new SqlConnection(_connectionString);
    }

    public IEnumerable<T> GetAll()
    {
        using(var connec=dbConnection()){
            var query=$"Select * From {_tablename}";
            return connec.Query<T>(query);
        }
    }
}
