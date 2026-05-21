using Xunit;

namespace EcommerceABP.EntityFrameworkCore;

[CollectionDefinition(EcommerceABPTestConsts.CollectionDefinitionName)]
public class EcommerceABPEntityFrameworkCoreCollection : ICollectionFixture<EcommerceABPEntityFrameworkCoreFixture>
{

}
