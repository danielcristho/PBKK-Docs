# Pizza app using Blazor

## 1 - Components and layout

- Untuk memanggil API Backend di Blazzor, bisa menggunakan dependensi atau library `@inject HttpClient HttpClient`
- Buka Pages/Index.razor di BlazingPizza.Client, Tambahkan blok berikut. Dimana fungsinya yaitu memanggil API dari `/specials` yang sebelumnya dibuat di `BlazingPizza.Server/PizzaApiExtensions.cs`

```csharp
@code {
    List<PizzaSpecial> specials;

    protected override async Task OnInitializedAsync()
    {
        specials = await HttpClient.GetFromJsonAsync<List<PizzaSpecial>>("specials", BlazingPizza.OrderContext.Default.ListPizzaSpecial);
    }
}
```
- Tambahkan blok kode berikut di `BlazingPizza.Client/Shared/MainLayout.razor` untuk mengupdate logo dan nav-link untuk homepage:
```csharp
@inherits LayoutComponentBase

<div class="top-bar">
    <a class="logo" href="">
        <img src="img/logo.svg" />
    </a>

    <NavLink href="" class="nav-tab" Match="NavLinkMatch.All">
        <img src="img/pizza-slice.svg" />
        <div>Get Pizza</div>
    </NavLink>
</div>

<div class="content">
    @Body
</div>
```
![01-components](https://user-images.githubusercontent.com/69733783/226161796-6702e771-12e9-4af5-b349-f6653dd7ab01.png)

## 2 - Customize pizza order
Pada bagian ini ada beberapa fungsi yang dibuat, diantaranya:
 - ketika user mengklik atau memilih item pizza. Dengan begitu user dapat melakukan pemesanan.
 - pop-up yang digunakan user untuk menspesifikasikan pesanan, baik itu dari segi jumlah pizza yang dipesan, topping yang diinginkan dan total pesanan.
![02-customize](https://user-images.githubusercontent.com/69733783/226169429-7363e0d1-f1a2-4f65-abe0-dcd01c377244.png)

## 3 - Show order status
Ketika melakukan pemesanan user perlu melihat status dari pesannya, maka perlu menambahkan navigation link di `BlazingPizza.Client/Shared/MainLayout.razor` dengan nama `My Orders`.
```csharp
<div>
...
    <!--homepage nav-link-->
    <NavLink href="" class="nav-tab" Match="NavLinkMatch.All">
        <img src="img/pizza-slice.svg" />
        <div>Get Pizza</div>
    </NavLink>

    <!--my order nav-link-->
    <NavLink href="myorders" class="nav-tab">
        <img src="img/bike.svg" />
        <div>My Orders</div>
    </NavLink>
```
Kemudian buat page baru di `BlazingPizza.Client/Pages` dengan nama `MyOrders.razor`.
```csharp
@page "/myorders"

<div class="main">
    My orders will go here
</div>
```

![03-orderstatus-a](https://user-images.githubusercontent.com/69733783/226173474-45d3cc09-f2e3-4965-9f35-7123fb5fad24.png)

Tugas selanjutnya yaitu membaut tampilan untuk menampilkan daftar pesanan dari user.
![03-orderstatus-b](https://user-images.githubusercontent.com/69733783/226177524-e5cfedcb-9ab9-477c-b185-b7f0bb0c86d5.png)
