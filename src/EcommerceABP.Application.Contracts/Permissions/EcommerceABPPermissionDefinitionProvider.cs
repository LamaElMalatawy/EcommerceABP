using EcommerceABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace EcommerceABP.Permissions;

public class EcommerceABPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EcommerceABPPermissions.MainGroupName);
        var productGroup = context.AddGroup(EcommerceABPPermissions.ProductGroupName, L("Products"));
        var categoryGroup = context.AddGroup(EcommerceABPPermissions.CategoryGroupName, L("Categories"));
        var orderGroup = context.AddGroup(EcommerceABPPermissions.OrderGroupName, L("Orders"));

        productGroup.AddPermission(EcommerceABPPermissions.CreateProductPermission, L("Permission:Products:CreateProduct"));
        productGroup.AddPermission(EcommerceABPPermissions.UpdateProductPermission, L("Permission:Products:UpdateProduct"));
        productGroup.AddPermission(EcommerceABPPermissions.DeleteProductPermission, L("Permission:Products:DeleteProduct"));
        productGroup.AddPermission(EcommerceABPPermissions.ViewProductPermission, L("Permission:Products:ViewProduct"));
        
        categoryGroup.AddPermission(EcommerceABPPermissions.CreateCategoryPermission, L("Permission:Categories:CreateCategory"));
        categoryGroup.AddPermission(EcommerceABPPermissions.UpdateCategoryPermission, L("Permission:Categories:UpdateCategory"));
        categoryGroup.AddPermission(EcommerceABPPermissions.DeleteCategoryPermission, L("Permission:Categories:DeleteCategory"));
        categoryGroup.AddPermission(EcommerceABPPermissions.ViewCategoryPermission, L("Permission:Categories:ViewCategory"));

        orderGroup.AddPermission(EcommerceABPPermissions.CreateOrderPermission, L("Permission:Orders:CreateOrder"));
        orderGroup.AddPermission(EcommerceABPPermissions.ViewOrderPermission, L("Permission:Orders:ViewOrder"));



    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EcommerceABPResource>(name);
    }
}
