using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DbConnection
{
    private static readonly DbConnection instance = new DbConnection();

    public string path { get; private set; }

    private DbConnection()
    {
        path = @"Data Source=SAMSUNG\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True";
    }

    public static DbConnection GetInstance()
    {
        return instance;
    }
}
