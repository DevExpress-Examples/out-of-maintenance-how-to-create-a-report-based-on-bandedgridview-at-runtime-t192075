' Developer Express Code Central Example:
' How to convert an XtraGrid to an XtraReport at runtime
' 
' This example demonstrates how to dynamically create a report based upon the
' GridControl at runtime. This means that all filtering and sorting conditions
' selected in the grid are also applied in a report. To accomplish this task, it
' is necessary to create a report with all the necessary bands, bind it to a data
' source and adjust all the necessary options.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E108
Namespace dxKB17175

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Height = 21
            Me.Detail.Name = "Detail"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Height = 23
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    End Class
End Namespace
