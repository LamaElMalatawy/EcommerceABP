namespace EcommerceABP.Permissions;

public static class EcommerceABPPermissions
{
    public const string MainGroupName = "EcommerceABP";
    
    public const string ProductGroupName = MainGroupName + ".Products";
    public const string CreateProductPermission = ProductGroupName + ".Create";
    public const string UpdateProductPermission = ProductGroupName + ".Update";
    public const string DeleteProductPermission = ProductGroupName + ".Delete";
    public const string ViewProductPermission = ProductGroupName + ".View";

    public const string CategoryGroupName = MainGroupName + ".Categories";
    public const string CreateCategoryPermission = CategoryGroupName + ".Create";
    public const string UpdateCategoryPermission = CategoryGroupName + ".Update";
    public const string DeleteCategoryPermission = CategoryGroupName + ".Delete";
    public const string ViewCategoryPermission = CategoryGroupName + ".View";

    public const string OrderGroupName = MainGroupName + ".Orders";
    public const string CreateOrderPermission = OrderGroupName + ".Create";
    public const string ViewOrderPermission = OrderGroupName + ".View";


    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
