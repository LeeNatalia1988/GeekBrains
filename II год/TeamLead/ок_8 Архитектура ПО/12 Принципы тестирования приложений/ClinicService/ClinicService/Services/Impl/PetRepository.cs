﻿using ClinicService.Models;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Impl
{
    public class PetRepository : IPetRepository
    {
        private const string connectionString = "Data Source = clinic.db;";
        public int Create(Pet item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO pets(ClientId, Name, BirthDay) VALUES(@ClientId, @Name, @BirthDay)";
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Name", item.Name);
                
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
                command.CommandText = "DELETE FROM pets WHERE PetId = @PetId";
                command.Parameters.AddWithValue("@PetId", id);

                command.Prepare();
                return command.ExecuteNonQuery();
            }
        }

        public List<Pet> GetAll()
        {
            List<Pet> list = new List<Pet>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM pets";

                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pet pet = new Pet
                    {
                        PetId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        BirthDay = new DateTime(reader.GetInt64(3)),
                    };
                    list.Add(pet);
                }

            }
            return list;
        }

        public Pet GetById(int id)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM pets WHERE PetId=@PetId";
                command.Parameters.AddWithValue("@PetId", id);
                command.Prepare();
                SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Pet pet = new Pet
                    {
                        PetId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        BirthDay = new DateTime(reader.GetInt64(3)),
                    };
                    return pet;
                }

            }
            return null;
        }

        public int Update(Pet item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE pets SET ClientId = @ClientId, Name = @Name, BirthDay = @BirthDay WHERE PetId = @PetId";
                command.Parameters.AddWithValue("PetId", item.PetId);
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@BirthDay", item.BirthDay.Ticks);
                command.Prepare();
                return command.ExecuteNonQuery();
            }
        }
    }
}
