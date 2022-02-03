Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Diagnostics
Public Interface IDBComponent
    Sub AddPatient(name As String, address As String, phNo As Long, dob As Date, visitreason As String, doctor As String, fees As String)
    Sub UpdatePatient(id As Integer, name As String, address As String, phNo As Long, dob As Date, visitreason As String, doctor As String, fees As String)
    Sub DeletePatient(id As Integer)

    'Disconnected Model
    Function GetAllPatient() As DataTable



    Function GetSelectedPatients(patientName As String, doctorName As String) As DataTable

End Interface

Public Class DataComponent
    Implements IDBComponent

    Shared ReadOnly strconn As String = ConfigurationManager.ConnectionStrings("myConn").ConnectionString
    'Const strInsert As String = "insert into tblPatient values(@name, @address, @phno, @dob, @visitreason)"
    'Const strUpdate As String = "Update tblPatient Set Name = @name, Address = @address, Ph.No = @phno, DOB = @dob, ReasonOfVisit = @visitreasonwhere PatientId = @id"
    'Const strDelete As String = "delete from tblPatient where PatientId = @id"
    Shared ds As New DataSet
    Const strCmd As String = "Select * from tblPatient"
    Shared adapter As New SqlDataAdapter(strCmd, strconn)
    Const strFindPatient As String = "Select * from tblPatient where Name = @name OR DoctorName = @docName"
    Dim log As New EventLog


    Public Sub New()
        If ds.Tables("Patients") Is Nothing Then
            adapter.Fill(ds, "Patients")
        End If
    End Sub

    Public Sub AddPatient(name As String, address As String, phNo As Long, dob As Date, visitreason As String, doctor As String, fees As String) Implements IDBComponent.AddPatient
        Dim conn As New SqlConnection(strconn)
        Dim cmd As New SqlCommand("InsertPatient", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@phno", phNo)
        cmd.Parameters.AddWithValue("@dob", dob)
        cmd.Parameters.AddWithValue("@reason", visitreason)
        cmd.Parameters.AddWithValue("@doctor", doctor)
        cmd.Parameters.AddWithValue("@fees", fees)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As SqlException
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry(ex.Message, EventLogEntryType.Error)
            End With
            Throw New PatientException("Insertion failed.", ex)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Public Sub UpdatePatient(id As Integer, name As String, address As String, phNo As Long, dob As Date, visitreason As String, doctor As String, fees As String) Implements IDBComponent.UpdatePatient
        Dim conn As New SqlConnection(strconn)
        Dim cmd As New SqlCommand("UpdatePatient", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@phno", phNo)
        cmd.Parameters.AddWithValue("@dob", dob)
        cmd.Parameters.AddWithValue("@reason", visitreason)
        cmd.Parameters.AddWithValue("@doctor", doctor)
        cmd.Parameters.AddWithValue("@fees", fees)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As SqlException
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry(ex.Message, EventLogEntryType.Error)
            End With
            Throw New PatientException("Updation failed.", ex)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Public Sub DeletePatient(id As Integer) Implements IDBComponent.DeletePatient
        Dim conn As New SqlConnection(strconn)
        Dim cmd As New SqlCommand("DeletePatient", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", id)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Employee data deleted!")
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry("Employee data deleted!", EventLogEntryType.Information)
            End With

        Catch ex As SqlException
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry(ex.Message, EventLogEntryType.Error)
            End With
            Throw New PatientException("Deletion failed.", ex)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Public Function GetAllPatient() As DataTable Implements IDBComponent.GetAllPatient
        ds.Tables.Clear()
        adapter.Fill(ds, "Patients")
        Return ds.Tables("Patients")
    End Function

    Public Function GetSelectedPatients(patientName As String, doctorName As String) As DataTable Implements IDBComponent.GetSelectedPatients

        Dim conn As New SqlConnection(strconn)
        Dim cmd As New SqlCommand(strFindPatient, conn)
        cmd.Parameters.AddWithValue("@name", patientName)
        cmd.Parameters.AddWithValue("@docName", doctorName)
        Try
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim table As New DataTable("Patients") 'name is not mandatory
            table.Load(reader)
            Return table
        Catch ex As Exception
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry(ex.Message, EventLogEntryType.Error)
            End With
            Throw ex
        Finally
            conn.Close()
        End Try

    End Function
End Class

Public Class PatientException
    Inherits ApplicationException
    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(strMeassage As String)
        MyBase.New(strMeassage)
    End Sub
    Public Sub New(strMeassage As String, innerException As Exception)
        MyBase.New(strMeassage, innerException)
    End Sub
End Class


Public Class DataFactory
    Public Shared Function GetComponent() As IDBComponent

        Dim component = Type.GetType(ConfigurationManager.AppSettings("DataComponent"))

        If component Is Nothing Then
            Debug.WriteLine("Component is not available")
            Throw New Exception("Component loading failed")
        End If
        Dim instance As IDBComponent
        instance = Activator.CreateInstance(component)
        Return instance
    End Function
End Class
