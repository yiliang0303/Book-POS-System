Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.OleDb
Module CheckPassword
    Public Class Hash
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Public Shared Function ComputeHash(ByVal plainText As String, ByVal saltBytes() As Byte) As String

            If (saltBytes Is Nothing) Then
                Dim minSaltSize As Integer
                Dim maxSaltSize As Integer

                minSaltSize = 4
                maxSaltSize = 8

                Dim random As Random
                random = New Random()

                Dim saltSize As Integer
                saltSize = random.Next(minSaltSize, maxSaltSize)

                saltBytes = New Byte(saltSize - 1) {}

                Dim rng As RNGCryptoServiceProvider
                rng = New RNGCryptoServiceProvider()

                rng.GetNonZeroBytes(saltBytes)
            End If

            Dim plainTextBytes As Byte()
            plainTextBytes = Encoding.UTF8.GetBytes(plainText)

            Dim plainTextWithSaltBytes() As Byte =
                New Byte(plainTextBytes.Length + saltBytes.Length - 1) {}

            Dim I As Integer
            For I = 0 To plainTextBytes.Length - 1
                plainTextWithSaltBytes(I) = plainTextBytes(I)
            Next I

            For I = 0 To saltBytes.Length - 1
                plainTextWithSaltBytes(plainTextBytes.Length + I) = saltBytes(I)
            Next I

            Dim hash As HashAlgorithm


            hash = New MD5CryptoServiceProvider()

            Dim hashBytes As Byte()
            hashBytes = hash.ComputeHash(plainTextWithSaltBytes)

            Dim hashWithSaltBytes() As Byte =
                                       New Byte(hashBytes.Length +
                                                saltBytes.Length - 1) {}

            For I = 0 To hashBytes.Length - 1
                hashWithSaltBytes(I) = hashBytes(I)
            Next I

            For I = 0 To saltBytes.Length - 1
                hashWithSaltBytes(hashBytes.Length + I) = saltBytes(I)
            Next I

            Dim hashValue As String
            hashValue = Convert.ToBase64String(hashWithSaltBytes)

            ComputeHash = hashValue
        End Function

        Public Shared Function VerifyHash(ByVal plainText As String, ByVal hashValue As String) As Boolean

            Dim hashWithSaltBytes As Byte()
            hashWithSaltBytes = Convert.FromBase64String(hashValue)

            Dim hashSizeInBits As Integer
            Dim hashSizeInBytes As Integer

            hashSizeInBits = 128

            hashSizeInBytes = hashSizeInBits / 8
            If (hashWithSaltBytes.Length < hashSizeInBytes) Then
                VerifyHash = False
            End If
            Dim saltBytes() As Byte = New Byte(hashWithSaltBytes.Length -
                                               hashSizeInBytes - 1) {}
            Dim I As Integer
            For I = 0 To saltBytes.Length - 1
                saltBytes(I) = hashWithSaltBytes(hashSizeInBytes + I)
            Next I
            Dim expectedHashString As String
            expectedHashString = ComputeHash(plainText, saltBytes)
            VerifyHash = (hashValue = expectedHashString)
        End Function
    End Class
End Module
