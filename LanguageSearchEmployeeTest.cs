using NUnit.Framework;
using SeleniumTestProject.BaseClass;
using SeleniumTestProject.Pages;

/*
 * Go to Search Competence through the app launcher
 * Go to language
 * Send keys to search for language
 * Send keys to search for language
 * Send keys to minimum knowledge level
 * Go to first profile
 * Go to language in the profile
 * Assert for "swedish and minimum knowlede level" in language dropdown in the profile
 * Assert for "english and minimum knowlede level" in language dropdown in the profile
*/

namespace Selenium.SearchCompetence.Test
{
    class LanguageSearchEmployeeTest : BaseTest
    {
        [Test]
        public void LanguageSearchSearchEmployee()
        {
            if (bool.Parse(TestContext.Parameters["Run_Stage"]) && TestContext.Parameters["Environment"] == "STAGING")
            {
                System.Console.WriteLine("Running test LanguageSearchEmployee");

                LoginPage loginPage = new LoginPage(webDriver, InsideOffice);
                ApplancherPage applancherPage = new ApplancherPage(webDriver);
                SearchCompetencePage searchCompetencePage = new SearchCompetencePage(webDriver);

                loginPage.Login(webDriver);
                applancherPage.OpenAppLauncher();
                applancherPage.ClickSearchCompetenceBtn();
                searchCompetencePage.ClickLanguage();
                searchCompetencePage.SendKeysSearchForLanguage("Swedish");
                searchCompetencePage.SendKeysSearchForLanguage("English");
                searchCompetencePage.SendkeysMinimumKnowledgeLevel("Native or bilingual");
                searchCompetencePage.ClickFirstProfile();
                searchCompetencePage.ClickLanguageProfile();
                searchCompetencePage.AssertForSwedishAndMinimumKnowledgeLevelProfile();
                searchCompetencePage.AssertForEnglishAndMinimumKnowledgeLevelProfile();
            }
            else
            {
                System.Console.WriteLine("Skipping test LanguageSearchEmployee");
            }
        }
    }
}