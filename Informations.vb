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
End Module
