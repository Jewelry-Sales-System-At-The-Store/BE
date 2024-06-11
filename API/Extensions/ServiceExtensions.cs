using DAO;
using Management.Implementation;
using Management.Interface;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Implementation;
using Services.Interface;

namespace API.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddScopeService(this IServiceCollection serviceCollection)
    {
        //Management
        serviceCollection.AddScoped<IUserManagement, UserManagement>();
        //Repositories
        serviceCollection.AddScoped<IUserRepository, UserRepository>();
        serviceCollection.AddScoped<IJewelryRepository, JewelryRepository>();
        serviceCollection.AddScoped<IWarrantyRepository, WarrantyRepository>();
        serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
        serviceCollection.AddScoped<IPromotionRepository, PromotionRepository>();
        serviceCollection.AddScoped<IBillRepository, BillRepository>();
        serviceCollection.AddScoped<IJewelryTypeRepository, JewelryTypeRepository>();
        //Services
        serviceCollection.AddScoped<IUserService, UserService>();
        serviceCollection.AddScoped<IJewelryService, JewelryService>();
        serviceCollection.AddScoped<IWarrantyService, WarrantyService>();
        serviceCollection.AddScoped<ICustomerService, CustomerService>();
        serviceCollection.AddScoped<IBillService, BillService>();
        serviceCollection.AddScoped<IPromotionService, PromotionService>();
        serviceCollection.AddScoped<IJewelryTypeService, JewelryTypeService>();
        //DAO
        serviceCollection.AddScoped<BillDao>();
        serviceCollection.AddScoped<BillJewelryDao>();
        serviceCollection.AddScoped<BillPromotionDao>();
        serviceCollection.AddScoped<CustomerDao>();
        serviceCollection.AddScoped<GoldPriceDao>();
        serviceCollection.AddScoped<JewelryDao>();
        serviceCollection.AddScoped<JewelryTypeDao>(); 
        serviceCollection.AddScoped<PromotionDao>();
        serviceCollection.AddScoped<PurchaseDao>();
        serviceCollection.AddScoped<RoleDao>();
        serviceCollection.AddScoped<StonePriceDao>();
        serviceCollection.AddScoped<UserDao>();
        serviceCollection.AddScoped<WarrantyDao>();
        
        return serviceCollection;
    }
}