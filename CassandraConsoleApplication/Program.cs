// See https://aka.ms/new-console-template for more information
using Cassandra;

Console.WriteLine("Hello, World!");
var cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1") // Add the IP address or hostname of your Cassandra cluster
                .Build();
var session = cluster.Connect("techframer");

var resultSet  = session.Execute("SELECT * FROM student ");
var resultSetunique_identifiers_v2 = session.Execute("SELECT * from unique_identifiers_v2 ");
foreach (var row in resultSet)
{
    // Process each row of the result
    var columnValue = row.GetValue<string>("student_name");
    Console.WriteLine(columnValue);
}
foreach (var row in resultSetunique_identifiers_v2)
{
    // Process each row of the result
    var columnValue = row.GetValue<string>("unique_identifier");
    Console.WriteLine(columnValue);
}
session.Dispose();
cluster.Dispose();

Console.ReadKey();
