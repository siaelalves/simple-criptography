Imports System.Text
Imports System.Security.Cryptography

Public Class Key

    Private Shared TDES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider

    Private Const key As String = "SIAEL ALVES DE CARVALHO"

    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Dim hashArray() As Byte = ASCIIEncoding.ASCII.GetBytes(value)
        Return MD5.ComputeHash(hashArray)
    End Function

    Public Shared Function Crypt(ByVal text As String) As String
        Try
            TDES.Key = MD5Hash(key)
            TDES.Mode = CipherMode.ECB
            Dim buf As Byte() = ASCIIEncoding.ASCII.GetBytes(text)
            Return Convert.ToBase64String(TDES.CreateEncryptor().TransformFinalBlock(buf, 0, buf.Length))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return String.Empty
        End Try
    End Function

    Public Shared Function DeCrypt(ByVal text As String) As String
        TDES.Key = MD5Hash(key)
        TDES.Mode = CipherMode.ECB
        Try
            Dim buf As Byte() = Convert.FromBase64String(text)
            Return ASCIIEncoding.ASCII.GetString(TDES.CreateDecryptor().TransformFinalBlock(buf, 0, buf.Length))
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

End Class
