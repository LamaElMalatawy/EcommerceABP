namespace EcommerceABP;

public static class EcommerceABPDomainErrorCodes
{
    public const string ProductPriceMustBeGreaterThanZero = "Ecommerce:00001";
    public const string ProductStockCannotBeNegative = "Ecommerce:00002";
    public const string ProductCannotBelongToMoreThanOneCategory = "Ecommerce:00003";
    public const string ProductNotFound = "Ecommerce:00004";
    public const string ProductNameMustBeUnique = "Ecommerce:00005";
    public const string ProductMustBelongToCategory = "Ecommerce:00006";
   
    public const string CategoryNotFound = "Ecommerce:00007";
    public const string CategoryCannotBeItsOwnParent = "Ecommerce:00008";
    public const string CategoryNameMustBeUnique = "Ecommerce:00009";
    
    public const string OrderNotFound = "Ecommerce:00010";
    public const string OrderMustHaveAtLeastOneProduct = "Ecommerce:00011";
    public const string OrderQuantityMustBePositive = "Ecommerce:00012";


}
