using System.Globalization;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class LanguageService
    {
        public string CurrentCulture { get; private set; } = "en";

        public void ChangeLanguage(string culture)
        {
            CurrentCulture = culture;
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = new CultureInfo(culture);
        }

        public Task<string> GetCurrentLanguageAsync()
        {
            return Task.FromResult(CurrentCulture);
        }
    }
}
