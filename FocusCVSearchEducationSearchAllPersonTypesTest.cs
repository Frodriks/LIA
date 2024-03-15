using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Go to search field and send keys
 * Clear all filters
 * Go to focus CV search
 * Select education
 * Go to first profile
 * Go to education in the profile
 * Assert for "Match!" next to competence in the profile
 * Assert for "Java" in the dropdown for education
*/

namespace Selenium.SearchCompetence.Test
{
    class FocusCVSearchEducationSearchAllPersonTypesTest : BaseTest
    {
        [Test]
        public void FocusCVSearchEducationSearchAllPersonTypes()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test FocusCVSearchEducationSearchAllPersonTypes");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.SendKeysSearchfield("Java");
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickFocusCVSearch();
                searchCompetencePage.ClickEducationFocusCVSearch();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickEducationProfile();
                searchCompetencePage.AssertForJavaInEducationProfile();
                searchCompetencePage.AssertForMatchEducationProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test FocusCVSearchEducationSearchAllPersonTypes");
            }
        }
    }
}
