using Proyecto_mysql_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Proyecto_mysql_1.Repositories
{
    internal class FilmsRepository
    {
        private readonly String _conn;

        public string codigo = "HOLA";

        public FilmsRepository(String _conexion)
        {
            _conn = _conexion;
        }
        

        public async Task<Film> getFilmById(int id)
        {
            string sql = "select title, description from film where film_id = @id";

            await using var connection = new MySqlConnection(_conn);
            await connection.OpenAsync();

            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);

            await using var reader = await command.ExecuteReaderAsync();

            if(! await reader.ReadAsync())
            {
                return null;
            }

            return new Film
            {
                Id = id,
                Title = reader.GetString("title"),
                Description = reader.GetString("description"),
            };

        }
    }
}
