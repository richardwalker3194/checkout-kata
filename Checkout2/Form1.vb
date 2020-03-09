Imports System.Array
Imports System.Data

Public Class Form1

    Dim dtItem As DataTable
    Dim dtOffer As DataTable
    Public Sub Startup() Handles Me.Load
        dtItem = New DataTable
        dtItem.Columns.Add("ItemCode", GetType(String))
        dtItem.Columns.Add("Item", GetType(String))
        dtItem.Columns.Add("ItemUnitPrice", GetType(Decimal))
        dtItem.Columns.Add("ItemQuantity", GetType(Decimal))

        DataGridViewItem.DataSource = dtItem

        dtOffer = New DataTable
        dtOffer.Columns.Add("ItemCode", GetType(String))
        dtOffer.Columns.Add("ItemOfferQuantity", GetType(Decimal))
        dtOffer.Columns.Add("ItemOfferPrice", GetType(Decimal))
        Dim rowOffer1 As DataRow = dtOffer.NewRow()
        rowOffer1("ItemCode") = "B15"
        rowOffer1("ItemOfferQuantity") = 2
        rowOffer1("ItemOfferPrice") = 0.9
        dtOffer.Rows.Add(rowOffer1)
        Dim rowOffer2 As DataRow = dtOffer.NewRow()
        rowOffer2("ItemCode") = "A10"
        rowOffer2("ItemOfferQuantity") = 3
        rowOffer2("ItemOfferPrice") = 0.5
        dtOffer.Rows.Add(rowOffer2)
    End Sub
    Public Sub PriceCalculate()
        Dim strItemOfferCode As String
        Dim intItemOfferQuantity As Integer
        Dim decItemOfferPrice As Decimal
        Dim intItemQuantity As Integer
        For Each rowOffer As DataRow In dtOffer.Rows
            strItemOfferCode = rowOffer("ItemCode")
            intItemOfferQuantity = rowOffer("ItemOfferQuantity")
            decItemOfferPrice = rowOffer("ItemOfferPrice")
            For Each rowItem As DataRow In dtItem.Rows
                If rowItem("ItemCode") = strItemOfferCode Then
                    intItemQuantity += 1
                End If
            Next
            If intItemQuantity >= intItemOfferQuantity Then
                For Each row As DataRow In dtItem.Rows
                    If row("ItemCode") = strItemOfferCode Then
                        row("ItemUnitPrice") = decItemOfferPrice
                    End If
                Next
            End If
        Next
    End Sub



    Private Sub Apples()
        Dim rowItem As DataRow = dtItem.NewRow()
        rowItem("ItemCode") = "A10"
        rowItem("Item") = "Apples"
        rowItem("ItemUnitPrice") = 0.6
        dtItem.Rows.Add(rowItem)
        PriceCalculate()
    End Sub

    Private Sub Biscuits()
        Dim rowItem As DataRow = dtItem.NewRow()
        rowItem("ItemCode") = "B15"
        rowItem("Item") = "Biscuits"
        rowItem("ItemUnitPrice") = 1.0
        dtItem.Rows.Add(rowItem)
        PriceCalculate()
    End Sub

    Private Sub BakedBeans()
        Dim rowItem As DataRow = dtItem.NewRow()
        rowItem("ItemCode") = "BB11"
        rowItem("Item") = "Baked Beans"
        rowItem("ItemUnitPrice") = 0.9
        dtItem.Rows.Add(rowItem)
    End Sub

    Private Sub ButtonApples_Click(sender As Object, e As EventArgs) Handles ButtonApples.Click
        Apples()
    End Sub

    Private Sub ButtonBiscuits_Click(sender As Object, e As EventArgs) Handles ButtonBiscuits.Click
        Biscuits()
    End Sub

    Private Sub ButtonBakedBeans_Click(sender As Object, e As EventArgs) Handles ButtonBakedBeans.Click
        BakedBeans()
    End Sub

    Private Sub ItemClear()
        dtItem.Rows.Clear()
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ItemClear()
    End Sub
End Class
