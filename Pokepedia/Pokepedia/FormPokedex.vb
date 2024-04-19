Imports PokeServices.Containers
Imports PokeServices.Models

Public Class FormPokedex
    Private pokedex As New Pokedex

    Private Sub updateGrid()

        DataGridView1.DataSource = pokedex.GetPokemons()

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            Dim number As Long = txtId.Text
            Dim name As String = txtName.Text
            Dim type As New PokemonType("Agua")

            Dim newPokemon As New Pokemon(number, name, type)

            Dim added = pokedex.addPokemon(newPokemon)

            If added Then
                MessageBox.Show("Pokemon agregado")
                txtId.Text = ""
                txtName.Text = String.Empty
                updateGrid()
            Else
                MessageBox.Show("Pokemon existente")
            End If

        Catch ex As Exception
            MessageBox.Show("El numero debe ser un entero.")
        End Try
    End Sub
End Class
