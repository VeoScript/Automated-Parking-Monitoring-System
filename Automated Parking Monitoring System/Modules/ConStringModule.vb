Module ConStringModule

    Public DataSouceString As String
    Public DatabaseString As String

    Public Function ConString() As String
        ConString = "Data Source=" + DataSouceString + ";Initial Catalog=" + DatabaseString + ";Integrated Security=True"
        'ConString ="Data Source = VEOSCRIPT;Initial Catalog=parking;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    End Function

End Module
