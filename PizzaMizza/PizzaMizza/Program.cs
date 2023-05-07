using PizzaMizza.Containts;
using System.Data;
using System.Data.SqlClient;
//GetName();
//GetNameNew();
//GetIdNew();



//void GetName()
//{

//    using (SqlConnection sqlconnection = new SqlConnection(Urls.conn))
//    {
//        sqlconnection.Open();

//        string commandText = "select * from Pizzas inner join Prices on Pizzas.Id=Prices.PizzaId ";


//        using (SqlCommand cmd = new SqlCommand(commandText, sqlconnection))
//        {
//            //cmd.Parameters.AddWithValue("id", SqlDbType.Int).Value = id;
//            //cmd.Parameters.AddWithValue("id", id);
//            //string name = (string)cmd.ExecuteScalar();
//            //Console.WriteLine(name);


//            using (SqlDataReader reader = cmd.ExecuteReader())
//            {
//                if (reader.HasRows)
//                {
//                    while (reader.Read())
//                    {
//                        Console.WriteLine($"Pizzaid {reader[2]} Pizza name {reader[5]} pizzatype {reader[1]} pizza price {reader[5]}");
//                    }
//                }
//            }


//        }
//    }
//}





//void GetNameNew()
//{

//    using (SqlConnection sqlconnection = new SqlConnection(Urls.conn))
//    {
//        sqlconnection.Open();

//        string commandText = "select * from Pizzas inner join Prices on Pizzas.Id=Prices.PizzaId ";


//        using (SqlCommand cmd = new SqlCommand(commandText, sqlconnection))
//        {
//            //cmd.Parameters.AddWithValue("id", SqlDbType.Int).Value = id;
//            //cmd.Parameters.AddWithValue("id", id);
//            //string name = (string)cmd.ExecuteScalar();
//            //Console.WriteLine(name);


//            using (SqlDataReader reader = cmd.ExecuteReader())
//            {
//                if (reader.HasRows)
//                {
//                    while (reader.Read())
//                    {
//                        Console.WriteLine("Pizzanin adin yazin");
//                        string PizzaName = Console.ReadLine();
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Wrong!!!");
//                }
//            }


//        }
//    }
//}


//Console.WriteLine("Pizza haqqında ətraflı məlumat almaq istəyirsizsə pizzanın İd -sini ,istəmirsizə 0 daxil edin");
//int idd=Convert.ToInt32(Console.ReadLine());


//void GetIdNew(int id)
//{

//    using (SqlConnection sqlconnection = new SqlConnection(Urls.conn))
//    {
//        sqlconnection.Open();

//        string commandText = "select * from Pizzas where id="+id;
//        string commandtext2 = "select * from Pizzas id=" +id;


//        using (SqlCommand cmd = new SqlCommand(commandText, sqlconnection))
//        {
//            //cmd.Parameters.AddWithValue("id", SqlDbType.Int).Value = id;
//            //cmd.Parameters.AddWithValue("id", id);
//            //string name = (string)cmd.ExecuteScalar();
//            //Console.WriteLine(name);


//            using (SqlDataReader reader = cmd.ExecuteReader())
//            {
//                if (reader.HasRows)
//                {
//                    while (reader.Read())
//                    {
//                        if (id == idd) {

//                            Console.WriteLine($"Pizzaid {reader[2]} Pizza name {reader[5]} pizzatype {reader[1]} pizza price {reader[5]}");
//                        }
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Wrong!!!");
//                }

//            }


//        }
//    }
//}




