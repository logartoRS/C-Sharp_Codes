using System;
using Microsoft.Data.SqlClient;

namespace _12_SQL
{
	class Program
	{
		static void Main(string[] args)
		{
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

			Console.ReadLine();
		}
	}
}
