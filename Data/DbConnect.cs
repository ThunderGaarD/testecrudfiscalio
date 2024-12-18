using Npgsql;
using Dapper;
using System;
using System.Data;
using System.Collections.Generic;

public class DbConnect
{
    // Instância estática para o Singleton
    private static readonly Lazy<NpgsqlConnection> _instance =
        new Lazy<NpgsqlConnection>(() => 
        new NpgsqlConnection("Host=localhost;Database=db_teste_crud;Username=postgres;Password=1234;Port=5432"));

    // Construtor privado para evitar instância externa
    private DbConnect() { }

    // Propriedade pública que acessa a instância da conexão
    public static NpgsqlConnection GetConnection()
    {
        return _instance.Value;
    }


}
