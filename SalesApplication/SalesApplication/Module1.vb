Option Strict On
Option Explicit On

Imports System.IO
Imports ClassLib

Module Module1

    Public Const CUSTOMERS_FILENAME = "customers.txt"
    Public Const EMPLOYEES_FILENAME = "employees.txt"
    Public Const INVENTORY_FILENAME = "inventory.txt"
    Public LastStatus As String

    Private allCustomers As New Dictionary(Of String, Customer)
    Private allEmployees As New Dictionary(Of String, Employee)
    Private allInventory As New Dictionary(Of String, Inventory)

    Public Function GetAllCustomers() As List(Of Customer)
        Dim newlist As New List(Of Customer)
        For Each entry In allCustomers
            Dim newCustomer As New Customer(entry.Value.Staffid, entry.Value.FName, entry.Value.MInitial, entry.Value.LName, entry.Value.Street, entry.Value.City, entry.Value.State, entry.Value.Country, entry.Value.PhoneNumber)
            newlist.Add(newCustomer)
        Next

        Return newlist
    End Function

    Public Function GetAllEmployees() As List(Of Employee)
        Dim newlist As New List(Of Employee)
        For Each entry In allEmployees
            Dim newEmployee As New Employee(entry.Value.Staffid, entry.Value.FName, entry.Value.MInitial, entry.Value.LName, entry.Value.Street, entry.Value.City, entry.Value.State, entry.Value.Country, entry.Value.PhoneNumber)
            newlist.Add(newEmployee)
        Next

        Return newlist
    End Function

    Public Function GetAllInventory() As List(Of Inventory)
        Dim newlist As New List(Of Inventory)
        For Each entry In allInventory
            Dim newInventory As New Inventory(entry.Value.ID, entry.Value.Name, entry.Value.Stock)
            newlist.Add(newInventory)
        Next

        Return newlist
    End Function

    Public Function LoadCustomers() As Boolean
        Dim result As Boolean = False

        Dim infile As StreamReader = Nothing

        Try
            infile = File.OpenText(CUSTOMERS_FILENAME)

            While Not infile.EndOfStream
                Dim entireline As String = infile.ReadLine
                Dim tokens() As String = entireline.Split(","c)
                Dim newCustomer As New Customer(tokens(0), tokens(1), tokens(2), tokens(3), tokens(4), tokens(5), tokens(6), tokens(7), tokens(8))
                allCustomers.Add(newCustomer.Staffid, newCustomer)
            End While
            result = True

        Catch ex As Exception
            LastStatus = "Error reading customers file!"
        Finally
            If infile IsNot Nothing Then
                infile.Close()
            End If
        End Try

        Return result
    End Function

    Public Function LoadEmployees() As Boolean
        Dim result As Boolean = False

        Dim infile As StreamReader = Nothing

        Try
            infile = File.OpenText(EMPLOYEES_FILENAME)

            While Not infile.EndOfStream
                Dim entireline As String = infile.ReadLine
                Dim tokens() As String = entireline.Split(","c)
                Dim newEmployee As New Employee(tokens(0), tokens(1), tokens(2), tokens(3), tokens(4), tokens(5), tokens(6), tokens(7), tokens(8))
                allEmployees.Add(newEmployee.Staffid, newEmployee)
            End While
            result = True

        Catch ex As Exception
            LastStatus = "Error reading employees file!"
        Finally
            If infile IsNot Nothing Then
                infile.Close()
            End If
        End Try

        Return result
    End Function

    Public Function LoadInventory() As Boolean
        Dim result As Boolean = False

        Dim infile As StreamReader = Nothing

        Try
            infile = File.OpenText(INVENTORY_FILENAME)

            While Not infile.EndOfStream
                Dim entireline As String = infile.ReadLine
                Dim tokens() As String = entireline.Split(","c)
                Dim newInventory As New Inventory(tokens(0), tokens(1), CInt(tokens(2)))
                'allInventory.Add(newInventory)
            End While
            result = True

        Catch ex As Exception
            LastStatus = "Error reading inventory file!"
        Finally
            If infile IsNot Nothing Then
                infile.Close()
            End If
        End Try

        Return result
    End Function

    Public Function WriteCustomers() As Boolean
        Dim result As Boolean
        Dim outfile As StreamWriter = Nothing
        Try
            outfile = File.CreateText(CUSTOMERS_FILENAME)
            For Each entry In allCustomers
                outfile.WriteLine(entry.Value.Staffid & ", " & entry.Value.FName & ", " & entry.Value.MInitial & ", " & entry.Value.LName & ", " & entry.Value.Street & ", " & entry.Value.City & ", " & entry.Value.State & ", " & entry.Value.Country & ", " & entry.Value.PhoneNumber)
                LastStatus = "Customers saved!"
            Next
            result = True
        Catch ex As Exception
            LastStatus = "Error saving customers file."
        Finally
            If outfile IsNot Nothing Then
                outfile.Close()
            End If
        End Try

        Return result
    End Function

    Public Function WriteEmployees() As Boolean
        Dim result As Boolean
        Dim outfile As StreamWriter = Nothing
        Try
            outfile = File.CreateText(EMPLOYEES_FILENAME)
            For Each entry In allEmployees
                outfile.WriteLine(entry.Value.Staffid & ", " & entry.Value.FName & ", " & entry.Value.MInitial & ", " & entry.Value.LName & ", " & entry.Value.Street & ", " & entry.Value.City & ", " & entry.Value.State & ", " & entry.Value.Country & ", " & entry.Value.PhoneNumber)
                LastStatus = "Employees Saved!"
            Next
            result = True
        Catch ex As Exception
            LastStatus = "Error saving employees file."
        Finally
            If outfile IsNot Nothing Then
                outfile.Close()
            End If
        End Try

        Return result
    End Function

    Public Function WriteInventory() As Boolean
        Dim result As Boolean
        Dim outfile As StreamWriter = Nothing
        Try
            outfile = File.CreateText(INVENTORY_FILENAME)
            For Each entry In allInventory
                outfile.WriteLine(entry.Value.ID & ", " & entry.Value.Name & ", " & entry.Value.Stock.ToString())
                LastStatus = "Inventory Saved!"
            Next
            result = True
        Catch ex As Exception
            LastStatus = "Error saving Inventory file."
        Finally
            If outfile IsNot Nothing Then
                outfile.Close()
            End If
        End Try

        Return result
    End Function

    Public Function AddCustomer(ByVal pCustomer As Customer) As Boolean
        Dim result As Boolean
        Dim newlist As New List(Of Customer)
        newlist = GetAllCustomers()

        If newlist.Contains(pCustomer) Then
            LastStatus = "Customer exists already"
        Else
            allCustomers.Add(pCustomer.Staffid, pCustomer)
            LastStatus = "Customer added successfully"
            result = True
        End If

        Return result
    End Function

    Public Function AddEmployee(ByVal pEmployee As Employee) As Boolean
        Dim result As Boolean
        Dim newlist As New List(Of Employee)
        newlist = GetAllEmployees()

        If newlist.Contains(pEmployee) Then
            LastStatus = "Employee exists already"
        Else
            allEmployees.Add(pEmployee.Staffid, pEmployee)
            LastStatus = "Employee added successfully"
            result = True
        End If

        Return result
    End Function

    Public Function AddInventory(ByVal pInventory As Inventory) As Boolean
        Dim result As Boolean
        Dim newlist As New List(Of Inventory)
        newlist = GetAllInventory()

        If newlist.Contains(pInventory) Then
            LastStatus = "Inventory exists already"
        Else
            allInventory.Add(pInventory.ID, pInventory)
            LastStatus = "Inventory added successfully"
            result = True
        End If

        Return result
    End Function

    Public Function DelCustomer(ByVal custID As String) As Boolean
        Dim result As Boolean
        allCustomers.Remove(custID)
        result = True
        Return result
    End Function

    Public Function DelEmployee(ByVal empID As String) As Boolean
        Dim result As Boolean
        allEmployees.Remove(empID)
        result = True
        Return result
    End Function

    Public Function DelInventory(ByVal invID As String) As Boolean
        Dim result As Boolean
        allInventory.Remove(invID)
        result = True
        Return result
    End Function

End Module
