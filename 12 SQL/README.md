# SQL - Database

To use a database in C #, we need to download Microsoft.Data.SqlClient in Manage NuGet Packages. The published code helps us to return data from the database. But first of all we need to put our name server, our username, our password and the name of our database.

```c#
try
{
  SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
  builder.DataSource = "<server>";
  builder.UserID = "<username>";
  builder.Password = "<password>";
  builder.InitialCatalog = "<database>";
  builder.IntegratedSecurity = true;

  //Console.WriteLine(builder.ConnectionString);

  using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
  {
    String sql = "SELECT * FROM Paciente";

    using (SqlCommand command = new SqlCommand(sql, connection))
    {
      connection.Open();

      using (SqlDataReader reader = command.ExecuteReader())
      {
        while (reader.Read())
        {
          try
          {
            Console.WriteLine(reader.GetString(2));
          }
          catch (Exception e)
          {
            Console.WriteLine(e.ToString());
          }
        }
      }
    }
  }
}
catch (SqlException e)
{
  Console.WriteLine(e.ToString());
}
```
