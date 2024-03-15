using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher 
 * Go to location
 * Send keys to search office city
 * Assert for "location" in the search result
 * Go to first profile
 * Assert for "employee" in the profile
 * Assert for "office city" in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class LocationSearchEmployeeTest : BaseTest
    {
        [Test]
        public void LocationSearchEmployee()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test LocationSearchEmployee");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickLocation();
                searchCompetencePage.SendkeysSearchOfficeCity("SE - Göteborg (Grafiska vägen)");
                searchCompetencePage.AssertForGothenburgGraphicRoadSearchResult(); 
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.AssertForEmployeeProfile();
                searchCompetencePage.AssertForGothenburgGraphicRoadProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test LocationSearchEmployee");
            }
        }
    }
}