using Volo.Abp.Modularity;

namespace EcommerceABP;

/* Inherit from this class for your domain layer tests. */
public abstract class EcommerceABPDomainTestBase<TStartupModule> : EcommerceABPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
