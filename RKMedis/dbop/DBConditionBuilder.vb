Imports System.Text

Module DBConditionBuilder

    Dim nameListInteger As New ArrayList
    Dim nameListVarchar As New ArrayList

    Public Sub addIntegerColumnName(ByVal data As KeyVal)
        nameListInteger.Add(data)
    End Sub

    Public Sub addVarCharColumnName(ByVal data As KeyVal)
        nameListVarchar.Add(data)
    End Sub

    Public Function getConditionalWhere() As String

        Dim text As New StringBuilder

        text.Append(" WHERE ")

        For Each nCol As KeyVal In nameListInteger
            text.Append(nCol.KeyName)
            text.Append("=")
            text.Append(nCol.Value)
            text.Append(" AND ")
        Next

        For Each nCol As KeyVal In nameListVarchar
            text.Append(nCol.KeyName)
            text.Append("LIKE '%")
            text.Append(nCol.Value)
            text.Append("%'")
            text.Append(" AND ")
        Next

        Return text.ToString

    End Function

End Module
