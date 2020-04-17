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

    'Chemins d'accès
    Public ReadOnly TempPath As String = Directory.CreateDirectory(Path.GetTempPath() + "\MCCustomServerCreator").FullName
    Public ReadOnly ManifestDownloadPath As String = TempPath + "\version_manifest.json"
End Module
