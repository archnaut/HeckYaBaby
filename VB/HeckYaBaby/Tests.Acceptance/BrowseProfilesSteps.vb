Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports TechTalk.SpecFlow
Imports Xunit

<Binding>
Public Class BrowseProfilesSteps
    Private _driver As IWebDriver

    <BeforeScenario>
    Public Sub Setup()
        _driver = new ChromeDriver()
    End Sub

    <AfterScenario>
    Public Sub TearDown
        _driver.Quit()
    End Sub

    <Given("an existing 100 Profiles")>
    Public Sub GivenAnExistingProfiles()
    End Sub

    <[When]("I open the Profile console")>
    Public Sub WhenIOpenTheProfileConsole()
        _driver.Navigate().GoToUrl("http://localhost:57520")
    End Sub

    <[Then]("each page will have (.*) profiles")>
    Public Sub ThenIWillBePresentPagesOfProfiles(pageCount As Int32)

        Dim grid = _driver.FindElement(By.Id("profileGrid"))
        Assert.NotNull(grid)

    End Sub

    <[Then]("I will be present (.*) pages of Profiles")>
    Public Sub ThenEachPageWillHaveProfiles(profileCount As Int32)
    End Sub
End Class