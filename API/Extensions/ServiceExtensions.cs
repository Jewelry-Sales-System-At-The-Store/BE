using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.DTO.Other;
using BusinessObjects.Models;
using DAO;
using Management.Implementation;
using Management.Interface;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using MongoDB.Driver;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Implementation;
using Services.Interface;

namespace API.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddScopeService(this IServiceCollection serviceCollection)
    {
        #region Management

        serviceCollection.AddScoped<IUserManagement, UserManagement>();

        #endregion
        
        #region Repository

        serviceCollection.AddScoped<IUserRepository, UserRepository>();
        serviceCollection.AddScoped<IJewelryRepository, JewelryRepository>();
        serviceCollection.AddScoped<IWarrantyRepository, WarrantyRepository>();
        serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
        serviceCollection.AddScoped<IPromotionRepository, PromotionRepository>();
        serviceCollection.AddScoped<IBillRepository, BillRepository>();
        serviceCollection.AddScoped<IJewelryTypeRepository, JewelryTypeRepository>();
        serviceCollection.AddScoped<IRoleRepository, RoleRepository>();
        serviceCollection.AddScoped<IGoldPriceRepository, GoldPriceRepository>();
        serviceCollection.AddScoped<IGemPriceRepository, GemPriceRepository>();
        serviceCollection.AddScoped<IBillPromotionRepository, BillPromotionRepository>();
        serviceCollection.AddScoped<IBillJewelryRepository, BillJewelryRepository>();
        serviceCollection.AddScoped<IBillDetailRepository, BillDetailRepository>();
        serviceCollection.AddScoped<IJewelryMaterialRepository, JewelryMaterialRepository>();

        #endregion
        
        #region Service

        serviceCollection.AddScoped<IGemPriceService, GemPriceService>();
        serviceCollection.AddScoped<IGoldPriceService, GoldPriceService>();
        serviceCollection.AddScoped<IRoleService, RoleService>();
        serviceCollection.AddScoped<IUserService, UserService>();
        serviceCollection.AddScoped<IJewelryService, JewelryService>();
        serviceCollection.AddScoped<IWarrantyService, WarrantyService>();
        serviceCollection.AddScoped<ICustomerService, CustomerService>();
        serviceCollection.AddScoped<IBillService, BillService>();
        serviceCollection.AddScoped<IPromotionService, PromotionService>();
        serviceCollection.AddScoped<IJewelryTypeService, JewelryTypeService>();
        serviceCollection.AddScoped<ITokenService, TokenService>();

        #endregion
        
        #region Dao

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
        serviceCollection.AddScoped<GemPriceDao>();
        serviceCollection.AddScoped<UserDao>();
        serviceCollection.AddScoped<WarrantyDao>();
        serviceCollection.AddScoped<JewelryMaterialDao>();

        #endregion
        
        #region MongoDb
        serviceCollection.AddSingleton<IMongoClient, MongoClient>(s =>
        {
            var uri = s.GetRequiredService<IConfiguration>()["MongoDb:CloudConnectionString"];
            return new MongoClient(uri);
        });
        #endregion
        
        #region Odata
        serviceCollection.AddControllers().AddOData(opt =>
        {
            opt.Select().Filter().OrderBy().Expand().Count().SetMaxTop(100).AddRouteComponents("odata", GetEdmModel());
        });
        #endregion
        
        return serviceCollection;
    }
    static IEdmModel GetEdmModel()
    {
        var builder = new ODataConventionModelBuilder();
        builder.EntitySet<User>("Users");
        return builder.GetEdmModel();
    }
}
