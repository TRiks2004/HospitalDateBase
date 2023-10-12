using System;
using System.Data.SQLite;

namespace HospitalDateBase.WorkWIthDateBase;



// Вариант №2: БД Больницы.
// Таблицы:
// 1) Сотрудники (
//              - Код сотрудника
//              - ФИО
//              - Возраст
//              - Пол
//              - Адрес
//              - Телефон
//              - Паспортные данныt
//              - Код должности
// 2) Должности
//              - Код должности
//              - Наименование должности
//              - Оклад
//              - Обязанности
//              - Требования
// 3) Лекарства
//              - Код лекарства
//              - Наименование
//              - Показания
//              - Противопоказания
//              - Упаковка
//              - Стоимость   




public static class HDB
{
    private const string _connectionString = "Data Source=HospitalDateBase.db;Version=3;";
    private static SQLiteConnection? _connection;
    
    
    public static void IncludeDateBase()
    {
        _connection = new SQLiteConnection(_connectionString);
        _connection.Open();
    }
    
    public static void ExcludeDateBase()
    {
        _connection?.Close();
    }
    
    public static void CreateTable()
    {
        using (var createTable = new SQLiteCommand(TableModel.PositionsTable, _connection))
        {
            createTable.ExecuteNonQuery();
        }
        
        using (var createTable = new SQLiteCommand(TableModel.EmployeesTable, _connection))
        {
            createTable.ExecuteNonQuery();
        }
        
        using (var createTable = new SQLiteCommand(TableModel.MedicinesTable, _connection))
        {
            createTable.ExecuteNonQuery();
        }
    }
    
}


// // Создание таблицы (по желанию)
// using (SQLiteCommand createTable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY, Name TEXT)", _connection))
// {
//     createTable.ExecuteNonQuery();
// }
//
// // Вставка данных
// using (SQLiteCommand insertData = new SQLiteCommand("INSERT INTO MyTable (Name) VALUES (@Name)", _connection))
// {
//     insertData.Parameters.AddWithValue("@Name", "Пример данных");
//     insertData.ExecuteNonQuery();
// }
//
// // Выборка данных
// using (SQLiteCommand selectData = new SQLiteCommand("SELECT * FROM MyTable", _connection))
// {
//     using (SQLiteDataReader reader = selectData.ExecuteReader())
//     {
//         while (reader.Read())
//         {
//             int id = reader.GetInt32(0);
//             string name = reader.GetString(1);
//             Console.WriteLine($"ID: {id}, Name: {name}");
//         }
//     }
// }
// _connection.Close();