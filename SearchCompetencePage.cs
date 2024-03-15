using DocumentFormat.OpenXml.Spreadsheet;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTestProject.BaseClass;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.DevTools.V112.Emulation;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SeleniumTestProject.Pages
{
    public class SearchCompetencePage
    {
        public SearchCompetencePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        // Clear filters
        public IWebElement SelectClearFilters => Driver.FindElement(By.XPath("//img[@class='trashcan-icon']"));

        //Filters - Focus CV search
        public IWebElement SelectFocusCVSearch => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//div[contains(text(), 'Focus CV search')]"));
        public IWebElement SelectPresentationFocusCVSearch => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[1]"));
        public IWebElement SelectAssignmentsFocusCVSearch => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[2]"));
        public IWebElement SelectEmploymentFocusCVSearch => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[3]"));
        public IWebElement SelectCoursesFocusCVSearch => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[4]"));
        public IWebElement SelectEducationFocusCVSearch => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[5]"));
        public IWebElement SelectCompetenceFocusCVSearch => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[6]"));

        // Filters - Organization
        public IWebElement SelectOrganization => Driver.FindElement(By.XPath("//div[contains(text(),'Organization')]"));
        public IWebElement SearchDivison => Driver.FindElement(By.Id("react-select-8-input"));
        public IWebElement SelectSearchDivisonDropDown => Driver.FindElement(By.Id("react-select-8-listbox"));
        public IWebElement SearchBusinessArea => Driver.FindElement(By.Id("react-select-9-input"));
        public IWebElement SelectBusinessAreaDropDown => Driver.FindElement(By.Id("react-select-9-listbox"));
        public IWebElement SearchBusinessUnit => Driver.FindElement(By.Id("react-select-10-input"));
        public IWebElement SelectBusinessUnitDropDown => Driver.FindElement(By.Id("react-select-10-listbox"));
        public IWebElement SearchBusinessSection => Driver.FindElement(By.Id("react-select-11-input"));
        public IWebElement SelectBusinessSectionDropDown => Driver.FindElement(By.Id("react-select-11-listbox"));

        // Filters - Industry Experience
        public IWebElement SelectIndustryExperience => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//div[contains(text(),'Industry Experience')]"));
        public IWebElement SelectSearchIndustrySector => Driver.FindElement(By.Id("react-select-5-input"));
        public IWebElement SelectIndustrySectorDropdown => Driver.FindElement(By.Id("react-select-5-listbox"));
        public IWebElement SelectSearchIndustrySubSector => Driver.FindElement(By.Id("react-select-15-input"));
        public IWebElement SelectIndustrySubSectorDropdown => Driver.FindElement(By.Id("react-select-15-listbox"));
        public IWebElement SelectMinimumExperience => Driver.FindElement(By.Id("min_yoc"));

        // Filters - Location
        public IWebElement SelectLocation => Driver.FindElement(By.XPath("//div[@Class='sc-dubCtV bWnAzg box-collapse__header']//div[contains(text(), 'Location')]"));
        public IWebElement SelectSearchOfficeCity => Driver.FindElement(By.Id("react-select-3-input"));
        public IWebElement SelectSearchOfficeCityDropDown => Driver.FindElement(By.Id("react-select-3-listbox"));
        public IWebElement SelectSearchHomeCity => Driver.FindElement(By.Id("react-select-4-input"));
        public IWebElement SelectSearchHomeCityDropdown => Driver.FindElement(By.Id("react-select-4-listbox"));
        public IWebElement SelectSearchHomeCountry => Driver.FindElement(By.Id("react-select-5-input"));
        public IWebElement SelectSearchHomeCountryDropdown => Driver.FindElement(By.Id("react-select-5-listbox"));

        // Filters - Language
        public IWebElement SelectLanguage => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//div[contains(text(), 'Language')]"));
        public IWebElement SelectSearchForLanguage => Driver.FindElement(By.Id("react-select-6-input"));
        public IWebElement SelectMinimumKnowledgeLevel => Driver.FindElement(By.Id("react-select-7-input"));

        // Filters - Comments and Q-level
        public IWebElement SelectCommentsAndQLevel => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//div[contains(text(), 'Comments and Q-level')]"));
        public IWebElement SelectCritical => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[7]"));
        public IWebElement SelectImportant => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[8]"));
        public IWebElement SelectPositive => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[9]"));
        public IWebElement SelectCompletedCVProfile => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[10]"));
        public IWebElement SelectQualifiedByEmployee => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[11]"));
        public IWebElement SelectSuccessfullyCompletedAfryAssignment => Driver.FindElement(By.XPath("(//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR'])[12]"));

        // Filters - Person type
        public IWebElement SelectPersonType => Driver.FindElement(By.XPath("//div[@Class='sc-dubCtV bWnAzg box-collapse__header']//div[contains(text(), 'Person type')]"));
        public IWebElement SelectEmployee => Driver.FindElement(By.XPath("(//div[@Class='sc-eZceyY hqaiOy'])[1]//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR']"));
        public IWebElement SelectPartner => Driver.FindElement(By.XPath("(//div[@Class='sc-eZceyY hqaiOy'])[2]//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR']"));
        public IWebElement SelectSubconsultant => Driver.FindElement(By.XPath("(//div[@Class='sc-eZceyY hqaiOy'])[3]//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR']"));
        public IWebElement SelectEmeritus => Driver.FindElement(By.XPath("(//div[@Class='sc-eZceyY hqaiOy'])[4]//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR']"));
        public IWebElement SelectFuture => Driver.FindElement(By.XPath("(//div[@Class='sc-eZceyY hqaiOy'])[5]//button[@class='sc-ibYzZP sc-ibvwTS fBcBNP dqExHR']"));

        // Search result
        public IWebElement SelectFirstProfile => Driver.FindElement(By.XPath("(//div[@class='sc-jTVQyt eocPgS'])[1]"));

        // Profile
        public IWebElement SelectCloseProfile => Driver.FindElement(By.XPath("//button[@class='sc-fekXMp kcLswn sc-cv-preview__navButton']//img[@alt='Close icon']"));
        public IWebElement SelectOrganizationInProfile => Driver.FindElement(By.XPath("//div[b='Organization']"));
        public IWebElement SelectCompetenceInProfile => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Competence')]"));
        public IWebElement SelectIndustryExperienceProfile => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(),'Industry Experience')]"));
        public IWebElement SelectShowMatchesAssignmentsProfile => Driver.FindElement(By.XPath("//div[contains(text(), 'Show matches')]//button[@class='sc-fXUhBo gNsQIj']"));
        public IWebElement SelectFirstAssignmentProfile => Driver.FindElement(By.XPath("(//div[@class='box-collapse'])[1]//div[@class='sc-dubCtV bWnAzg box-collapse__header']//span[@class='sc-knEsKG eOTgzk']"));
        public IWebElement SelectEmploymentProfile => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Employment')]"));
        public IWebElement SelectCoursesProfile => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Courses')]"));
        public IWebElement SelectEducationProfile => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Education')]"));
        public IWebElement SelectCompetenceProfile => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Competence')]"));
        public IWebElement SelectCommentsProfile => Driver.FindElement(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Comments')]"));

        // Search field
        public IWebElement RemoveTextFromSearchField => Driver.FindElement(By.CssSelector(".svg-inline--fa.fa-window-close.fa-w-16"));
        public IWebElement SelectSearchfield => Driver.FindElement(By.Id("searchInput"));
        public IWebElement SelectFirstChildSearchField => Driver.FindElement(By.CssSelector(".sc-fvbgbd.jyHUvD:first-child"));

        // Info box
        public IWebElement CollapseInfoBox => Driver.FindElement(By.XPath("//div[@class='info-section__container']//span[contains(text(), 'Collapse')]"));

        // Search settings
        public IWebElement SelectSearchSettings => Driver.FindElement(By.XPath("//div[@class='sc-bPxJiH cLQTSu']//p[contains(text(), 'Search settings')]"));
        public IWebElement MoveToOptional => Driver.FindElement(By.CssSelector(".sc-bctVA.jFdcWR:nth-child(2)"));
        public IWebElement SaveSearchSettings => Driver.FindElement(By.XPath("//button[@class='sc-cmnYtw ccKGSj']"));

        // Asserts - Person type - Search result
        public IWebElement AssertForEmployeeSearchResultFirstProfile => Driver.FindElement(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Employee')]"));
        public IWebElement AssertForPartnerSearchResultFirstProfile => Driver.FindElement(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Partner')]"));
        public IWebElement AssertForSubconsultantSearchResultFirstProfile => Driver.FindElement(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Subconsultant')]"));
        public IWebElement AssertForEmeritusSearchResultFirstProfile => Driver.FindElement(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Emeritus')]"));
        public IWebElement AssertForFutureSearchResultFirstProfile => Driver.FindElement(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Future')]"));

        // Asserts - Comments and Q-level - Search result
        public IWebElement AssertForCommentIconInSearchResult => Driver.FindElement(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']//img[contains(@alt, 'Comment tag')]"));
        public IWebElement AssertForCriticalInSearchResult => Driver.FindElement(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']//img[@alt='Comment tag 1']"));
        public IWebElement AssertForImportantInSearchResult => Driver.FindElement(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']//img[@alt='Comment tag 2']"));
        public IWebElement AssertForPositiveInSearchResult => Driver.FindElement(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']//img[@alt='Comment tag 3']"));
        public IWebElement AssertForQlevelIconInSearchResult => Driver.FindElement(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']//div[@class='sc-bfCHJM bhgjpP']//img[@src][@alt]"));
        public IWebElement AssertForFirstStarInSearchResult => Driver.FindElement(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 1']"));
        public IWebElement AssertForSecondStarInSearchResult => Driver.FindElement(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 2']"));
        public IWebElement AssertForThirdStarInSearchResult => Driver.FindElement(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 1']"));

        // Asserts - Comments and Q-level - Profile
        public IWebElement AssertForCommentIconInProfile => Driver.FindElement(By.XPath("//span[@class='box-collapse__badge']//img[@src][@alt='Comment icon']"));
        public IWebElement AssertForCriticalInProfile => Driver.FindElement(By.XPath("//span[@class='box-collapse__badge']//img[@src='/assets/comment-critical-b71bf513.svg'][@alt='Comment icon']"));
        public IWebElement AssertForImportantInProfile => Driver.FindElement(By.XPath("//span[@class='box-collapse__badge']//img[@src='/assets/comment-info-feb7f5c2.svg'][@alt='Comment icon']"));
        public IWebElement AssertForPositiveInProfile => Driver.FindElement(By.XPath("//span[@class='box-collapse__badge']//img[@src='/assets/comment-positive-9cfe6c4f.svg'][@alt='Comment icon']"));
        public IWebElement AssertForQlevelIconInProfile => Driver.FindElement(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[contains(@src, 'filled')]"));
        public IWebElement AssertForFirstStarInProfile => Driver.FindElement(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 1']"));
        public IWebElement AssertForSecondStarInProfile => Driver.FindElement(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 2']"));
        public IWebElement AssertForThirdStarInProfile => Driver.FindElement(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 3']"));

        // Asserts - Comments (Drop down) - Profile
        public IWebElement AsserForCommentIconDropdownInProfile => Driver.FindElement(By.XPath("//div[@class='sc-goETIM czsnvm']//img[@alt='Comment icon']"));
        public IWebElement AssertForCriticalCommentsInProfile => Driver.FindElement(By.XPath("//div[@class='sc-goETIM czsnvm']//img[@src='/assets/comment-critical-b71bf513.svg'][@alt='Comment icon']"));
        public IWebElement AssertForImportantCommentsInProfile => Driver.FindElement(By.XPath("//div[@class='sc-goETIM czsnvm']//img[@src='/assets/comment-info-feb7f5c2.svg'][@alt='Comment icon']"));
        public IWebElement AssertForPositiveCommentsInProfile => Driver.FindElement(By.XPath("//div[@class='sc-goETIM czsnvm']//img[@src='/assets/comment-positive-9cfe6c4f.svg'][@alt='Comment icon']"));


        // Asserts - Presentation - Profile
        public IWebElement AssertForJavaInPresentation => Driver.FindElement(By.XPath("//div[@class='sc-iNyZoU HHVMU']//span[@class='sc-knEsKG eOTgzk']//em[contains(text(), 'Java')]"));

        // Asserts - Assignments - Profile
        public IWebElement AssertForMatchAssignments => Driver.FindElement(By.XPath("//div[@class='sc-bZZWma gYraBc']//span[@class='sc-cxdZMj jOXNLg'][contains(text(), 'Match!')]"));
        public IWebElement AssertForJavaInAssignment => Driver.FindElement(By.XPath("//span[@class='sc-knEsKG eOTgzk']//em[contains(text(), 'Java')]"));

        // Asserts - Employment - Profile
        public IWebElement AssertForMatchEmployment => Driver.FindElement(By.XPath("//span[@class='sc-cxdZMj jOXNLg'][contains(text(), 'Match!')]"));
        public IWebElement AssertForJavaInEmployment => Driver.FindElement(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']//em[contains(text(), 'Java')]"));

        // Asserts - Courses - Profile
        public IWebElement AssertForMatchCourses => Driver.FindElement(By.XPath("//span[@class='box-collapse__badge']//span[@class='sc-cxdZMj jOXNLg'][contains(text(), 'Match!')]"));
        public IWebElement AssertForJavaInCourses => Driver.FindElement(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']//em[contains(text(), 'Java')]"));

        // Asserts - Education - Profile
        public IWebElement AssertForMatchEducation => Driver.FindElement(By.XPath("//span[@class='box-collapse__badge']//span[@class='sc-cxdZMj jOXNLg'][contains(text(), 'Match!')]"));
        public IWebElement AssertForJavaInEducation => Driver.FindElement(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']//em[contains(text(), 'Java')]"));

        // Asserts - Competence- Profile
        public IWebElement AssertForMatchCompetence => Driver.FindElement(By.XPath("//span[@class='box-collapse__badge']//span[@class='sc-cxdZMj jOXNLg'][contains(text(), 'Match!')]"));
        public IWebElement AssertForJavaInCompetence => Driver.FindElement(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']//em[contains(text(), 'Java')]"));
        public IWebElement AssertForCsInCompetence => Driver.FindElement(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']//em[contains(text(), '#')]"));

        // Asserts - Organization - Profile
        public IWebElement AssertForInfrastructure => Driver.FindElement(By.XPath("//div[@class='sc-fENAjM hdGPcW']//a[contains(text(),'INFRASTRUCTURE')]"));
        public IWebElement AssertForBABuildingsSweden => Driver.FindElement(By.XPath("//div[@class='sc-fENAjM hdGPcW']//a[contains(text(),'BA Buildings Sweden')]"));
        public IWebElement AssertForBUBuildingsSwedenEast => Driver.FindElement(By.XPath("//div[@class='sc-fENAjM hdGPcW']//a[contains(text(),'BU Buildings Sweden East')]"));
        public IWebElement AssertForElectricalEngineeringTeknoplanStockholm => Driver.FindElement(By.XPath("//div[@class='sc-fENAjM hdGPcW']//a[contains(text(),'Electrical Engineering Teknoplan Stockholm')]"));

        // Asserts - Industry Experience - Profile
        public IWebElement AssertForDefence => Driver.FindElement(By.XPath("//div[@class='box-collapse']//div[@class='sc-hshgAP bxAwbY'][contains (text(),'Defence')]"));
        public IWebElement AssertForDefenceIndustry => Driver.FindElement(By.XPath("//div[@class='box-collapse']//div[@class='sc-bPaAec dSqTmf']//div[contains (text(),'Defence Industry')]"));

        // Asserts - Person type - Profile
        public IWebElement AssertForEmployee => Driver.FindElement(By.XPath("(//div[contains(text(), 'Employee')])[2]"));
        public IWebElement AssertForPartner => Driver.FindElement(By.XPath("(//div[contains(text(), 'Partner')])[2]"));
        public IWebElement AssertForSubconsultant => Driver.FindElement(By.XPath("(//div[contains(text(), 'Subconsultant')])[2]"));
        public IWebElement AssertForEmeritus => Driver.FindElement(By.XPath("(//div[contains(text(), 'Emeritus')])[2]"));
        public IWebElement AssertForFuture => Driver.FindElement(By.XPath("(//div[contains(text(), 'Future')])[2]"));

        // Asserts - Location - Profile
        public IWebElement AssertForGothenburgGraphicRoad => Driver.FindElement(By.XPath("//span[@class='sc-knEsKG eOTgzk'][contains(text(), 'Göteborg (Grafiska vägen)')]"));
        public IWebElement AssertForStockholm => Driver.FindElement(By.XPath("//span[@class='sc-knEsKG eOTgzk'][contains(text(), 'STOCKHOLM')]"));
        public IWebElement AssertForSweden => Driver.FindElement(By.XPath("//span[@class='sc-knEsKG eOTgzk'][contains(text(), 'Sweden')]"));

        // Methods

        // Clear filters
        public void ClickClearFilters()
        {
            SelectClearFilters.Click();
        }

        // Filters - Focus CV search
        public void ClickFocusCVSearch()
        {
            SelectFocusCVSearch.Click();
        }
        public void ClickPresentationFocusCVSearch()
        {
            SelectPresentationFocusCVSearch.Click();
        }
        public void ClickAssignmentsFocusCVSearch()
        {
            SelectAssignmentsFocusCVSearch.Click();
        }
        public void ClickEmploymentFocusCVSearch()
        {
            SelectEmploymentFocusCVSearch.Click();
        }
        public void ClickCoursesFocusCVSearch()
        {
            SelectCoursesFocusCVSearch.Click();
        }
        public void ClickEducationFocusCVSearch()
        {
            SelectEducationFocusCVSearch.Click();
        }
        public void ClickCompetencesFocusCVSearch()
        {
            SelectCompetenceFocusCVSearch.Click();
        }

        // Filters - Organization
        public void ClickOrganization()
        {
            SelectOrganization.Click();
        }
        public void SendkeysDivision(string division)
        {
            SearchDivison.SendKeys(division);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("react-select-8-listbox")));
            SearchDivison.SendKeys(Keys.Enter);
        }
        public void ClickSearchDivisonDropsDown()
        {
            SelectSearchDivisonDropDown.Click();
        }
        public void SendKeysBusinessArea(string businessArea)
        {
            SearchBusinessArea.SendKeys(businessArea);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("react-select-9-listbox")));
            SearchBusinessArea.SendKeys(Keys.Enter);
        }
        public void ClickBusinessAreaDropdown()
        {
            SelectBusinessAreaDropDown.Click();
        }
        public void SentKeysBusinessUnit(string businessUnit)
        {
            SearchBusinessUnit.SendKeys(businessUnit);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("react-select-10-listbox")));
            SearchBusinessUnit.SendKeys(Keys.Enter);
        }
        public void ClickBusinessUnitDropDown()
        {
            SelectBusinessUnitDropDown.Click();
        }
        public void SendKeysBusinessSection(string businessSection)
        {
            SearchBusinessSection.SendKeys(businessSection);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("react-select-11-listbox")));
            SearchBusinessSection.SendKeys(Keys.Enter);
        }
        public void ClickBusinessSectionDropdown()
        {
            SelectBusinessSectionDropDown.Click();
        }

        // Filters - Industry Experience
        public void ClickIndustryExperience()
        {
            SelectIndustryExperience.Click();
        }
        public void SendkeysSearchIndustrySector(string IndustrySector)
        {
            SelectSearchIndustrySector.SendKeys(IndustrySector);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("react-select-5-input")));
            SelectSearchIndustrySector.SendKeys(Keys.Enter);
        }
        public void ClickIndustrySectorDropdown()
        {
            SelectIndustrySectorDropdown.Click();
        }
        public void SendkeysSearchIndustrySubSector(string IndustrySubSector)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("sf_IndustryAreas")));
            SelectSearchIndustrySubSector.SendKeys(IndustrySubSector);
            SelectSearchIndustrySubSector.SendKeys(Keys.Enter);
        }
        public void ClickIndustrySubSectorDropdown()
        {
            SelectIndustrySubSectorDropdown.Click();
        }
        public void SendkeysMinimumExperience(string MinimumExperience)
        {
            SelectMinimumExperience.SendKeys(MinimumExperience);
            SelectMinimumExperience.SendKeys(Keys.Enter);
        }

        // Filters - Location
        public void ClickLocation()
        {
            SelectLocation.Click();
        }
        public void SendkeysSearchOfficeCity(string SearchOfficeCity)
        {
            SelectSearchOfficeCity.SendKeys(SearchOfficeCity);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("react-select-3-listbox")));
            SelectSearchOfficeCity.SendKeys(Keys.Enter);
        }
        public void SendkeysSearchHomeCity(string SearchHomeCity)
        {
            SelectSearchHomeCity.SendKeys(SearchHomeCity);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("react-select-4-listbox")));
            SelectSearchHomeCity.SendKeys(Keys.Enter);
        }
        public void SendkeysSearchHomeCountry(string SearchHomeCountry)
        {
            SelectSearchHomeCountry.SendKeys(SearchHomeCountry);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("react-select-5-listbox")));
            SelectSearchHomeCountry.SendKeys(Keys.Enter);
        }

        // Filters - Language
        public void ClickLanguage()
        {
            SelectLanguage.Click();
        }
        public void SendKeysSearchForLanguage(string SearchForLanguage)
        {
            SelectSearchForLanguage.SendKeys(SearchForLanguage);
            SelectSearchForLanguage.SendKeys(Keys.Enter);
        }
        public void SendkeysMinimumKnowledgeLevel(string MinimumKnowledgeLevel)
        {
            SelectMinimumKnowledgeLevel.SendKeys(MinimumKnowledgeLevel);
            SelectMinimumKnowledgeLevel.SendKeys(Keys.Enter);
        }

        // Filters - Comments and Q-level
        public void ClickCommentsAndQLevel()
        {
            SelectCommentsAndQLevel.Click();
        }
        public void ClickCritical()
        {
            SelectCritical.Click();
        }
        public void ClickImportant()
        {
            SelectImportant.Click();
        }
        public void ClickPositive()
        {
            SelectPositive.Click();
        }
        public void ClickCompletedCVProfile()
        {
            SelectCompletedCVProfile.Click();
        }
        public void ClickQualifiedByEmployee()
        {
            SelectQualifiedByEmployee.Click();
        }
        public void ClickSuccessfullyCompletedAfryAssignment()
        {
            SelectSuccessfullyCompletedAfryAssignment.Click();
        }

        // Search result
        public void ClickFirstProfile()
        {
            Thread.Sleep(2000);
            SelectFirstProfile.Click();
        }

        // Filters - Person type
        public void ClickEmployee()
        {
            SelectEmployee.Click();
        }
        public void ClickPartner()
        {
            SelectPartner.Click();
        }
        public void ClickSubconsultant()
        {
            SelectSubconsultant.Click();
        }
        public void ClickEmeritus()
        {
            SelectEmeritus.Click();
        }
        public void ClickFuture()
        {
            SelectFuture.Click();
        }

        // Profile
        public void ClickCloseProfile()
        {
            SelectCloseProfile.Click();
        }
        public void ClickOrganizationInProfile()
        {
            SelectOrganizationInProfile.Click();
        }
        public void ClickCompetenceInProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Competence')]")));
            SelectCompetenceInProfile.Click();
        }
        public void ClickIndustryExperienceProfile()
        {
            SelectIndustryExperienceProfile.Click();
        }
        public void ClickShowMatchesAssignmentsProfile()
        {
            SelectShowMatchesAssignmentsProfile.Click();
        }
        public void ClickFirstAssignmentProfile()
        {
            SelectFirstAssignmentProfile.Click();
        }
        public void ClickEmploymentProfile()
        {
            SelectEmploymentProfile.Click();
        }
        public void ClickCoursesProfile()
        {
            SelectCoursesProfile.Click();
        }
        public void ClickEducationProfile()
        {
            SelectEducationProfile.Click();
        }
        public void ClickCompetenceProfile()
        {
            SelectCompetenceProfile.Click();
        }
        public void ClickCommentsProfile()
        {
            SelectCommentsProfile.Click();
        }

        // Search field
        public void RemoveSearchFromSearchfield()
        {
            RemoveTextFromSearchField.Click();
        }

        public void SendKeysSearchfield(string Searchfield)
        {
            SelectSearchfield.SendKeys(Searchfield);
            SelectSearchfield.SendKeys(Keys.Enter);
        }
        public void AddSearchAsTag()
        {
            SelectFirstChildSearchField.Click();
        }

        // Info box
        public void ClickCollapseInfoBox()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='info-section__container']//span[contains(text(), 'Collapse')]")));
            CollapseInfoBox.Click();
        }

        // Search settings
        public void ClickSearchSettings()
        {
            SelectSearchSettings.Click();
        }
        public void ClickMoveToOptional()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".sc-bctVA.jFdcWR:nth-child(2)")));
            MoveToOptional.Click();
        }
        public void ClickSaveSearchSettings()
        {
            SaveSearchSettings.Click();
        }

        // Asserts

        // Person type - Search result
        public void AssertForEmployeeSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Employee')]")));
            if (AssertForEmployeeSearchResultFirstProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Employee' in the search result");
        }
        public void AssertForPartnerSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Partner')]")));
            if (AssertForPartnerSearchResultFirstProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Partner' in the search result");
        }
        public void AssertForSubconsultantSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Subconsultant')]")));
            if (AssertForSubconsultantSearchResultFirstProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Subconsultant' in the search result");
        }
        public void AssertForEmeritusSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Emeritus')]")));
            if (AssertForEmeritusSearchResultFirstProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Emeritus' in the search result");
        }
        public void AssertForFutureSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV'])[1]//p[contains(text(), 'Future')]")));
            if (AssertForFutureSearchResultFirstProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Future' in the search result");
        }

        // OrganizationSearchEmployee()
        public void AssertForInfrastructureProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-fENAjM hdGPcW']")));
            if (AssertForInfrastructure.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'INFRASTRUCTURE' in the profiles Organization");
        }
        public void AssertForBABuildingsSwedenProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-fENAjM hdGPcW']")));
            if (AssertForBABuildingsSweden.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'BA Buildings Sweden' in the profiles Organization");
        }
        public void AssertForBUBuildingsSwedenEastProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-fENAjM hdGPcW']")));
            if (AssertForBUBuildingsSwedenEast.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'INFRASTRUCTURE' in the profiles Organization");
        }
        public void AssertForElectricalEngineeringTeknoplanStockholmProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-fENAjM hdGPcW']")));
            if (AssertForElectricalEngineeringTeknoplanStockholm.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Electrical Engineering Teknoplan Stockholm' in the profiles Organization");
        }

        // TagsSearchEmployee()
        public void AssertForJavaInProfileCompetence()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForJavaInCompetence.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find Java in the profiles Competence, but it's only optional");
        }
        public void AssertForCsInProfileCompetence()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForCsInCompetence.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'C#' in the profiles Competence");
        }

        // IndustryExperienceEmployee()
        public void AssertForDefenceProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//b[contains (text(),'Industry Experience')]")));
            if (AssertForDefence.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Defence' in the profiles Industry Experience");
        }
        public void AssertForDefenceIndustryProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//b[contains (text(),'Industry Experience')]")));
            if (AssertForDefenceIndustry.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Defence Industry' in the profiles Industry Experience");
        }

        // LocationSearchEmployee/Subconsultant()
        public void AssertForEmployeeProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-jdIQKl jwjLqT']")));
            if (AssertForEmployee.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Employee' in the profile");
        }
        public void AssertForSubconsultantProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-jdIQKl jwjLqT']")));
            if (AssertForSubconsultant.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Subconsultant' in the profile");
        }
        public void AssertForGothenburgGraphicRoadProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-jdIQKl jwjLqT']")));
            if (AssertForGothenburgGraphicRoad.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Location information' in the profile");
        }

        // LocationSearchPartner/Emeritus/Future()
        public void AssertForPartnerProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-jdIQKl jwjLqT']")));
            if (AssertForPartner.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Partner' in the profile");
        }
        public void AssertForEmeritusProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-jdIQKl jwjLqT']")));
            if (AssertForEmeritus.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Emeritus' in the profile");
        }
        public void AssertForFutureProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-jdIQKl jwjLqT']")));
            if (AssertForFuture.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Future' in the profiles person type");
        }
        public void AssertForStockholmProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-jdIQKl jwjLqT']")));
            if (AssertForStockholm.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Stockholm' in the profile");
        }
        public void AssertForSwedenProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-jdIQKl jwjLqT']")));
            if (AssertForSweden.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Sweden' in the profile");
        }

        // FocusCVSearchPresentationSearchAllPersonTypes()
        public void AssertForJavaInPresentationProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-iNyZoU HHVMU']")));
            if (AssertForJavaInPresentation.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Java' in the profiles presentation");
        }

        // FocusCVSearchAssignmentsSearchAllPersonTypes()
        public void AssertForMatchAssignmentsProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bZZWma gYraBc'][contains(text(), 'Assignments')]")));
            if (AssertForMatchAssignments.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Match!' next to Assignments in the profile");
        }
        public void AssertForJavaInAssignmentsProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dkBdza jnmorU box-collapse__body']//div[@class='sc-gnaFgX dFLOFI']")));
            if (AssertForJavaInAssignment.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Java' in the profiles Assignment");
        }

        // FocusCVSearchEmploymentSearchAllPersonTypes()
        public void AssertForJavaInEmploymentProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForJavaInEmployment.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Java' in the profiles Employment");
        }
        public void AssertForMatchEmploymentProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Employment')]")));
            if (AssertForMatchEmployment.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Match!' next to Employment in the profile");
        }

        // FocusCVSearchCoursesSearchAllPersonTypes()
        public void AssertForMatchCoursesProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Courses')]")));
            if (AssertForMatchCourses.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Match!' next to Courses in the profile");
        }
        public void AssertForJavaInCoursesProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForJavaInCourses.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Java' in the profiles Courses");
        }

        // FocusCVSearchEducationSearchAllPersonTypes()
        public void AssertForJavaInEducationProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForJavaInEducation.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Java' in the profiles Employment");
        }
        public void AssertForMatchEducationProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Education')]")));
            if (AssertForMatchEducation.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Match!' next to Education in the profile");
        }
        // FocusCVSearchCompetencesSearchAllPersonTypes()
        public void AssertForJavaInCompetenceProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-hhhKsR bpZnWa']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForJavaInCompetence.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Java' in the profiles Competence");
        }
        public void AssertForMatchCompetenceProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Competence')]")));
            if (AssertForMatchCompetence.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find 'Match!' next to Competence in the profile");
        }

        // CommentsAndQlevelSearchPartner()
        public void AssertForCriticalSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']//img[@alt='Comment tag 1']")));
            if (AssertForCriticalInSearchResult.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Critical'-icon in the search result");
        }
        public void AssertForImportantSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']//img[@alt='Comment tag 2']")));
            if (AssertForImportantInSearchResult.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Important'-icon in the search result");
        }
        public void AssertForPositiveSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']//img[@alt='Comment tag 3']")));
            if (AssertForPositiveInSearchResult.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Positive'-icon in the search result");
        }
        public void AssertForCriticalProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Comments')]")));
            if (AssertForCriticalInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Critical'-icon next to Comments in the profile");
        }
        public void AssertForImportantProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Comments')]")));
            if (AssertForImportantInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Important'-icon next to Comments in the profile");
        }
        public void AssertForPositiveProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Comments')]")));
            if (AssertForPositiveInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Positive'-icon next to Comments in the profile");
        }
        public void AssertForCriticalCommentsProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForCriticalCommentsInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Critical'-icon in the profiles comments dropdown");
        }
        public void AssertForImportantCommentsProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForImportantCommentsInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Important'-icon in the profiles comments dropdown");
        }
        public void AssertForPositiveCommentsProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));
            if (AssertForPositiveCommentsInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Positive'-icon in the profiles comments dropdown");
        }

        // CommentsAndQlevelSearchEmeritus()
        public void AssertForQLevelSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bfCHJM bhgjpP']")));
            if (AssertForQlevelIconInSearchResult.Displayed == true)
                Console.WriteLine("Assert for 'Completed CV profile/Qualified by employee/Successfully completed AFRY assignment' found in search result");
            else
                Console.WriteLine("Couldn't find any 'Q-level'-icon in the search result");
        }
        public void AssertForCommentsSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-lbWGbb sc-ga-DzBV cXJDOb lgJOKV']")));
            if (AssertForCommentIconInSearchResult.Displayed == true)
                Console.WriteLine("Assert for 'Critical/Important/Positive' found in search result");
            else
                Console.WriteLine("Couldn't find any 'Comments'-icon in the search result");
        }
        public void AssertForQLevelProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bfCHJM bhgjpP']")));
            if (AssertForQlevelIconInProfile.Displayed == true)
                Console.WriteLine("Assert for 'Completed CV profile/Qualified by employee/Successfully completed AFRY assignment' found in the profile");
            else
                Console.WriteLine("Couldn't find any 'Q-level'-icon in the profile");
        }
        public void AssertForCommentsProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-dubCtV bWnAzg box-collapse__header']//b[contains(text(), 'Comments')]")));           
            if (AssertForCommentIconInProfile.Displayed == true)
                Console.WriteLine("Assert for 'Critical/Important/Positive' found next to Comments in the profile");        
            else 
                Console.WriteLine("Couldn't find any 'Comments'-icon next to Comments in the profile");            
        }
        public void AssertForCommentsDropdownProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='box-collapse']//div[@class='sc-dkBdza jnmorU box-collapse__body']")));         
            if (AsserForCommentIconDropdownInProfile.Displayed == true)
                Console.WriteLine("Assert for 'Critical/Important/Positive' found in the profiles comments-dropdown");
            else
                Console.WriteLine("Couldn't find any 'Comments'-icon in the profile comments dropdown");      
        }

        // CommentsAndQlevelSearchFuture()
        public void AssertForFirstStarSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 1']")));
            if (AssertForFirstStarInSearchResult.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Completed CV profile'-icon in the search result");
        }
        public void AssertForSecondStarSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 2']")));
            if (AssertForSecondStarInSearchResult.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Qualified by employee'-icon in the search result");
        }
        public void AssertForThirdStarSearchResult()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bfCHJM bhgjpP']//img[@src='/assets/quality-star-filled-2f9fe148.svg'][@alt='Q-level 3']")));
            if (AssertForThirdStarInSearchResult.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Successfully completed AFRY assignment'-icon in the search result");
        }
        public void AssertForFirstStarProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bfCHJM bhgjpP']")));
            if (AssertForFirstStarInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Completed CV profile'-icon in the profile");
        }
        public void AssertForSecondStarProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bfCHJM bhgjpP']")));
            if (AssertForSecondStarInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Qualified by employee'-icon in the profile");
        }
        public void AssertForThirdStarProfile()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='sc-bfCHJM bhgjpP']")));
            if (AssertForThirdStarInProfile.Displayed == true)
                Console.WriteLine("Assert complete");
            else
                Console.WriteLine("Couldn't find the 'Successfully completed AFRY assignment'-icon in the profile");
        }
    }
}
