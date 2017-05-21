Imports System.Globalization
Imports System.IO
Imports TechTalk.SpecFlow

<Binding>
Module WebServer
    Const RelativePath As string = "IIS Express\iisexpress.exe"
    Const Port As String = "57520"

    Private _iisExpressProcess As Process

    <BeforeTestRun>
    Public Sub BeforeTestRun()
        StartIISExpress()
    End Sub

    <AfterTestRun>
    Public Sub AfterTestRun()
        StopIISExpress()
    End Sub

    Private Sub StartIISExpress()
        Dim arguments = string.Format(CultureInfo.InvariantCulture, "/path:""{0}"" /port:{1}", GetSitePath(), Port)

        Dim startInfo = new ProcessStartInfo(GetExpressPath()) With {
                .WindowStyle = ProcessWindowStyle.Normal,
                .ErrorDialog = true,
                .LoadUserProfile = true,
                .CreateNoWindow = true,
                .UseShellExecute = false,
                .Arguments = arguments
                }

        _iisExpressProcess = Process.Start(startInfo)
    End Sub

    Private Sub StopIISExpress()

        if (_iisExpressProcess.HasExited = false)

            _iisExpressProcess.Kill()
            _iisExpressProcess.Dispose()
            _iisExpressProcess = Nothing

        End If
    End Sub

    Private Function GetExpressPath() As String

        Dim key as String = IIf(Environment.Is64BitOperatingSystem, "ProgramFiles(x86)", "ProgramFiles")
        Dim programFiles As String = Environment.GetEnvironmentVariable(key)

        return Path.Combine(programFiles, RelativePath)

    End Function

    Private Function GetSitePath() As String

        Dim dir = new DirectoryInfo(Environment.CurrentDirectory)

        While(Not dir.GetFiles().Any(Function(x) IsSolutionDirectory(x)))
            dir = dir.Parent
        End While

        Return Path.Combine(dir.FullName, "Frontend")

    End Function


    Private Function IsSolutionDirectory(file As FileInfo) As Boolean

        return file.Extension.Equals(".sln", StringComparison.InvariantCultureIgnoreCase)

    End Function
End Module
