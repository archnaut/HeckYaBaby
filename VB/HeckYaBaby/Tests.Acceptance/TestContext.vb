Imports System.Globalization
Imports System.IO
Imports TechTalk.SpecFlow

<Binding>
Module TestContext
    Const RelativePath As string = "IIS Express\iisexpress.exe"
    Const Port As String = "57520"

    Private _expressProcess As Process
    Private _serviceProcess As Process

    <BeforeTestRun>
    Public Sub BeforeTestRun()
        StartService()
        StartIISExpress()
    End Sub

    <AfterTestRun>
    Public Sub AfterTestRun()

        StopProcess(_expressProcess)
        StopProcess(_serviceProcess)

    End Sub

    Private Sub StartService()

        Dim servicePath = Path.Combine(GetSolutionPath(), "Backend\bin\debug\backend.exe")

        _serviceProcess = StartProcess(servicePath) 

    End Sub

    Private Sub StartIISExpress()

        Dim sitePath = Path.Combine(GetSolutionPath(), "Frontend")
        Dim arguments = string.Format(CultureInfo.InvariantCulture, "/path:""{0}"" /port:{1}", sitePath, Port)

        _expressProcess = StartProcess(GetExpressPath(), arguments)

    End Sub

    Private Function StartProcess(path As String, Optional args As String = "") As Process

        Dim startInfo = new ProcessStartInfo(path) With {
                .WindowStyle = ProcessWindowStyle.Normal,
                .ErrorDialog = True,
                .LoadUserProfile = True,
                .CreateNoWindow = False,
                .UseShellExecute = True,
                .Arguments = args
            }

        Return Process.Start(startInfo)

    End Function

    Private Sub StopProcess(process As Process)

        if (process.HasExited = false)

            process.Kill()
            process.Dispose()

        End If

    End Sub

    Private Function GetExpressPath() As String

        Dim key as String = IIf(Environment.Is64BitOperatingSystem, "ProgramFiles(x86)", "ProgramFiles")
        Dim programFiles As String = Environment.GetEnvironmentVariable(key)

        return Path.Combine(programFiles, RelativePath)

    End Function

    Private Function GetSolutionPath() As String

        Dim dir = new DirectoryInfo(Environment.CurrentDirectory)

        While(Not dir.GetFiles().Any(Function(x) IsSolutionDirectory(x)))
            dir = dir.Parent
        End While

        Return dir.FullName

    End Function

    Private Function IsSolutionDirectory(file As FileInfo) As Boolean

        return file.Extension.Equals(".sln", StringComparison.InvariantCultureIgnoreCase)

    End Function
End Module
