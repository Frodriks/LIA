using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Clear all filters
 * Select future
 * Go to location
 * Send keys to search home city
 * Send keys to search home country
 * Assert for "future" in the search result
 * Go to first profile
 * Assert for "future" in the profile
 * Assert for "home city" in the profile
 * Assert for "home country" in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class LocationSearchFutureTest : BaseTest
    {
        [Test]
        public void LocationSearchFuture()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test LocationSearchFuture");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickFuture();
                searchCompetencePage.ClickLocation();
                searchCompetencePage.SendkeysSearchHomeCity("STOCKHOLM");
                searchCompetencePage.SendkeysSearchHomeCountry("Sweden");
                searchCompetencePage.AssertForFutureSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForFutureProfile();
                searchCompetencePage.AssertForStockholmSwedenProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test LocationSearchFuture");
            }
        }
    }
}