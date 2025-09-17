Imports System.Net.Security

Public Class Aire
    Public marca, pais As String
    Private _frigorias, _temperatura As Integer
    Public split, friosolo, encendido As Boolean

    Public Property frigorias As Integer
        Get
            Return _frigorias
        End Get
        Set(value As Integer)
            If (value >= 1000 And value <= 10000) Then
                _frigorias = value
            Else
                MsgBox("Numero de frigorias invalido.")
            End If
        End Set
    End Property

    Public Property temperatura As Integer
        Get
            Return _temperatura
        End Get
        Set(value As Integer)
            If (value >= 17 And value <= 31) Then
                _temperatura = value
            End If
        End Set
    End Property

    Public Sub New(marca As String, pais As String, frigorias As Integer, temperatura As Integer, split As Boolean, friosolo As Boolean, encendido As Boolean)
        Me.marca = marca
        Me.pais = pais.ToUpper()
        Me.frigorias = frigorias
        Me.temperatura = temperatura
        Me.split = split
        Me.friosolo = friosolo
        Me.encendido = encendido
    End Sub

    Public Sub New()

    End Sub

    Public ReadOnly Property Modelo As String
        Get
            Dim modo As String = If(friosolo, "FS", "FC")
            Dim splittag As String = If(split, "/S", "")
            Return marca.Substring(0, 3).ToUpper() & frigorias.ToString() & pais.Substring(0, 3).ToUpper() & modo & splittag
        End Get
    End Property

    Public Function POWER()
        encendido = Not encendido
        If encendido Then
            Me.encendido = True
            Return "ON"
        Else
            Me.encendido = False
            Return "OFF"
        End If
    End Function

    Public Function Subir(grados As Integer)
        If (Me.friosolo = True) Then
            If (Me.split = True) Then
                If (Me.temperatura + grados > 25) Then
                    Me.temperatura = 25
                Else
                    Me.temperatura = Me.temperatura + grados
                End If
            End If
            If (Me.split = False) Then
                If (Me.temperatura + grados > 24) Then
                    Me.temperatura = 24
                Else
                    Me.temperatura = Me.temperatura + grados
                End If
            End If
        End If
        If (Me.friosolo = False) Then
            If (Me.split = True) Then
                If (Me.temperatura + grados > 31) Then
                    Me.temperatura = 31
                Else
                    Me.temperatura = Me.temperatura + grados
                End If
            End If
            If (Me.split = False) Then
                If (Me.temperatura + grados > 30) Then
                    Me.temperatura = 30
                Else
                    Me.temperatura = Me.temperatura + grados
                End If
            End If
        End If

        Return Me.temperatura
    End Function

    Public Function SUBIR()
        If (Me.friosolo = True) Then
            If (Me.split = True) Then
                Me.temperatura = 25
            Else
                Me.temperatura = 24
            End If
        End If
        If (Me.friosolo = False) Then
            If (Me.split = True) Then
                Me.temperatura = 31
            Else
                Me.temperatura = 30
            End If
        End If

        Return Me.temperatura
    End Function

    Public Function BAJAR(grados As Integer)
        If (Me.split = True) Then
            If (Me.temperatura - grados < 17) Then
                Me.temperatura = 17
            Else
                Me.temperatura = Me.temperatura - grados
            End If
        End If
        If (Me.split = False) Then
            If (Me.temperatura - grados < 18) Then
                Me.temperatura = 18
            Else
                Me.temperatura = Me.temperatura - grados
            End If
        End If

        Return Me.temperatura
    End Function

    Public Function BAJAR()
        If (Me.split = True) Then
            Me.temperatura = 17
        End If
        If (Me.split = False) Then
            Me.temperatura = 18
        End If

        Return Me.temperatura
    End Function
End Class