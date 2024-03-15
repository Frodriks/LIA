using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Go to search field and send keys
 * Clear all filters
 * Go to focus CV search
 * Select assignments
 * Go to first profile
 * Select show matches
 * Go to first assignment
 * Assert for "Match!" next to assignments in the profile
 * Assert for "Java" in the assignment
*/

namespace Selenium.SearchCompetence.Test
{
    class FocusCVSearchAssignmentsSearchAllPersonTypesTest : BaseTest
    {
        [Test]
        public void FocusCVSearchAssignmentsSearchAllPersonTypes()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test FocusCVSearchAssignmentsSearchAllPersonTypes");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.SendKeysSearchfield("Java");
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickFocusCVSearch();
                searchCompetencePage.ClickAssignmentsFocusCVSearch();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickShowMatchesAssignmentsProfile();
                searchCompetencePage.ClickFirstAssignmentProfile();
                searchCompetencePage.AssertForMatchAssignmentsProfile();
                searchCompetencePage.AssertForJavaInAssignmentsProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test FocusCVSearchAssignmentsSearchAllPersonTypes");
            }
        }
    }
}