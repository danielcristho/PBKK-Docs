# User Roles and Permissions


| Nama                      | NRP      | Demo |
|---------------------------|----------|------|
|Gloriyano C. Daniel Pepuho |5025201121|      |

## Arsitektur

#### Use case

- User yang memiliki role atau permission admin melakukan operasi CRUD terhadap user-user lainnya.
- User dapat melakukan operasi CRUD terhadap produk-produk yang ada di aplikasi.

#### Models:

[`User.php`](https://github.com/danielcristho/PBKK-Docs/blob/main/laravel/blog/app/Models/User.php):
- berisi beberapa atribut untuk user seperti `name`, `email`, `password` untuk user. Kemudian ada atribut yang digunakan untuk melindungi data sensitif yaitu `password` dan `remeber_token`.
- berisi beberapa fitur seperti `Notifiable` digunakan untuk mengirim notifikasi kepada user, `HasRoles` digunakan untuk mengatur roles user, `HasFactory` digunakan untuk menghasilkan instance model dengan mudah.
- `email_verified_at` akan di-cast menjadi tipe data datetime. Ini memungkinkan manipulasi dan perbandingan yang mudah terhadap nilai ini.

[`Product.php`](https://github.com/danielcristho/PBKK-Docs/blob/main/laravel/blog/app/Models/Product.php):
- berisi atribut-atribut seperti `name` dan `detail` yang bersifat mass assignable (disi secara massal).
- menyediakan akses ke tabel `Product`, sehingga memudahkan operasi CRUD (create, read, update & delete).

#### Controllers
[`UserController`](https://github.com/danielcristho/PBKK-Docs/blob/main/laravel/blog/app/Http/Controllers/UserController.php)
- terdiri dari beberapa method yang bertugas untuk mengelola user dalam aplikasi, mulai dari menampilkan user berdasarkan id, menampilkan halaman untuk membuat user baru, mengedit user, memperbarui informasi  atau data user dan menghapus user.

[`RoleController`](https://github.com/danielcristho/PBKK-Docs/blob/main/laravel/blog/app/Http/Controllers/RoleController.php)
- terdiri dari beberapa method yang bertanggung jawab untuk mengelola role dan permission dalam aplikasi.

[`ProductController`](https://github.com/danielcristho/PBKK-Docs/blob/main/laravel/blog/app/Http/Controllers/ProductController.php)
- controller yang bertanggung jawab untuk mengelola data produk dalam aplikasi.

[`HomeController`](https://github.com/danielcristho/PBKK-Docs/blob/main/laravel/blog/app/Http/Controllers/HomeController.php)
- controller yang bertanggung jawab untuk menangani tampilan pada halaman dashboard.

#### DB
- Tabel yang ada didalam database:
    - users, terdiri dari: id, name, email, password, email_verified_at, created_at, updated_at & remember_token
    - products, terdiri dari: id,name, detail, created_at & updated_at
    - role_has_permissions, terdiri dari: permission_id, role_id, created_at & updated_at
    - roles, teridiri dari: id, name, created_at & updated_at

#### Packages:
- `laravel/ui`: menyediakan fitur-fitur yang berkaitan dengan keperluan autentikasi.
- `spatie/laravel-permission`: menyediakan fitur-fitur yang berkaitan dengan manajemen roles dan permissions dalam aplikasi.
- `laravelcollective/html`: mempermudah penggunaan HTML di Laravel.


NB: Belum bisa mendemokan hasil akhir, karena masih ada kendala ketika menampilkan halaman login dan register.

Sumber: https://www.itsolutionstuff.com/post/laravel-8-user-roles-and-permissions-tutorialexample.html
