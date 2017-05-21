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

    <[Then]("I will be present (.*) pages of Profiles")>
    Public Sub ThenIWillBePresentPagesOfProfiles(pageCount As Int32)

        Dim grid = _driver.FindElement(By.Id("profileGrid"))
        Assert.NotNull(grid)
    End Sub

    <[Then]("each page will have (.*) profiles")>
    Public Sub ThenEachPageWillHaveProfiles(p0 As Int32)
    End Sub

    <[Then]("each Profile will have")>
    Public Sub ThenEachProfileWillHave(table As Table)
        Dim headers = _driver.
            FindElements(By.TagName("th")).
            Select(function(element) element.GetAttribute("data-Title")).
            Where(function(s) Not String.IsNullOrEmpty(s))

        Dim properties = table.Rows.Select(function(row) row.Values(0))


        Assert.True(headers.All(function(header) properties.Any(function(prop) header = prop)))
    End Sub

    <[Then]("I can add Profiles")>
    Public Sub ThenICanAddProfiles()
        Dim toolbar = _driver.FindElement(By.ClassName("k-grid-toolbar"))
        Dim button = toolbar.FindElement(By.TagName("a"))
        
        Assert.Equal("Add new record", button.Text)
    End Sub
End Class