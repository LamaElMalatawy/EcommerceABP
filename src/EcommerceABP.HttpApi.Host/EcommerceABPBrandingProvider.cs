using Microsoft.Extensions.Localization;
using EcommerceABP.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EcommerceABP;

[Dependency(ReplaceServices = true)]
public class EcommerceABPBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<EcommerceABPResource> _localizer;

    public EcommerceABPBrandingProvider(IStringLocalizer<EcommerceABPResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
