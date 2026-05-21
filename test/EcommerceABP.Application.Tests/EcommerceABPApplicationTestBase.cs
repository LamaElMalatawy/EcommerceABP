using Volo.Abp.Modularity;

namespace EcommerceABP;

public abstract class EcommerceABPApplicationTestBase<TStartupModule> : EcommerceABPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
