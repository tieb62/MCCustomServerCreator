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
    Public ReadOnly VanillaManifestURL As String = "https://launchermeta.mojang.com/mc/game/version_manifest.json"
    Public ReadOnly SpigotVersionsURL As String = "https://dl.dropboxusercontent.com/s/m3sns19l2pye341/versions.txt?raw=1&dl=1"
    Public ReadOnly SpigotBuildToolsURL As String = "https://hub.spigotmc.org/jenkins/job/BuildTools/lastSuccessfulBuild/artifact/target/BuildTools.jar"

    'Chemins d'accès
    Public ReadOnly TempPath As String = Directory.CreateDirectory(Path.GetTempPath() + "\MCCustomServerCreator").FullName
    Public ReadOnly VanillaManifestDownloadPath As String = TempPath + "\version_manifest.json"
    Public ReadOnly SpigotVersionsDownloadPath As String = TempPath + "\spigot_versions.txt"
    Public ReadOnly SpigotBuildPath As String = Directory.CreateDirectory(TempPath + "\SpigotBuildTools").FullName
    Public ReadOnly SpigotBuildToolsPath As String = SpigotBuildPath + "\BuildTools.jar"
End Module
