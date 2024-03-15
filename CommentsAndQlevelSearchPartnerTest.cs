using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Collapse the info box (if it's expanden)
 * Clear all filters
 * Select partner
 * Go to comments and q-level
 * Selcet critical
 * Assert for "Critical-icon" in the search result
 * Go to first profile
 * Assert for "Critical-icon" next to "Comments" in the profile
 * Assert for "Critical-icon" in the dropdown under "Comments" in the profile
 * Close profile
 * Remove critical
 * Select important
 * Assert for "Important-icon" in the search result
 * Go to first profile
 * Assert for "Important-icon" next to "Comments" in the profile
 * Assert for "Important-icon" in the dropdown under "Comments" in the profile
 * Close profile
 * Remove important
 * Select positive
 * Assert for "Positive-icon" in the search result
 * Go to first profile
 * Assert for "Positive-icon" next to "Comments" in the profile
 * Assert for "Positive" in the dropdown under "Comments" in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class CommentsAndQlevelSearchPartnerTest : BaseTest
    {
        [Test]
        public void CommentsAndQlevelSearchPartner()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test CommentsAndQlevelSearchPartner");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickCollapseInfoBox();
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickPartner();
                searchCompetencePage.ClickCommentsAndQLevel();
                searchCompetencePage.ClickCritical();
                searchCompetencePage.AssertForCriticalSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForCriticalProfile();
                searchCompetencePage.ClickCommentsProfile();
                searchCompetencePage.AssertForCriticalCommentsDropdownProfile();
                searchCompetencePage.ClickCloseProfile();
                searchCompetencePage.ClickCritical();
                searchCompetencePage.ClickImportant();
                searchCompetencePage.AssertForImportantSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForImportantProfile();
                searchCompetencePage.ClickCommentsProfile();
                searchCompetencePage.AssertForImportantCommentsDropdownProfile();
                searchCompetencePage.ClickCloseProfile();
                searchCompetencePage.ClickImportant();
                searchCompetencePage.ClickPositive();
                searchCompetencePage.AssertForPositiveSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForPositiveProfile();
                searchCompetencePage.ClickCommentsProfile();
                searchCompetencePage.AssertForPositiveCommentsDropdownProfile();
                // Asserts for "Comments" - Search result and Profile
            }
            else
            {
                System.Console.WriteLine("Skipping test CommentsAndQlevelSearchPartner");
            }
        }
    }
}
