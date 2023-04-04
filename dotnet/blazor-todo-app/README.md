# To Do App using Blazor and .NET MAUI
## Hasil

-   Tampilan Home page
![1](https://user-images.githubusercontent.com/69733783/222955048-147a897c-a736-4aae-b4a7-47b677b65acf.png)

- Tampilan Todo page. Todo list yang kita buat dapat disimpan ke local disk di komputer dengan format **".json"**
![2.1](https://user-images.githubusercontent.com/69733783/222955212-dfd4b0d8-aed9-42ee-be90-583f42b24d21.png)
![2.2](https://user-images.githubusercontent.com/69733783/222955213-84f6e2d1-9f3d-407d-89b9-d45501683ea9.png)

- Tampilan About page
![3](https://user-images.githubusercontent.com/69733783/222955418-4d82c3fd-cd0d-4e19-a112-85d92a258a2a.png)

- Untuk membuat halaman baru perlu menambahkan beberapa hal:
1. Buat komponen baru di directory **Pages**, dengan nama **"About.razor"**. Isi filenya:

  ```csharp
@page "/about"

<h1>About me</h1>
<h3>I am Gloriyano C. Daniel Pepuho, my ID is 5025201121</h3>

<!--Menambahkan gambar-->
<img src="images/me.jpeg" asp-append-version="true" width="300" />
@code {

}
  ```
2. Tambahkan elemen **div**, agar dapat membuat link yang mengarah ke about page. Caranya dengan  edit file **NavMenu.razor** yang berada di direktori **Shared**.

```csharp
<div class="@NavMenuCssClass" @onclick="ToggleNavMenu">
...
    <div class="nav-item px-3">
			<NavLink class="nav-link" href="about">
				<span class="oi oi-home" aria-hidden="true"></span> About
			</NavLink>
		</div>
...    
```


Sumber: https://learn.microsoft.com/en-us/training/modules/build-blazor-hybrid/
