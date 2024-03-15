using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Clear all filters
 * Select subconsultant
 * Go to location
 * Send keys to search home city
 * Send keys to search home country
 * Assert for "subconsultant" in the search result
 * Go to first profile
 * Assert for "subconsultant" in the profile
 * Assert for "home city" in the profile
 * Assert for "home country" in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class LocationSearchForSubconsultantTest : BaseTest
    {
        [Test]
        public void LocationSearchSubconsultant()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test LocationSearchSubconsultant");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickLocation();
                searchCompetencePage.SendkeysSearchOfficeCity("SE - Göteborg (Grafiska vägen)");
                searchCompetencePage.ClickSubconsultant();
                searchCompetencePage.AssertForSubconsultantSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForSubconsultantProfile();
                searchCompetencePage.AssertForGothenburgGraphicRoadProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test LocationSearchSubconsultant");
            }
        }
    }
}