using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Collapse the info box (if it's expanden)
 * Clear all filters
 * Select emeritus
 * Go to comments and q-level
 * Select critical, important and positive
 * Select completed CV profile, qualified by employee and successfully completed AFRY assignment
 * Assert for "any star filled" in the search result
 * Assert for "any comment-icon" in search result
 * Go to first profile
 * Assert for "any star filled" in the profile
 * Assert for "any comment-icon" next to "Comments" in the profile
 * Assert for "any comment-icon" in the dropdown under "Comments" in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class CommentsAndQlevelSearchEmeritusTest : BaseTest
    {
        [Test]
        public void CommentsAndQlevelSearchEmeritus()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test CommentsAndQlevelSearchEmeritus");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickCollapseInfoBox();
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickEmeritus();
                searchCompetencePage.ClickCommentsAndQLevel();
                searchCompetencePage.ClickCritical();
                searchCompetencePage.ClickImportant();
                searchCompetencePage.ClickPositive();
                searchCompetencePage.ClickCompletedCVProfile();
                searchCompetencePage.ClickQualifiedByEmployee();
                searchCompetencePage.ClickSuccessfullyCompletedAfryAssignment();
                searchCompetencePage.AssertForQLevelSearchResult();
                searchCompetencePage.AssertForCommentsSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickCommentsProfile();
                searchCompetencePage.AssertForQLevelProfile();
                searchCompetencePage.AssertForCommentsProfile();
                searchCompetencePage.AssertForCommentsDropdownProfile();
                // Asserts for any "Comments and Q-Level" - Search result and Profile
            }
            else
            {
                System.Console.WriteLine("Skipping test CommentsAndQlevelSearchEmeritus");
            }
        }
    }
}