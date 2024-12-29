using System.Runtime.InteropServices;

namespace application;

public class DetectOsPlatform
{
    public DetectOsPlatform() {}

    public bool IsWindows() =>
        RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

    public bool IsMacOS() =>
        RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

    public bool IsLinux() =>
        RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
}