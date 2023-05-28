# User Roles and Permissions


| Nama                      | NRP      | Demo |
|---------------------------|----------|------|
|Gloriyano C. Daniel Pepuho |5025201121|      |

## Arsitektur

#### Model:

[`User.php`](https://github.com/danielcristho/PBKK-Docs/blob/main/laravel/blog/app/Models/User.php):
- berisi beberapa atribut untuk user seperti `name`, `email`, `password` untuk user. Kemudian ada atribut yang digunakan untuk melindungi data sensitif yaitu `password` dan `remeber_token`.
- berisi beberapa fitur seperti `Notifiable` digunakan untuk mengirim notifikasi kepada user, `HasRoles` digunakan untuk mengatur roles user, `HasFactory` digunakan untuk menghasilkan instance model dengan mudah.
- `email_verified_at` akan di-cast menjadi tipe data datetime. Ini memungkinkan manipulasi dan perbandingan yang mudah terhadap nilai ini.

[`Product.php`](https://github.com/danielcristho/PBKK-Docs/blob/main/laravel/blog/app/Models/Product.php):
- berisi atribut-atribut seperti `name` dan `detail` yang bersifat mass assignable (disi secara massal).
- menyediakan akses ke tabel `Product`, sehingga memudahkan operasi CRUD (create, read, update & delete).


#### Package:
- `laravel/ui`: menyediakan fitur-fitur yang berkaitan dengan keperluan autentikasi.
- `spatie/laravel-permission`: menyediakan fitur-fitur yang berkaitan dengan manajemen roles dan permissions dalam aplikasi.
- `laravelcollective/html`: mempermudah penggunaan HTML di Laravel.



Sumber: https://www.itsolutionstuff.com/post/laravel-8-user-roles-and-permissions-tutorialexample.html
