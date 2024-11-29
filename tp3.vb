Public Class tp3
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim taille = liste_p.SelectedItem.ToString()
        Dim ingredient As String = ""
        If croutef.Checked Then
            ingredient = "croute fine"
        ElseIf croutec.Checked Then
            ingredient = "croute classique"
        ElseIf crouteep.Checked Then
            ingredient = "croute epaisse"
        End If
        Dim Ingrsupp As String = ""
        If Checkchamp.Checked Then
            ingredient = Ingrsupp + "champignion"
        ElseIf Checkolives.Checked Then
            ingredient = Ingrsupp + "olives"
        ElseIf Checkpovirons.Checked Then
            ingredient = Ingrsupp + "poivirons"
        ElseIf Checkfromages.Checked Then
            ingredient = Ingrsupp + "frommage supplimentaire"
        End If
        Dim msg As String = "taille:" + taille + "type de croute :" + ingredient + "ingredient supplimentaire"

        MessageBox.Show(msg)
    End Sub
End Class

