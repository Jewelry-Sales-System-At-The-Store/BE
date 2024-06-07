using Management.Implementation;
using Management.Interface;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Implementation;
using Services.Interface;

namespace API.Extentions;

public static class ServiceExtensions
{
    public static IServiceCollection AddScopeService(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUserManagement, UserManagement>();
        serviceCollection.AddScoped<IUserRepository, UserRepository>();
        serviceCollection.AddScoped<IJewelryService, JewelryService>();
        serviceCollection.AddScoped<IJewelryRepository, JewelryRepository>();
        serviceCollection.AddScoped<IWarrantyService, WarrantyService>();
        serviceCollection.AddScoped<IWarrantyRepository, WarrantyRepository>();
        serviceCollection.AddScoped<ICustomerService, CustomerService>();
        serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
        serviceCollection.AddScoped<IBillService, BillService>();
        serviceCollection.AddScoped<IBillRepository, BillRepository>();
        serviceCollection.AddScoped<IPromotionService, PromotionService>();
        serviceCollection.AddScoped<IPromotionRepository, PromotionRepository>();
        serviceCollection.AddScoped<IJewelryTypeService, JewelryTypeService>();
        serviceCollection.AddScoped<IJewelryTypeRepository, JewelryTypeRepository>();
        return serviceCollection;
    }
}