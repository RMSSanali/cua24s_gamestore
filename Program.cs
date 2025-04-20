using GameStore.Services;
using Azure.Identity; // ✅ This should be at the top

var builder = WebApplication.CreateBuilder(args);

// 🔐 Add Key Vault configuration
builder.Configuration.AddAzureKeyVault(
    new Uri("https://sanaligamestore-keyvault.vault.azure.net/"),
    new DefaultAzureCredential());

// Lägg till tjänster för MVC och GameService
// 🧩 Add services for MVC and GameService
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<GameService>();

var app = builder.Build();

// ✅ TEST: Print secret from Key Vault to terminal
//Console.WriteLine("🔐 API Key from Key Vault: " + builder.Configuration["MyAPIKey"]);
// Trigger GitHub Actions pipeline test



// Konfigurera HTTP-anrop
// ⚙️ Configure HTTP pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Games}/{action=Index}/{id?}");

app.Run();
