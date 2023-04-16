# .NET MAUI MVVM | BMI Calculator App

## Dokumentasi
  - Menggunakan [CommunityToolkit.MVVM](https://www.nuget.org/packages/Microsoft.Toolkit.Mvvm/7.1.2?_src=template), [sqlite-net-pcl](https://www.nuget.org/packages/sqlite-net-pcl/1.8.116?_src=template) dalam project-nya.
    ![MVVM Extension](https://github.com/danielcristho/PBKK-Docs/blob/main/dotnet/BMICalculator/Assets/Screenshot%20(50).png)
    ![SQLite Extension](https://github.com/danielcristho/PBKK-Docs/blob/main/dotnet/BMICalculator/Assets/Screenshot%20(51).png)
  - Terdapat kelas Model untuk merepresentasikan data pengukuran (nama pegawai, tanggal pengukuran, tinggi badan, berat badan, skor BMI, dan kategori BMI-nya)
    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SQLite;
    namespace BMICalculator.Models
    {
        [Table("_BMIList")]
        public class BMIData
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            [MaxLength(100), Unique]
            public string Name { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }
            public double BMIScore { get; set; }
            public String BMIResult { get; set; }
            public String TimeStamp { get; set; }
        }
    }
    ```
- Aplikasi dapat menyimpan hasil perhitungan ke dalam basis data SQLite. (contoh dari pertemuan 3).

- Terdapat 3 halaman view:
Halaman utama (memasukkan nama employee dan ada tombol untuk lihat data BMI yang telah disimpan)
Menghitung BMI dan ada tombol simpan
Melihat data BMI yang telah disimpan (dalam bentuk list view) (contoh dari pertemuan 5 aplikasi MonkeyFinder).

  Tampilan dari `EmployeePage`
  ![Employee-Page](https://user-images.githubusercontent.com/69733783/226530387-9a438e81-ab3c-44f1-8c4f-34a0c411a98c.png)
  
  Tampilan dari `BMICalculatorPage`
  ![BMI-Page](https://github.com/danielcristho/PBKK-Docs/blob/main/dotnet/BMICalculator/Assets/Screenshot%20(48).png)

    
