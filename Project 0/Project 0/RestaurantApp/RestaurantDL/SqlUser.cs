﻿using Microsoft.Data.SqlClient;
using RestaurantModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;
using System.Data;

namespace RestaurantDL
{

    public class SqlUser : IRepo
    {
        /// <summary>
        /// This is referencing the connection string from program.cs
        /// which is referencing the connection string from the .txt file.
        /// </summary>
        readonly string connectionString;
        public SqlUser(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Implementation for method that returns all restaurants from the database.
        /// </summary>
        /// <returns></returns>
        /*public List<Restaurant> GetAllRestaurantsConnected()
        {
            string commandString = "SELECT * FROM Restaurant;";


            using SqlConnection connection = new(connectionString);

            using IDbCommand command = new SqlCommand(commandString, connection);
            connection.Open();

            using IDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();

            while (reader.Read())
            {


                restaurants.Add(new Restaurant
                {

                    Name = reader.GetString(0),
                    Type = reader.GetString(0),
                    City = reader.GetString(2),
                    State = reader.GetString(3),
                    Phone = reader.GetInt32(4),
                    Reviews = reader.GetInt32(5)
                });
            }
            return restaurants;
        }
            /// <summary>
            /// Implementation for the method that adds restaurants to the SQL database on azure.
            /// </summary>
            /// <param name="r"></param>
            /// <returns></returns>*/
        public List<User> GetAllUsers()
        {
            string commandString = "SELECT * FROM Users;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            //IDataAdapter adapter = new SqlDataAdapter(command);
            //DataSet dataSet = new();
            connection.Open();
            // adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.
            //connection.Close();
            using SqlDataReader reader = command.ExecuteReader();

            var users = new List<User>();
            //DataColumn levelColumn = dataSet.Tables[0].Columns[1];
            while (reader.Read())
            {
                users.Add(new User
                {
                    Name = reader.GetString(0),
                    Email = reader.GetString(1),
                    Password= reader.GetString(2),
                   
                });
            }
            return users;
        }
        /// <summary>
        /// Implementation for the method that adds restaurants to the SQL database on azure.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public User AddUser(User rest)
        {
            string commandString = "INSERT INTO Restaurants (Name, Email, Password) " +
                "VALUES (@name, @email, @password);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", rest.Name);
            command.Parameters.AddWithValue("@type", rest.Email);
            command.Parameters.AddWithValue("@city", rest.Password);
           
            connection.Open();
            command.ExecuteNonQuery();

            return rest;
        }

        public Restaurant AddRestaurant(Restaurant rest)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            throw new NotImplementedException();
        }
    }

}
