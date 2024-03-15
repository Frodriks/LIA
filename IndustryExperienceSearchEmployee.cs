using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through assignments
 * Go to industry experience
 * Send keys to search industry sector
 * Send keys to search industry sub sector
 * Send keys to mimimun experience
 * Go to first profile
 * Go to industry experience in the profile
 * Assert for "industry experience" in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class IndustryExperienceSearchEmployeeTest : BaseTest
    {
        [Test]
        public void IndustryExperienceSearchEmployee()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test IndustryExperienceSearchEmployee");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);
                AssignmentPage assignmentPage = new AssignmentPage(webDriver);

                loginPage.Login(webDriver);
                assignmentPage.ClickAssignmentDropdown();
                assignmentPage.ClickCreateAssignment();
                assignmentPage.ClickEndTour();
                assignmentPage.ClickViewAllMatchingProfiles();
                searchCompetencePage.ClickIndustryExperience();
                searchCompetencePage.SendkeysSearchIndustrySector("defence");
                searchCompetencePage.SendkeysSearchIndustrySubSector("defence industry");
                searchCompetencePage.SendkeysMinimumExperience("5");
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickIndustryExperienceProfile();
                searchCompetencePage.AssertForIndustryExperienceProfile();
                searchCompetencePage.AssertForMinimumExperienceProfile();
                // Try to fix the assert for miminum experience when there's time so i checkes if it's the years your looking for or higher
            }
            else
            {
                System.Console.WriteLine("Skipping test IndustryExperienceSearchEmployee");
            }
        }
    }
}