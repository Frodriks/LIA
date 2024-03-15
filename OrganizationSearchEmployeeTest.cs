using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Go to organization
 * Send keys to division
 * Send keys to business area
 * Send keys to busniess unit
 * Send keys to business section
 * Assert for "electrical engineering teknoplan stockholm" in the search result
 * Go to first profile
 * Go to organization in the profile
 * Assert for "division" in the profile
 * Assert for "business area" in the profile
 * Assert for "busniess unit" in the profile
 * Assert for "business section" in the profile
*/

namespace Selenium.SearchCompetence.Tests
{
    class OrganizationSearchEmployeeTest : BaseTest
    {
        [Test]
        public void OrganizationSearchEmployee()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test OrganizationSearchEmployee");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickOrganization();
                searchCompetencePage.SendkeysDivision("INFRASTRUCTURE");
                searchCompetencePage.SendKeysBusinessArea("BA Buildings Sweden");
                searchCompetencePage.SentKeysBusinessUnit("BU Buildings Sweden East");
                searchCompetencePage.SendKeysBusinessSection("Electrical Engineering Teknoplan Stockholm");
                searchCompetencePage.AssertForElectircalEngineeringTeknoplanStockholmSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickOrganizationInProfile();
                searchCompetencePage.AssertForInfrastructureProfile();
                searchCompetencePage.AssertForBABuildingsSwedenProfile();
                searchCompetencePage.AssertForBUBuildingsSwedenEastProfile();
                searchCompetencePage.AssertForElectricalEngineeringTeknoplanStockholmProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test OrganizationSearchEmployee");
            }
        }
    }
}