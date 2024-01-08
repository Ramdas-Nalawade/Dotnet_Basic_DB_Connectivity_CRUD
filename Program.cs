using MySql.Data.MySqlClient;
MySqlConnection connection = new MySqlConnection();
connection.ConnectionString = @"server = localhost; port = 3306; user = root;
                                password = root123; database = mytables";
MySqlCommand cmd = new MySqlCommand();

cmd.Connection = connection;
//cmd.CommandText = "select * from student";

//cmd.CommandText = "insert into student values(default, 'Aditya', 'adi@gmail.com',1)";
//cmd.CommandText = "update student set email = 'ady@gmail.com' where id = 6";
cmd.CommandText = "delete from student where id = 6";

try
{
    connection.Open();
    /*MySqlDataReader reader = cmd.ExecuteReader();
    while(reader.Read())
    {
        int id = int.Parse(reader["id"].ToString());
        String? name = reader["name"].ToString(); 
        String? email = reader["email"].ToString();
        int city_id = int.Parse(reader["city_id"].ToString());
        Console.WriteLine("Id: "+id+", Name = "+name+", email: "+email+", " +
            "city id: "+city_id);
    }

    cmd.ExecuteReader();*/
    cmd.ExecuteNonQuery();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    connection.Close();
    
}