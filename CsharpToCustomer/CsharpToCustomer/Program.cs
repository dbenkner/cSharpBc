using CustomersControllerProject;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

var connStr = "server=localhost\\sqlexpress;" +
    "database=SalesDb;" +
    "trusted_connection=true;" +
    "trustServerCertificate=true;";

var conn = new SqlConnection(connStr);
conn.Open();
if(conn.State != System.Data.ConnectionState.Open)
{
    throw new Exception("Connection Did not Open!");
}
Console.WriteLine("Connection with SQL Server Open");
var custCtrl = new CustomersController(conn);
List<Customer> customers = custCtrl.GetCustomersByCity("Cincinnati");

Tester(customers);
customers.Clear();

customers = custCtrl.GetCustomersBySalesMoreThan(70000);
Tester(customers);

conn.Close();


