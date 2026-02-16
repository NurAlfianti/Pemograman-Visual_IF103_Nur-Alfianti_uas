using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProgramNilaiMahasiswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Module Module1

    Sub Main()
        ' Data disimulasikan seperti hasil baca file
        Dim dataNilai() As String = {
            "Andi,85",
            "Budi,70",
            "Citra,90",
            "Dewi,60"
        }

        ' Memanggil procedure
        ProsesNilai(dataNilai)

        Console.WriteLine("Tekan ENTER untuk keluar...")
        Console.ReadLine()
    End Sub

    ' ===== PROCEDURE =====
    Sub ProsesNilai(ByVal data() As String)

        Console.WriteLine("DAFTAR NILAI MAHASISWA")
        Console.WriteLine("====================")

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
            Console.WriteLine("--------------------")
        Next

    End Sub

End Module

        }
    }
}
