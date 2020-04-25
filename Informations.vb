Imports System.IO

Public Module Informations
    Public ServerType As String
    'Définition des constantes de type de serveur
    Public Enum ServerTypes
        VANILLA
        SPIGOT
        FORGE
        SPONGE
    End Enum

    Public ServerDir As String

    'URLs
    Public ReadOnly ManifestURL As String = "https://launchermeta.mojang.com/mc/game/version_manifest.json"
    Public ReadOnly SpigotVersionsURL As String = "https://uccb83882ce32f960be9b21bafef.dl.dropboxusercontent.com/cd/0/get/A2iO4G4Rlg-_ARe6e3wki5efPb3aRYASPv16q5ckx5BkY_cgVZBwJpyK5k1X4ZE7aJ96mZfKa1rAAHgtY9oTTqbHsPMX8qIOUKmzMK55qW3dHX2YJOyACghBayEmYsYqz2I/file?dl=1#"

    'Chemins d'accès
    Public ReadOnly TempPath As String = Directory.CreateDirectory(Path.GetTempPath() + "\MCCustomServerCreator").FullName
    Public ReadOnly ManifestDownloadPath As String = TempPath + "\version_manifest.json"
    Public ReadOnly SpigotVersionsDownloadPath As String = TempPath + "\spigot_versions.txt"
End Module
