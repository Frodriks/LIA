using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Collapse the info box (if it's expanden)
 * Clear all filters
 * Select future
 * Go to comments and q-level
 * Select completed CV profile
 * Assert for "first star filled" in the search result
 * Go to first profile
 * Assert for "first star filled" in the profile
 * Close the profile
 * Remove completed CV profile
 * Select qualified by employee
 * Assert for "second star filled" in the search result
 * Go to first profile
 * Assert for "second star filled" in the profile
 * Close the profile
 * Remove qualified by employee
 * Select successfully completed AFRY assignment
 * Assert for "third star filled" in the search result
 * Go to first profile
 * Assert for "third star filled" in the profile 
*/

namespace Selenium.SearchCompetence.Test
{
    class CommentsAndQlevelSearchFutureTest : BaseTest
    {
        [Test]
        public void CommentsAndQlevelSearchFuture()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test CommentsAndQlevelSearchFuture");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickCollapseInfoBox();
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickFuture();
                searchCompetencePage.ClickCommentsAndQLevel();
                searchCompetencePage.ClickCompletedCVProfile();
                searchCompetencePage.AssertForFirstStarSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForFirstStarProfile();
                searchCompetencePage.ClickCloseProfile();
                searchCompetencePage.ClickCompletedCVProfile();
                searchCompetencePage.ClickQualifiedByEmployee();
                searchCompetencePage.AssertForSecondStarSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForSecondStarProfile();
                searchCompetencePage.ClickCloseProfile();
                searchCompetencePage.ClickQualifiedByEmployee();
                searchCompetencePage.ClickSuccessfullyCompletedAfryAssignment();
                searchCompetencePage.AssertForThirdStarSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForThirdStarProfile();
                // Asserts for "Q-level" - Search result and Profile
            }
            else
            {
                System.Console.WriteLine("Skipping test CommentsAndQlevelSearchFuture");
            }
        }
    }
}