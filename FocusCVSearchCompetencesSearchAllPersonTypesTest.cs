using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Go to search field and send keys
 * Clear all filters
 * Go to focus CV search
 * Select Competence
 * Go to first profile
 * Go to competence in the profile
 * Assert for "Match!" next to competence in the profile
 * Assert for "Java" in the dropdown for competence
*/

namespace Selenium.SearchCompetence.Test
{
    class FocusCVSearchCompetencesSearchAllPersonTypesTest : BaseTest
    {
        [Test]
        public void FocusCVSearchCompetencesSearchAllPersonTypes()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test FocusCVSearchCompetencesSearchAllPersonTypes");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.SendKeysSearchfield("Java");
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickFocusCVSearch();
                searchCompetencePage.ClickCompetencesFocusCVSearch();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickCompetenceProfile();
                searchCompetencePage.AssertForJavaInCompetenceProfile();
                searchCompetencePage.AssertForMatchCompetenceProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test FocusCVSearchCompetencesSearchAllPersonTypes");
            }
        }
    }
}
