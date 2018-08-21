Public Class Form1
    Dim hExtr As Integer
    Const hNormales As Double = 88
    Dim prHoraE As Double
    Dim prHnormal As Double
    Dim sueldoBruto As Double
    Dim sisGenSalud As Decimal
    Dim sueldoBase As Double
    Dim cont = 0, cont1 As Integer = 0

    Dim isr As Double


    Function horaExtras() As Integer
        Dim hTrabajadas As Integer

        hTrabajadas = Val(txtHorasT.Text())
        txtHorasN.Text() = hNormales.ToString()


        If hTrabajadas > 88 Then
            hExtr = hTrabajadas - hNormales
            txtHorasE.Text = hExtr
            Return hExtr
        Else
            hExtr = 0
            txtHorasE.Text = hExtr
            Return hExtr

        End If

    End Function

    Function PrecioHoraExtra() As Double

        prHnormal = txtPrecioHn.Text()
        prHoraE = prHnormal + (0.25 * prHnormal)
        txtPrecioHE.Text() = FormatCurrency(prHoraE.ToString())
        Return prHoraE


    End Function
    Sub insentivoSobreLaRenta()


        If sueldoBase >= 300000 And sueldoBase <= 600000 Then
            isr = 10 / 100 * sueldoBase
            txtIsr.Text() = isr
            txtSueldoISR.Text() = FormatCurrency(sueldoBase)

        Else

            isr = 15 / 100 * sueldoBase
            txtIsr.Text() = FormatCurrency(isr)
            txtSueldoISR.Text() = FormatCurrency(sueldoBase)

        End If
    End Sub

    Sub sueldo()

        Dim sueldoNeto As Double
        Dim sueldoPorHEx As Double 'Sueldo Por Hora Extra

        sueldoPorHEx = hExtr * prHoraE

        sueldoBase = hNormales * prHnormal 'Precio de Horas normales

        sueldoNeto = sueldoPorHEx + sueldoBase

        txtSueldoN.Text() = FormatCurrency(sueldoNeto)
        txtSueldoBase.Text() = FormatCurrency(sueldoBase)



    End Sub

    Sub sistemaGeneralDeSalud()
        Dim ars, afp As Decimal

        ars = 2.92 / 100 * sueldoBase
        txtArs.Text() = FormatCurrency(ars)

        afp = 3.58 / 100 * sueldoBase
        txtAfp.Text() = FormatCurrency(afp)

        sisGenSalud = ars + afp
        txtSigeSa.Text() = FormatCurrency(sisGenSalud)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cont += 1
        cont1 += Val(txtArs.Text)
        dgvNomina.Rows.Add(cont.ToString(),
                            txtEmpleado.Text,
                            txtHorasT.Text,
                            txtHorasN.Text,
                            txtHorasE.Text,
                            txtSueldoBase.Text,
                            txtAfp.Text,
                            txtArs.Text,
                            txtSigeSa.Text,
                            txtSueldoISR.Text,
                            txtIsr.Text,
                            txtSueldoN.Text
                            )
        lbTotalEmp.Text = Val(cont)
        lbTotalArs.Text = 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        horaExtras()
        PrecioHoraExtra()
        sueldo()
        sistemaGeneralDeSalud()
        insentivoSobreLaRenta()

    End Sub
    
    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtAfp.Clear()
        txtArs.Clear()
        txtEmpleado.Clear()
        txtHorasE.Clear()
        txtHorasN.Clear()
        txtIsr.Clear()
        txtSueldoBase.Clear()
        txtSueldoISR.Clear()
        txtSueldoN.Clear()
        txtSueldoISR.Clear()
        txtPrecioHE.Clear()
        txtPrecioHn.Clear()
        txtIsr.Clear()
        txtHorasT.Clear()





    End Sub

    Private Sub dgvNomina_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNomina.CellContentClick

    End Sub
End Class
