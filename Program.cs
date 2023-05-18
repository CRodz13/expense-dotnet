using Microsoft.EntityFrameworkCore;
using Expense_Tracker.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

// Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVk1mQ1BCaV1CX2BZf1F8QGpTfV5gFChNYlxTR3ZaQ1piS3tadERlWHpf;Mgo+DSMBPh8sVXJ1S0R+X1pCaV5EQmFJfFBmRGFTeld6dlVWACFaRnZdQV1mSHlSdEBqW35Ycn1U;ORg4AjUWIQA/Gnt2VFhiQlJPcEBDW3xLflF1VWJbdVt5fldGcDwsT3RfQF5jTH9Ud0dmUH1fdnBXRw==;MjA5MzUyNUAzMjMxMmUzMjJlMzNJOFAvdjFYTlBzT3N5T1dKaVNXbW9PaW9UajhPOFlZajJQa0ppNFQ3QXNvPQ==;MjA5MzUyNkAzMjMxMmUzMjJlMzNrbFAyVDZZUm5uYS9HRnVJYTNYdVkzQlQ4MVo1c3FPRlVFTTI1V09GSWE4PQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVldXGVWfFN0RnNYfVR1fV9EYEwxOX1dQl9gSXtScURhXHZccXJcTmE=;MjA5MzUyOEAzMjMxMmUzMjJlMzNNMUE5UVhvSEhDS2tWQXdJVGJncEo0RHpHTHFLR2tUclVwa3lIUUVnVTI4PQ==;MjA5MzUyOUAzMjMxMmUzMjJlMzNNUWVudkNsMFlqUVVLd3hGbFh6a1M1YXU0SmsybGljZVRVNDFPMTVMRlRvPQ==;Mgo+DSMBMAY9C3t2VFhiQlJPcEBDW3xLflF1VWJbdVt5fldGcDwsT3RfQF5jTH9Ud0dmUH1fd3FRRw==;MjA5MzUzMUAzMjMxMmUzMjJlMzNjTkpWdDNFMmV5VGdsdWxDU1VmUHBIM1lVeGVXWHZIK2JWcUEyNmV2cy9JPQ==;MjA5MzUzMkAzMjMxMmUzMjJlMzNiN1BXdkxSeXBJYi9zQUlzcGJSTkdMcmgvTkJWdGZqL1VkeUM3NC9LejZRPQ==;MjA5MzUzM0AzMjMxMmUzMjJlMzNNMUE5UVhvSEhDS2tWQXdJVGJncEo0RHpHTHFLR2tUclVwa3lIUUVnVTI4PQ==");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
