﻿using ClinicService.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace ClinicService.Services.Impl
{
    public class ClientRepository : IClientRepository
    {

        private const string connectionString = "Data Source = clinic.db;";
        public int Create(Client item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO clients(Document, SurName, FirstName, Patronymic, BirthDay) VALUES(@Document, @SurName, @FirstName, @Patronymic, @BirthDay)";
                command.Parameters.AddWithValue("@Document", item.Document);
                command.Parameters.AddWithValue("@SurName", item.SurName);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
                command.Parameters.AddWithValue("@BirthDay", item.BirthDay.Ticks);
                command.Prepare();
                return command.ExecuteNonQuery();
            }
        }

        public int Delete(int id)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM clients WHERE ClientId = @ClientId";
                command.Parameters.AddWithValue("@ClientId", id);
                
                command.Prepare();
                return command.ExecuteNonQuery();
            }
        }

        public List<Client> GetAll()
        {
            List<Client> list = new List<Client>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM clients";
              
                SqliteDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Client client = new Client
                    {
                        ClientId = reader.GetInt32(0),
                        Document = reader.GetString(1),
                        SurName = reader.GetString(2),
                        FirstName = reader.GetString(3),
                        Patronymic = reader.GetString(4),
                        BirthDay = new DateTime(reader.GetInt64(5)),
                    };
                    list.Add(client);
                }
                
            }
            return list;
        }

        public Client GetById(int id)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM clients WHERE ClientId=@ClientId";
                command.Parameters.AddWithValue("@ClientId", id);
                command.Prepare();
                SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Client client = new Client
                    {
                        ClientId = reader.GetInt32(0),
                        Document = reader.GetString(1),
                        SurName = reader.GetString(2),
                        FirstName = reader.GetString(3),
                        Patronymic = reader.GetString(4),
                        BirthDay = new DateTime(reader.GetInt64(5)),
                    };
                    return client;
                }

            }
            return null;
        }

        public int Update(Client item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE clients SET Document = @Document, SurName = @SurName, FirstName = @FirstName, Patronymic = @Patronymic, BirthDay = @BirthDay WHERE ClientId=@ClientId";
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Document", item.Document);
                command.Parameters.AddWithValue("@SurName", item.SurName);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
                command.Parameters.AddWithValue("@BirthDay", item.BirthDay.Ticks);
                command.Prepare();
                return command.ExecuteNonQuery();
            }
        }
    }
}
