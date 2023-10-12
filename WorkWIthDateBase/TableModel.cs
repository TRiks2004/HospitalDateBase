namespace HospitalDateBase.WorkWIthDateBase;

public static class TableModel
{
    public static string EmployeesTable =>
        "CREATE TABLE IF NOT EXISTS Employees (" +
        "EmployeeID INTEGER PRIMARY KEY, " +
        "FullName TEXT, " +
        "Age INTEGER, " +
        "Gender TEXT, " +
        "Address TEXT, " +
        "Phone TEXT, " +
        "PassportData TEXT, " +
        "PositionID INTEGER, " +
        "FOREIGN KEY (PositionID) REFERENCES Positions(PositionID))";

    public static string PositionsTable =>
        "CREATE TABLE IF NOT EXISTS Positions (" +
        "PositionID INTEGER PRIMARY KEY, " +
        "PositionName TEXT, " +
        "Salary REAL, " +
        "Responsibilities TEXT, " +
        "Requirements TEXT)";

    public static string MedicinesTable =>
        "CREATE TABLE IF NOT EXISTS Medicines (" +
        "MedicineID INTEGER PRIMARY KEY, " +
        "MedicineName TEXT, " +
        "Indications TEXT, " +
        "Contraindications TEXT, " +
        "Packaging TEXT, " +
        "Cost REAL)";



}