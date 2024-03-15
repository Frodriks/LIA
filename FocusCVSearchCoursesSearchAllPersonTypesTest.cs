using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Go to search field and send keys
 * Clear all filters
 * Go to focus CV search
 * Select courses
 * Go to first profile
 * Go to courses in the profile
 * Assert for "Match!" next to competence in the profile
 * Assert for "Java" in the dropdown for courses
*/

namespace Selenium.SearchCompetence.Test
{
    class FocusCVSearchCoursesSearchAllPersonTypesTest : BaseTest
    {
        [Test]
        public void FocusCVSearchCoursesSearchAllPersonTypes()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test FocusCVSearchCoursesSearchAllPersonTypes");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.SendKeysSearchfield("Java");
                searchCompetencePage.ClickClearFilters();
                searchCompetencePage.ClickFocusCVSearch();
                searchCompetencePage.ClickCoursesFocusCVSearch();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickCoursesProfile();
                searchCompetencePage.AssertForMatchCoursesProfile();
                searchCompetencePage.AssertForJavaInCoursesProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test FocusCVSearchCoursesSearchAllPersonTypes");
            }
        }
    }
}
