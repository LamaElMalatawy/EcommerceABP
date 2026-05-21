using EcommerceABP.Samples;
using Xunit;

namespace EcommerceABP.EntityFrameworkCore.Applications;

[Collection(EcommerceABPTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EcommerceABPEntityFrameworkCoreTestModule>
{

}
