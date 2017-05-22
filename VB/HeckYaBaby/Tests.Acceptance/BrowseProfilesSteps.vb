Imports System.Text.RegularExpressions
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Remote
Imports OpenQA.Selenium.Support.UI
Imports TechTalk.SpecFlow
Imports Xunit

<Binding>
Public Class BrowseProfilesSteps
    Private _driver As ChromeDriver
    Private _grid As IWebElement

    <BeforeScenario>
    Public Sub Setup()

        Dim capabilities As DesiredCapabilities = DesiredCapabilities.Chrome()
        Dim options As ChromeOptions = new ChromeOptions()

        options.AddArguments("test-type")
        options.AddArguments("-disable-web-security")
        options.AddArguments("-allow-running-insecure-content")

        capabilities.SetCapability(ChromeOptions.Capability, options)

        _driver = new ChromeDriver(options)
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

        Dim wait = New WebDriverWait(_driver, New TimeSpan(100000000))
        Dim mask = wait.Until(ExpectedConditions.ElementExists(By.ClassName("k-loading-mask")))
        
        wait.Until(ExpectedConditions.StalenessOf(mask))

        _grid = _driver.FindElement(By.Id("profileGrid"))

    End Sub

    <[Then]("I will be present (.*) pages of Profiles")>
    Public Sub ThenIWillBePresentPagesOfProfiles(pageCount As Int32)
        Dim pagerInfo = _driver.FindElement(By.ClassName("k-pager-info")).Text
        Dim pattern As New Regex(".*?" + pageCount.ToString() + "\s+\w+")

        Assert.True(pattern.IsMatch(pagerInfo))
    End Sub

    <[Then]("each page will have (.*) profiles")>
    Public Sub ThenEachPageWillHaveProfiles(profileCount As Int32)
        Dim rows = _grid.FindElement(By.TagName("tbody")).FindElements(By.TagName("tr"))

        Assert.Equal(profileCount, rows.Count)
        
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

    <[Then]("I can edit Profiles")>
    Public Sub ThenICanEditProfiles()
        Dim isEditable = _grid.
            FindElement(By.TagName("tbody")).
            FindElements(By.ClassName("k-grid-edit")).
            All(function(element) element.Text.Equals("Edit"))

        Assert.True(isEditable)
    End Sub

    <[Then]("I can delete Profiles")>
    Public Sub ThenICanDeleteProfiles()
        Dim isEditable = _grid.
            FindElement(By.TagName("tbody")).
            FindElements(By.ClassName("k-grid-delete")).
            All(function(element) element.Text.Equals("Delete"))

        Assert.True(isEditable)
    End Sub

End Class