using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher 
 * Clear all filters
 * Select emeritus
 * Go to location
 * Send keys to search home city
 * Send keys to search home country
 * Assert for "emeritus" in the search result
 * Go to first profile
 * Assert for "emeritus" in the profile
 * Assert for "home city" in the profile
 * Assert for "home country" in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class LocationSearchEmeritusTest : BaseTest
    {
        [Test]
        public void LocationSearchEmeritus()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test LocationSearchEmeritus");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickEmeritus();
                searchCompetencePage.ClickLocation();
                searchCompetencePage.SendkeysSearchHomeCity("STOCKHOLM");
                searchCompetencePage.SendkeysSearchHomeCountry("Sweden");
                searchCompetencePage.AssertForEmeritusSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForEmeritusProfile();

                System.Console.WriteLine("This test is not complete and will fail beacause of a bug, look in the code for more information");
                // There's a bug for "Emeritus - Location (Bug: 73648)", so can't do assert for location in a Emeritus profile

                searchCompetencePage.AssertForStockholmSwedenProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test LocationSearchEmeritus");
            }
        }
    }
}