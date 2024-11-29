<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tp3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        liste_p = New ComboBox()
        croutef = New RadioButton()
        croutec = New RadioButton()
        crouteep = New RadioButton()
        Checkchamp = New CheckBox()
        Checkolives = New CheckBox()
        Checkpovirons = New CheckBox()
        Checkfromages = New CheckBox()
        Btn_affiche = New Button()
        SuspendLayout()
        ' 
        ' liste_p
        ' 
        liste_p.ForeColor = SystemColors.HotTrack
        liste_p.FormattingEnabled = True
        liste_p.Items.AddRange(New Object() {"petite ", "moyenne ", "grande"})
        liste_p.Location = New Point(261, 53)
        liste_p.Name = "liste_p"
        liste_p.Size = New Size(151, 28)
        liste_p.TabIndex = 1
        ' 
        ' croutef
        ' 
        croutef.AutoSize = True
        croutef.Location = New Point(50, 147)
        croutef.Name = "croutef"
        croutef.Size = New Size(101, 24)
        croutef.TabIndex = 2
        croutef.TabStop = True
        croutef.Text = "croute fine"
        croutef.UseVisualStyleBackColor = True
        ' 
        ' croutec
        ' 
        croutec.AutoSize = True
        croutec.Location = New Point(294, 147)
        croutec.Name = "croutec"
        croutec.Size = New Size(136, 24)
        croutec.TabIndex = 3
        croutec.TabStop = True
        croutec.Text = "croute classique"
        croutec.UseVisualStyleBackColor = True
        ' 
        ' crouteep
        ' 
        crouteep.AutoSize = True
        crouteep.Location = New Point(552, 147)
        crouteep.Name = "crouteep"
        crouteep.Size = New Size(125, 24)
        crouteep.TabIndex = 4
        crouteep.TabStop = True
        crouteep.Text = "croute epaisse"
        crouteep.UseVisualStyleBackColor = True
        ' 
        ' Checkchamp
        ' 
        Checkchamp.AutoSize = True
        Checkchamp.ForeColor = SystemColors.Highlight
        Checkchamp.Location = New Point(208, 224)
        Checkchamp.Name = "Checkchamp"
        Checkchamp.Size = New Size(122, 24)
        Checkchamp.TabIndex = 5
        Checkchamp.Text = "Champignons"
        Checkchamp.UseVisualStyleBackColor = True
        ' 
        ' Checkolives
        ' 
        Checkolives.AutoSize = True
        Checkolives.ForeColor = SystemColors.Highlight
        Checkolives.Location = New Point(361, 224)
        Checkolives.Name = "Checkolives"
        Checkolives.Size = New Size(69, 24)
        Checkolives.TabIndex = 6
        Checkolives.Text = "olives"
        Checkolives.UseVisualStyleBackColor = True
        ' 
        ' Checkpovirons
        ' 
        Checkpovirons.AutoSize = True
        Checkpovirons.ForeColor = SystemColors.Highlight
        Checkpovirons.Location = New Point(208, 276)
        Checkpovirons.Name = "Checkpovirons"
        Checkpovirons.Size = New Size(88, 24)
        Checkpovirons.TabIndex = 7
        Checkpovirons.Text = "povirons"
        Checkpovirons.UseVisualStyleBackColor = True
        ' 
        ' Checkfromages
        ' 
        Checkfromages.AutoSize = True
        Checkfromages.ForeColor = SystemColors.MenuHighlight
        Checkfromages.Location = New Point(349, 276)
        Checkfromages.Name = "Checkfromages"
        Checkfromages.Size = New Size(201, 24)
        Checkfromages.TabIndex = 8
        Checkfromages.Text = "fromage supplementaires"
        Checkfromages.UseVisualStyleBackColor = True
        ' 
        ' Btn_affiche
        ' 
        Btn_affiche.ForeColor = SystemColors.HotTrack
        Btn_affiche.Location = New Point(127, 363)
        Btn_affiche.Name = "Btn_affiche"
        Btn_affiche.Size = New Size(529, 29)
        Btn_affiche.TabIndex = 9
        Btn_affiche.Text = "afficher la commande"
        Btn_affiche.UseVisualStyleBackColor = True
        ' 
        ' tp3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_affiche)
        Controls.Add(Checkfromages)
        Controls.Add(Checkpovirons)
        Controls.Add(Checkolives)
        Controls.Add(Checkchamp)
        Controls.Add(crouteep)
        Controls.Add(croutec)
        Controls.Add(croutef)
        Controls.Add(liste_p)
        Name = "tp3"
        Text = "tp3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents liste_p As ComboBox
    Friend WithEvents croutef As RadioButton
    Friend WithEvents croutec As RadioButton
    Friend WithEvents crouteep As RadioButton
    Friend WithEvents Checkchamp As CheckBox
    Friend WithEvents Checkolives As CheckBox
    Friend WithEvents Checkpovirons As CheckBox
    Friend WithEvents Checkfromages As CheckBox
    Friend WithEvents Btn_affiche As Button

End Class
