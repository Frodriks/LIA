using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the global search field (If utside office)
 * Go to Search Competence through the app launcher (If inside office)
 * Collapse the info box (if it's expanden)
 * Remove text from search field
 * Go to search settings
 * Move tag to optional
 * Save settings
 * Send keys to search field
 * Assert for "employee" in the search result
 * Go to first profile
 * Go to competence in profile
 * Assert for "employee" in the profile
 * Assert for "Match!" next to competence in the profile
 * Assert for "C#" in competence dropdown in the profile
 * Assert for "Java" in competence dropdown in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class TagsSearchEmployeeTest : BaseTest
    {
        [Test]
        public void TagsSearchEmployee()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test TagsSearchEmployee");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);
                StartPage startPage = new StartPage(webDriver);
                SearchPage searchPage = new SearchPage(webDriver);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                /*
                 * These steps only works if you're outside of office
                 * 
                 * startPage.ClickGlobalSearch();
                 * startPage.SendKeysGlobalSearchField("Java");
                 * searchPage.ClickSearchCompetence();
                 * searchCompetencePage.RemoveSearchFromSearchfield();
                */
                searchCompetencePage.ClickCollapseInfoBox();
                searchCompetencePage.SendKeysSearchfield("Java");
                searchCompetencePage.ClickSearchSettings();
                searchCompetencePage.ClickMoveToOptional();
                searchCompetencePage.ClickSaveSearchSettings();
                searchCompetencePage.SendKeysSearchfield("C#");
                searchCompetencePage.AssertForEmployeeSearchResult();
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickCompetenceInProfile();
                searchCompetencePage.AssertForEmployeeProfile();
                searchCompetencePage.AssertForMatchCompetenceProfile();
                searchCompetencePage.AssertForCsInProfileCompetence();
                searchCompetencePage.AssertForJavaInProfileCompetence();
            }
            else
            {
                System.Console.WriteLine("Skipping test TagsSearchEmployee");
            }
        }
    }
}