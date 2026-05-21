using EcommerceABP.Samples;
using Xunit;

namespace EcommerceABP.EntityFrameworkCore.Domains;

[Collection(EcommerceABPTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EcommerceABPEntityFrameworkCoreTestModule>
{

}
