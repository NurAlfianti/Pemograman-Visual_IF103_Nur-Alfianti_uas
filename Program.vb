Module Module1

    Sub Main()
        ' ============================
        ' SIMULASI DATA (SEOLAH BACA FILE)
        ' ============================
        Dim dataNilai() As String = {
            "Andi,85",
            "Budi,70",
            "Citra,90",
            "Dewi,60"
        }

        ' Memanggil procedure
        ProsesNilai(dataNilai)

        Console.WriteLine()
        Console.WriteLine("Tekan ENTER untuk keluar...")
        Console.ReadLine()
    End Sub

    ' ============================
    ' PROCEDURE
    ' ============================
    Sub ProsesNilai(ByVal data() As String)

        Console.WriteLine("DAFTAR NILAI MAHASISWA")
        Console.WriteLine("=====================")

        ' ===== PERULANGAN =====
        For Each item As String In data
            Dim splitData() As String = item.Split(",")

            Dim nama As String = splitData(0)
            Dim nilai As Integer = CInt(splitData(1))
            Dim status As String

            ' ===== PERCABANGAN =====
            If nilai >= 75 Then
                status = "Lulus"
            Else
                status = "Tidak Lulus"
            End If

            Console.WriteLine("Nama   : " & nama)
            Console.WriteLine("Nilai  : " & nilai)
            Console.WriteLine("Status : " & status)
            Console.WriteLine("---------------------")
        Next

    End Sub

End Module
