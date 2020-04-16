<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServerProperties
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerProperties))
        Me.defaultgamemode = New System.Windows.Forms.GroupBox()
        Me.creative = New System.Windows.Forms.RadioButton()
        Me.spectator = New System.Windows.Forms.RadioButton()
        Me.adventure = New System.Windows.Forms.RadioButton()
        Me.survival = New System.Windows.Forms.RadioButton()
        Me.options = New System.Windows.Forms.GroupBox()
        Me.world = New System.Windows.Forms.GroupBox()
        Me.levelpersonnalise = New System.Windows.Forms.Button()
        Me.leveltype = New System.Windows.Forms.ComboBox()
        Me.nether = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.levelname = New System.Windows.Forms.TextBox()
        Me.entitys = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.serveroptions = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.queryport = New System.Windows.Forms.NumericUpDown()
        Me.enablequery = New System.Windows.Forms.CheckBox()
        Me.forcewhitelist = New System.Windows.Forms.CheckBox()
        Me.whitelist = New System.Windows.Forms.CheckBox()
        Me.serverport = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.serverip = New System.Windows.Forms.MaskedTextBox()
        Me.crackversions = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.playersoptions = New System.Windows.Forms.GroupBox()
        Me.allowfly = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.difficulty = New System.Windows.Forms.GroupBox()
        Me.hard = New System.Windows.Forms.RadioButton()
        Me.hardcore = New System.Windows.Forms.CheckBox()
        Me.normal = New System.Windows.Forms.RadioButton()
        Me.easy = New System.Windows.Forms.RadioButton()
        Me.peaceful = New System.Windows.Forms.RadioButton()
        Me.defaultfile = New System.Windows.Forms.CheckBox()
        Me.info = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.defaultgamemode.SuspendLayout()
        Me.options.SuspendLayout()
        Me.world.SuspendLayout()
        Me.entitys.SuspendLayout()
        Me.serveroptions.SuspendLayout()
        CType(Me.queryport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.serverport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.playersoptions.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.difficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'defaultgamemode
        '
        Me.defaultgamemode.Controls.Add(Me.creative)
        Me.defaultgamemode.Controls.Add(Me.spectator)
        Me.defaultgamemode.Controls.Add(Me.adventure)
        Me.defaultgamemode.Controls.Add(Me.survival)
        Me.defaultgamemode.Location = New System.Drawing.Point(6, 19)
        Me.defaultgamemode.Name = "defaultgamemode"
        Me.defaultgamemode.Size = New System.Drawing.Size(230, 162)
        Me.defaultgamemode.TabIndex = 0
        Me.defaultgamemode.TabStop = False
        Me.defaultgamemode.Text = "Mode de Jeu"
        '
        'creative
        '
        Me.creative.AutoSize = True
        Me.creative.Font = New System.Drawing.Font("Wide Latin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creative.Location = New System.Drawing.Point(6, 19)
        Me.creative.Name = "creative"
        Me.creative.Size = New System.Drawing.Size(150, 28)
        Me.creative.TabIndex = 2
        Me.creative.TabStop = True
        Me.creative.Text = "Créatif"
        Me.creative.UseVisualStyleBackColor = True
        '
        'spectator
        '
        Me.spectator.AutoSize = True
        Me.spectator.Font = New System.Drawing.Font("Wide Latin", 15.0!)
        Me.spectator.Location = New System.Drawing.Point(6, 121)
        Me.spectator.Name = "spectator"
        Me.spectator.Size = New System.Drawing.Size(212, 28)
        Me.spectator.TabIndex = 5
        Me.spectator.TabStop = True
        Me.spectator.Text = "Spectateur"
        Me.spectator.UseVisualStyleBackColor = True
        '
        'adventure
        '
        Me.adventure.AutoSize = True
        Me.adventure.Font = New System.Drawing.Font("Wide Latin", 15.0!)
        Me.adventure.Location = New System.Drawing.Point(6, 87)
        Me.adventure.Name = "adventure"
        Me.adventure.Size = New System.Drawing.Size(188, 28)
        Me.adventure.TabIndex = 4
        Me.adventure.TabStop = True
        Me.adventure.Text = "Aventure"
        Me.adventure.UseVisualStyleBackColor = True
        '
        'survival
        '
        Me.survival.AutoSize = True
        Me.survival.Font = New System.Drawing.Font("Wide Latin", 15.0!)
        Me.survival.Location = New System.Drawing.Point(6, 53)
        Me.survival.Name = "survival"
        Me.survival.Size = New System.Drawing.Size(143, 28)
        Me.survival.TabIndex = 3
        Me.survival.TabStop = True
        Me.survival.Text = "Survie"
        Me.survival.UseVisualStyleBackColor = True
        '
        'options
        '
        Me.options.Controls.Add(Me.world)
        Me.options.Controls.Add(Me.entitys)
        Me.options.Controls.Add(Me.serveroptions)
        Me.options.Controls.Add(Me.playersoptions)
        Me.options.Controls.Add(Me.difficulty)
        Me.options.Controls.Add(Me.defaultgamemode)
        Me.options.Location = New System.Drawing.Point(12, 39)
        Me.options.Name = "options"
        Me.options.Size = New System.Drawing.Size(1109, 383)
        Me.options.TabIndex = 1
        Me.options.TabStop = False
        Me.options.Text = "Options"
        '
        'world
        '
        Me.world.Controls.Add(Me.levelpersonnalise)
        Me.world.Controls.Add(Me.leveltype)
        Me.world.Controls.Add(Me.nether)
        Me.world.Controls.Add(Me.Label6)
        Me.world.Controls.Add(Me.levelname)
        Me.world.Location = New System.Drawing.Point(859, 187)
        Me.world.Name = "world"
        Me.world.Size = New System.Drawing.Size(244, 190)
        Me.world.TabIndex = 7
        Me.world.TabStop = False
        Me.world.Text = "Monde"
        '
        'levelpersonnalise
        '
        Me.levelpersonnalise.Enabled = False
        Me.levelpersonnalise.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.levelpersonnalise.Location = New System.Drawing.Point(6, 108)
        Me.levelpersonnalise.Name = "levelpersonnalise"
        Me.levelpersonnalise.Size = New System.Drawing.Size(232, 30)
        Me.levelpersonnalise.TabIndex = 5
        Me.levelpersonnalise.Text = "Personnaliser"
        Me.levelpersonnalise.UseVisualStyleBackColor = True
        '
        'leveltype
        '
        Me.leveltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.leveltype.FormattingEnabled = True
        Me.leveltype.Items.AddRange(New Object() {"Par défaut", "Monde SuperFlat", "Larges Biomes", "Amplifié", "Personnalisé"})
        Me.leveltype.Location = New System.Drawing.Point(6, 81)
        Me.leveltype.Name = "leveltype"
        Me.leveltype.Size = New System.Drawing.Size(232, 21)
        Me.leveltype.TabIndex = 4
        '
        'nether
        '
        Me.nether.AutoSize = True
        Me.nether.Checked = True
        Me.nether.CheckState = System.Windows.Forms.CheckState.Checked
        Me.nether.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.nether.Location = New System.Drawing.Point(10, 47)
        Me.nether.Name = "nether"
        Me.nether.Size = New System.Drawing.Size(165, 24)
        Me.nether.TabIndex = 3
        Me.nether.Text = "Autoriser le Nether"
        Me.nether.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nom du monde :"
        '
        'levelname
        '
        Me.levelname.Location = New System.Drawing.Point(129, 21)
        Me.levelname.Name = "levelname"
        Me.levelname.Size = New System.Drawing.Size(100, 20)
        Me.levelname.TabIndex = 0
        Me.levelname.Text = "world"
        Me.info.SetToolTip(Me.levelname, "Si vous voulez importer une map, veuiller indiquer le nom du dossier de votre map" &
        "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sinon laissez la valeur par défaut")
        '
        'entitys
        '
        Me.entitys.Controls.Add(Me.CheckBox4)
        Me.entitys.Controls.Add(Me.CheckBox3)
        Me.entitys.Controls.Add(Me.CheckBox2)
        Me.entitys.Controls.Add(Me.CheckBox1)
        Me.entitys.Location = New System.Drawing.Point(514, 19)
        Me.entitys.Name = "entitys"
        Me.entitys.Size = New System.Drawing.Size(589, 162)
        Me.entitys.TabIndex = 6
        Me.entitys.TabStop = False
        Me.entitys.Text = "Entités"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.CheckBox4.Location = New System.Drawing.Point(311, 48)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(171, 24)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "Autoriser GameSpy4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.CheckBox3.Location = New System.Drawing.Point(134, 23)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(171, 24)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "Autoriser GameSpy4"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.CheckBox2.Location = New System.Drawing.Point(96, 50)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(171, 24)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Autoriser GameSpy4"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(96, 75)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(171, 24)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Autoriser GameSpy4"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'serveroptions
        '
        Me.serveroptions.Controls.Add(Me.Label7)
        Me.serveroptions.Controls.Add(Me.queryport)
        Me.serveroptions.Controls.Add(Me.enablequery)
        Me.serveroptions.Controls.Add(Me.forcewhitelist)
        Me.serveroptions.Controls.Add(Me.whitelist)
        Me.serveroptions.Controls.Add(Me.serverport)
        Me.serveroptions.Controls.Add(Me.Label5)
        Me.serveroptions.Controls.Add(Me.Label4)
        Me.serveroptions.Controls.Add(Me.serverip)
        Me.serveroptions.Controls.Add(Me.crackversions)
        Me.serveroptions.Controls.Add(Me.Label3)
        Me.serveroptions.Controls.Add(Me.NumericUpDown3)
        Me.serveroptions.Location = New System.Drawing.Point(334, 187)
        Me.serveroptions.Name = "serveroptions"
        Me.serveroptions.Size = New System.Drawing.Size(519, 190)
        Me.serveroptions.TabIndex = 5
        Me.serveroptions.TabStop = False
        Me.serveroptions.Text = "Serveur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(301, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Port GameSpy4 :"
        '
        'queryport
        '
        Me.queryport.Enabled = False
        Me.queryport.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.queryport.Location = New System.Drawing.Point(430, 49)
        Me.queryport.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.queryport.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.queryport.Name = "queryport"
        Me.queryport.Size = New System.Drawing.Size(74, 26)
        Me.queryport.TabIndex = 11
        Me.queryport.Value = New Decimal(New Integer() {25565, 0, 0, 0})
        '
        'enablequery
        '
        Me.enablequery.AutoSize = True
        Me.enablequery.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.enablequery.Location = New System.Drawing.Point(305, 17)
        Me.enablequery.Name = "enablequery"
        Me.enablequery.Size = New System.Drawing.Size(128, 24)
        Me.enablequery.TabIndex = 10
        Me.enablequery.Text = "Activer Query"
        Me.info.SetToolTip(Me.enablequery, "Autorise le protocole de serveur d'écoute GameSpy4. Utilisé pour obtenir des info" &
        "rmations du serveur.")
        Me.enablequery.UseVisualStyleBackColor = True
        '
        'forcewhitelist
        '
        Me.forcewhitelist.AutoSize = True
        Me.forcewhitelist.Enabled = False
        Me.forcewhitelist.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.forcewhitelist.Location = New System.Drawing.Point(10, 111)
        Me.forcewhitelist.Name = "forcewhitelist"
        Me.forcewhitelist.Size = New System.Drawing.Size(84, 23)
        Me.forcewhitelist.TabIndex = 9
        Me.forcewhitelist.Text = "Forcer ?"
        Me.info.SetToolTip(Me.forcewhitelist, "Renforce la liste blanche (WhiteList) si elle est activée." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Les joueurs qui ne so" &
        "nt pas présents sur la liste blanche seront expulsés après que le fichier white-" &
        "list.json soit rechargé par le serveur.")
        Me.forcewhitelist.UseVisualStyleBackColor = True
        '
        'whitelist
        '
        Me.whitelist.AutoSize = True
        Me.whitelist.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.whitelist.Location = New System.Drawing.Point(10, 81)
        Me.whitelist.Name = "whitelist"
        Me.whitelist.Size = New System.Drawing.Size(168, 24)
        Me.whitelist.TabIndex = 8
        Me.whitelist.Text = "Activer la WhiteList"
        Me.whitelist.UseVisualStyleBackColor = True
        '
        'serverport
        '
        Me.serverport.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.serverport.Location = New System.Drawing.Point(136, 43)
        Me.serverport.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.serverport.Minimum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.serverport.Name = "serverport"
        Me.serverport.Size = New System.Drawing.Size(107, 24)
        Me.serverport.TabIndex = 7
        Me.serverport.Value = New Decimal(New Integer() {25565, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "IP du serveur :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Port du serveur :"
        '
        'serverip
        '
        Me.serverip.BeepOnError = True
        Me.serverip.Location = New System.Drawing.Point(122, 19)
        Me.serverip.Mask = "000.000.000.000"
        Me.serverip.Name = "serverip"
        Me.serverip.Size = New System.Drawing.Size(100, 20)
        Me.serverip.TabIndex = 4
        Me.info.SetToolTip(Me.serverip, resources.GetString("serverip.ToolTip"))
        '
        'crackversions
        '
        Me.crackversions.AutoSize = True
        Me.crackversions.Cursor = System.Windows.Forms.Cursors.Default
        Me.crackversions.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.crackversions.Location = New System.Drawing.Point(10, 140)
        Me.crackversions.Name = "crackversions"
        Me.crackversions.Size = New System.Drawing.Size(228, 23)
        Me.crackversions.TabIndex = 2
        Me.crackversions.Text = "Autoriser les version crackées"
        Me.crackversions.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Joueurs Maximum :"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(145, 163)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown3.TabIndex = 0
        Me.NumericUpDown3.ThousandsSeparator = True
        Me.NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'playersoptions
        '
        Me.playersoptions.Controls.Add(Me.allowfly)
        Me.playersoptions.Controls.Add(Me.Label2)
        Me.playersoptions.Controls.Add(Me.Label1)
        Me.playersoptions.Controls.Add(Me.NumericUpDown2)
        Me.playersoptions.Controls.Add(Me.NumericUpDown1)
        Me.playersoptions.Location = New System.Drawing.Point(242, 19)
        Me.playersoptions.Name = "playersoptions"
        Me.playersoptions.Size = New System.Drawing.Size(265, 162)
        Me.playersoptions.TabIndex = 4
        Me.playersoptions.TabStop = False
        Me.playersoptions.Text = "Joueurs"
        '
        'allowfly
        '
        Me.allowfly.AutoSize = True
        Me.allowfly.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.allowfly.Location = New System.Drawing.Point(10, 87)
        Me.allowfly.Name = "allowfly"
        Me.allowfly.Size = New System.Drawing.Size(136, 24)
        Me.allowfly.TabIndex = 8
        Me.allowfly.Text = "Autoriser le Fly"
        Me.allowfly.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Timeout (Anti-AFK) en min :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Distance de Rendu :"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.NumericUpDown2.Location = New System.Drawing.Point(201, 49)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(43, 28)
        Me.NumericUpDown2.TabIndex = 7
        Me.NumericUpDown2.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(152, 17)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 28)
        Me.NumericUpDown1.TabIndex = 6
        Me.NumericUpDown1.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'difficulty
        '
        Me.difficulty.Controls.Add(Me.hard)
        Me.difficulty.Controls.Add(Me.hardcore)
        Me.difficulty.Controls.Add(Me.normal)
        Me.difficulty.Controls.Add(Me.easy)
        Me.difficulty.Controls.Add(Me.peaceful)
        Me.difficulty.Location = New System.Drawing.Point(6, 187)
        Me.difficulty.Name = "difficulty"
        Me.difficulty.Size = New System.Drawing.Size(322, 190)
        Me.difficulty.TabIndex = 3
        Me.difficulty.TabStop = False
        Me.difficulty.Text = "Difficulté"
        '
        'hard
        '
        Me.hard.AutoSize = True
        Me.hard.Font = New System.Drawing.Font("Pacifico", 12.0!)
        Me.hard.Location = New System.Drawing.Point(6, 142)
        Me.hard.Name = "hard"
        Me.hard.Size = New System.Drawing.Size(150, 35)
        Me.hard.TabIndex = 11
        Me.hard.Text = "Difficile (Hard)"
        Me.hard.UseVisualStyleBackColor = True
        '
        'hardcore
        '
        Me.hardcore.AutoSize = True
        Me.hardcore.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hardcore.Font = New System.Drawing.Font("Showcard Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hardcore.Location = New System.Drawing.Point(170, 79)
        Me.hardcore.Name = "hardcore"
        Me.hardcore.Size = New System.Drawing.Size(146, 31)
        Me.hardcore.TabIndex = 12
        Me.hardcore.Text = "Hardcore"
        Me.hardcore.UseVisualStyleBackColor = True
        '
        'normal
        '
        Me.normal.AutoSize = True
        Me.normal.Font = New System.Drawing.Font("Pacifico", 12.0!)
        Me.normal.Location = New System.Drawing.Point(6, 101)
        Me.normal.Name = "normal"
        Me.normal.Size = New System.Drawing.Size(86, 35)
        Me.normal.TabIndex = 10
        Me.normal.Text = "Normal"
        Me.normal.UseVisualStyleBackColor = True
        '
        'easy
        '
        Me.easy.AutoSize = True
        Me.easy.Font = New System.Drawing.Font("Pacifico", 12.0!)
        Me.easy.Location = New System.Drawing.Point(6, 60)
        Me.easy.Name = "easy"
        Me.easy.Size = New System.Drawing.Size(130, 35)
        Me.easy.TabIndex = 9
        Me.easy.Text = "Facile (Easy)"
        Me.easy.UseVisualStyleBackColor = True
        '
        'peaceful
        '
        Me.peaceful.AutoSize = True
        Me.peaceful.Checked = True
        Me.peaceful.Font = New System.Drawing.Font("Pacifico", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peaceful.Location = New System.Drawing.Point(6, 19)
        Me.peaceful.Name = "peaceful"
        Me.peaceful.Size = New System.Drawing.Size(170, 35)
        Me.peaceful.TabIndex = 8
        Me.peaceful.TabStop = True
        Me.peaceful.Text = "Paisible (Peaceful)"
        Me.peaceful.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.peaceful.UseVisualStyleBackColor = True
        '
        'defaultfile
        '
        Me.defaultfile.AutoSize = True
        Me.defaultfile.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.defaultfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defaultfile.Location = New System.Drawing.Point(12, 12)
        Me.defaultfile.Name = "defaultfile"
        Me.defaultfile.Size = New System.Drawing.Size(204, 21)
        Me.defaultfile.TabIndex = 1
        Me.defaultfile.Text = "Utiliser le fichier par défaut :"
        Me.defaultfile.UseVisualStyleBackColor = True
        '
        'info
        '
        Me.info.AutoPopDelay = 5000
        Me.info.InitialDelay = 100
        Me.info.IsBalloon = True
        Me.info.ReshowDelay = 100
        Me.info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.info.ToolTipTitle = "Information"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 25.0!)
        Me.Button1.Location = New System.Drawing.Point(12, 428)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1109, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ServerProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 497)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.defaultfile)
        Me.Controls.Add(Me.options)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ServerProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Édition du server.properties"
        Me.defaultgamemode.ResumeLayout(False)
        Me.defaultgamemode.PerformLayout()
        Me.options.ResumeLayout(False)
        Me.world.ResumeLayout(False)
        Me.world.PerformLayout()
        Me.entitys.ResumeLayout(False)
        Me.entitys.PerformLayout()
        Me.serveroptions.ResumeLayout(False)
        Me.serveroptions.PerformLayout()
        CType(Me.queryport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.serverport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.playersoptions.ResumeLayout(False)
        Me.playersoptions.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.difficulty.ResumeLayout(False)
        Me.difficulty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents defaultgamemode As GroupBox
    Friend WithEvents options As GroupBox
    Friend WithEvents defaultfile As CheckBox
    Friend WithEvents hardcore As CheckBox
    Friend WithEvents creative As RadioButton
    Friend WithEvents survival As RadioButton
    Friend WithEvents adventure As RadioButton
    Friend WithEvents spectator As RadioButton
    Friend WithEvents difficulty As GroupBox
    Friend WithEvents hard As RadioButton
    Friend WithEvents normal As RadioButton
    Friend WithEvents easy As RadioButton
    Friend WithEvents peaceful As RadioButton
    Friend WithEvents serveroptions As GroupBox
    Friend WithEvents playersoptions As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents crackversions As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents serverip As MaskedTextBox
    Friend WithEvents serverport As NumericUpDown
    Friend WithEvents info As ToolTip
    Friend WithEvents forcewhitelist As CheckBox
    Friend WithEvents whitelist As CheckBox
    Friend WithEvents world As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents levelname As TextBox
    Friend WithEvents entitys As GroupBox
    Friend WithEvents allowfly As CheckBox
    Friend WithEvents nether As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents queryport As NumericUpDown
    Friend WithEvents enablequery As CheckBox
    Friend WithEvents levelpersonnalise As Button
    Friend WithEvents leveltype As ComboBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
