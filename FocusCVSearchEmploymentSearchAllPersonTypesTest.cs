using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Go to search field and send keys
 * Clear all filters
 * Go to focus CV search
 * Select employment
 * Go to first profile
 * Go to employment in the profile
 * Assert for "Match!" next to competence in the profile
 * Assert for "Java" in the dropdown for employment
*/

namespace Selenium.SearchCompetence.Test
{
    class FocusCVSearchEmploymentSearchAllPersonTypesTest : BaseTest
    {
        [Test]
        public void FocusCVSearchEmploymentSearchAllPersonTypes()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test FocusCVSearchEmploymentSearchAllPersonTypes");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.SendKeysSearchfield("Java");
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickFocusCVSearch();
                searchCompetencePage.ClickEmploymentFocusCVSearch();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickEmploymentProfile();
                searchCompetencePage.AssertForMatchEmploymentProfile();
                searchCompetencePage.AssertForJavaInEmploymentProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test FocusCVSearchEmploymentSearchAllPersonTypes");
            }
        }
    }
}
