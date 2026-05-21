using Volo.Abp.Modularity;

namespace EcommerceABP;

[DependsOn(
    typeof(EcommerceABPDomainModule),
    typeof(EcommerceABPTestBaseModule)
)]
public class EcommerceABPDomainTestModule : AbpModule
{

}
