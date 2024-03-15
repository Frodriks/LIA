using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Go to search field and send keys
 * Clear all filters
 * Go to focus CV search
 * Select presentation
 * Go to first profile
 * Assert for "Java" in the presentation
*/

namespace Selenium.SearchCompetence.Test
{
    class FocusCVSearchPresentationSearchAllPersonTypesTest : BaseTest
    {
        [Test]
        public void FocusCVSearchPresentationSearchAllPersonTypes()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test FocusCVSearchPresentationSearchAllPersonTypes");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.SendKeysSearchfield("Java");
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickFocusCVSearch();
                searchCompetencePage.ClickPresentationFocusCVSearch();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForJavaInPresentationProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test FocusCVSearchPresentationSearchAllPersonTypes");
            }
        }
    }
}