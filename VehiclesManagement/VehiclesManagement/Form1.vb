Imports VehiclesServices.DAO
Imports VehiclesServices.Models

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PatentCar = TextBox1.Text
        Dim Type = TextBox2.Text
        Dim Speed = TextBox3.Text

        Dim NewVehicle As New Vehicle(PatentCar, Type, Speed)

        Dim dao As New VehiclesDAO
        dao.Insert(NewVehicle)
        UpdateGrid()
    End Sub

    Private Sub UpdateGrid()
        Dim dao As New VehiclesDAO
        Dim vehicles = dao.GetAll
        DataGridView1.DataSource = vehicles
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()
    End Sub
End Class
