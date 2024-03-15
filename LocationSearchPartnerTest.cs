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
 * Assert for "partner" in the search result
 * Assert for "location" in the search result
 * Go to first profile
 * Assert for "partner" in the profile
 * Assert for "home city" in the profile
 * Assert for "home country" in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class LocationSearchPartnerTest : BaseTest
    {
        [Test]
        public void LocationSearchPartner()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test LocationSearchPartner");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickPartner();
                searchCompetencePage.ClickLocation();
                searchCompetencePage.SendkeysSearchHomeCity("STOCKHOLM");
                searchCompetencePage.SendkeysSearchHomeCountry("Sweden");
                searchCompetencePage.AssertForPartnerSearchResult();
                searchCompetencePage.AssertForStockholmSwedenSearchRestult(); 
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForPartnerProfile();
                searchCompetencePage.AssertForStockholmSwedenProfile();
                //searchCompetencePage.AssertForSwedenProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test LocationSearchPartner");
            }
        }
    }
}