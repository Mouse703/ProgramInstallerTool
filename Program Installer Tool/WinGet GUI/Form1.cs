using System.Diagnostics;
using System;
using System.IO;
using System.Windows.Forms;


namespace WinGet_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInstallEssential_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> programsToInstall = new List<string>();

                // Check if each checkbox is checked and add the corresponding program to the list
                if (checkBoxCorsairiCue.Checked)                { programsToInstall.Add("Corsair.iCUE.5"); }
                if (checkBoxDiscord.Checked)                    { programsToInstall.Add("Discord.Discord"); }
                if (checkBoxDriverBooster.Checked)              { programsToInstall.Add("IOBit.DriverBooster"); }
                if (checkBoxChrome.Checked)                     { programsToInstall.Add("Google.Chrome"); }
                if (checkBoxSpotify.Checked)                    { programsToInstall.Add("Spotify.Spotify"); }
                if (checkBoxTranslucentTB.Checked)              { programsToInstall.Add("9PF4KZ2VN4W9"); }

                if (programsToInstall.Count == 0)
                {
                    MessageBox.Show("Error: Please select at least one program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm with the user before proceeding
                DialogResult result = MessageBox.Show($"You are about to install {programsToInstall.Count} program(s):\n\n{string.Join("\n", programsToInstall)}\n\nDo you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Get the path to the temporary folder
                    string tempFolderPath = Path.GetTempPath();

                    // Combine the temporary folder path with the file name
                    string filePath = Path.Combine(tempFolderPath, "ProgramsToInstall.txt");

                    Console.WriteLine("Temporary File Path: " + filePath);
                    File.WriteAllLines(filePath, programsToInstall);
                    RunPowerShellScript();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEssentialAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install all programs under essentials, do you want to continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Check if the user clicked the "Yes" button
            if (result == DialogResult.Yes)
            {
                try
                {
                    // List of programs to install
                    List<string> programsToInstall = new List<string>
                    {
                        "Google.Chrome",
                        "Discord.Discord",
                        "IOBit.DriverBooster",
                        "Corsair.iCUE.5",
                        "Spotify.Spotify",
                        "9PF4KZ2VN4W9",
                    };

                    string tempFolderPath = Path.GetTempPath();
                    string filePath = Path.Combine(tempFolderPath, "ProgramsToInstall.txt");
                    Console.WriteLine("Temporary File Path: " + filePath);
                    File.WriteAllLines(filePath, programsToInstall);
                    RunPowerShellScript();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonInstallOther_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> programsToInstall = new List<string>();

                // Check if each checkbox is checked and add the corresponding program to the list
                if (checkBoxAida64.Checked) { programsToInstall.Add("FinalWire.AIDA64.Extreme"); }
                if (checkBoxArmouryCrate.Checked) { programsToInstall.Add("Asus.ArmouryCrate"); }
                if (checkBoxAudacity.Checked) { programsToInstall.Add("Audacity.Audacity"); }
                if (checkBoxBelgiumEID.Checked) { programsToInstall.Add("BelgianGovernment.Belgium-eIDmiddleware"); }
                if (checkBoxCineBench.Checked) { programsToInstall.Add("Maxon.CinebenchR23"); }
                if (checkBoxCPUZ.Checked) { programsToInstall.Add("CPUID.CPU-Z.ROG"); }
                if (checkBoxCrystalDiskInfo.Checked) { programsToInstall.Add("CrystalDewWorld.CrystalDiskInfo"); }
                if (checkBoxCrystalDiskMark.Checked) { programsToInstall.Add("CrystalDewWorld.CrystalDiskMark"); }
                if (checkBoxEasyEDA.Checked) { programsToInstall.Add("JLC.EasyEDA"); }
                if (checkBoxFFmpeg.Checked) { programsToInstall.Add("Gyan.FFmpeg"); }
                if (checkBoxNvidiaGeForceExperience.Checked) { programsToInstall.Add("Nvidia.GeForceExperience"); }
                if (checkBoxGit.Checked) { programsToInstall.Add("Git.Git"); }
                if (checkBoxGPUZ.Checked) { programsToInstall.Add("TechPowerUp.GPU-Z"); }
                if (checkBoxHWMonitor.Checked) { programsToInstall.Add("CPUID.HWMonitor"); }
                if (checkBoxInkscape.Checked) { programsToInstall.Add("Inkscape.Inkscape"); }
                if (checkBoxJava8.Checked) { programsToInstall.Add("Oracle.JavaRuntimeEnvironment"); }
                if (checkBoxJavaSDK.Checked) { programsToInstall.Add("Oracle.JDK.20"); }
                if (checkBoxMessenger.Checked) { programsToInstall.Add("Facebook.Messenger"); }
                if (checkBoxMicrosoftOffice.Checked) { programsToInstall.Add("Microsoft.Office"); }
                if (checkBoxMicrosoftPowerToys.Checked) { programsToInstall.Add("Microsoft.PowerToys"); }
                if (checkBoxMicrosoftToDo.Checked) { programsToInstall.Add("9WZDNCRFJB3H"); }
                if (checkBoxMicrosoftVisualStudioCode.Checked) { programsToInstall.Add("Microsoft.VisualStudioCode"); }
                if (checkBoxMicrosoftVisualStudioEnterprise.Checked) { programsToInstall.Add("Microsoft.VisualStudio.2022.Enterprise"); }
                if (checkBoxMinecraft.Checked) { programsToInstall.Add("Mojang.MinecraftLauncher"); }
                if (checkBoxMSIAfterburner.Checked) { programsToInstall.Add("Guru3D.Afterburner"); }
                if (checkBoxMyAsus.Checked) { programsToInstall.Add("9N7R5S6B0ZZH"); }
                if (checkBoxNodeJS.Checked) { programsToInstall.Add("OpenJS.NodeJS"); }
                if (checkBoxNotepadPP.Checked) { programsToInstall.Add("Notepad++.Notepad++"); }
                if (checkBoxNmap.Checked) { programsToInstall.Add("Insecure.Nmap"); }
                if (checkBoxNvidiaBroadcast.Checked) { programsToInstall.Add("Nvidia.Broadcast"); }
                if (checkBoxOBSStudio.Checked) { programsToInstall.Add("OBSProject.OBSStudio"); }
                if (checkBoxPlex.Checked) { programsToInstall.Add("Plex.Plex"); }
                if (checkBoxqBitTorrent.Checked) { programsToInstall.Add("qBittorrent.qBittorrent"); }
                if (checkBoxPrusaSlicer.Checked) { programsToInstall.Add("Prusa3D.PrusaSlicer"); }
                if (checkBoxQuickShare.Checked) { programsToInstall.Add("9PCTGDFXVZLJ"); }
                if (checkBoxRainmeter.Checked) { programsToInstall.Add("Rainmeter.Rainmeter"); }
                if (checkBoxRaspberryPiImager.Checked) { programsToInstall.Add("RaspberryPiFoundation.RaspberryPiImager"); }
                if (checkBoxSamsungAccount.Checked) { programsToInstall.Add("9P98T77876KZ"); }
                if (checkBoxUnigineHeaven.Checked) { programsToInstall.Add("Unigine.HeavenBenchmark"); }
                if (checkBoxUnigineSuperPosition.Checked) { programsToInstall.Add("Unigine.SuperpositionBenchmark"); }
                if (checkBoxUnigineValley.Checked) { programsToInstall.Add("Unigine.ValleyBenchmark"); }
                if (checkBoxSteam.Checked) { programsToInstall.Add("Valve.Steam"); }
                if (checkBoxSurfshark.Checked) { programsToInstall.Add("Surfshark.Surfshark"); }
                if (checkBoxVLC.Checked) { programsToInstall.Add("VideoLAN.VLC"); }
                if (checkBoxWinRAR.Checked) { programsToInstall.Add("RARLab.WinRAR"); }
                if (checkBoxYtDLP.Checked) { programsToInstall.Add("yt-dlp.yt-dlp"); }

                if (programsToInstall.Count == 0)
                {
                    MessageBox.Show("Error: Please select at least one program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm with the user before proceeding
                DialogResult result = MessageBox.Show($"You are about to install {programsToInstall.Count} program(s):\n\n{string.Join("\n", programsToInstall)}\n\nDo you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Get the path to the temporary folder
                    string tempFolderPath = Path.GetTempPath();

                    // Combine the temporary folder path with the file name
                    string filePath = Path.Combine(tempFolderPath, "ProgramsToInstall.txt");

                    Console.WriteLine("Temporary File Path: " + filePath);
                    File.WriteAllLines(filePath, programsToInstall);
                    RunPowerShellScript();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOtherAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install all programs under essentials, do you want to continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Check if the user clicked the "Yes" button
            if (result == DialogResult.Yes)
            {
                try
                {
                    // List of programs to install
                    List<string> programsToInstall = new List<string>
                    {
                        "FinalWire.AIDA64.Extreme",
                        "Asus.ArmouryCrate",
                        "Audacity.Audacity",
                        "BelgianGovernment.Belgium-eIDmiddleware",
                        "Maxon.CinebenchR23",
                        "CPUID.CPU-Z.ROG",
                        "CrystalDewWorld.CrystalDiskInfo",
                        "CrystalDewWorld.CrystalDiskMark",
                        "JLC.EasyEDA",
                        "Gyan.FFmpeg",
                        "Nvidia.GeForceExperience",
                        "Git.Git",
                        "TechPowerUp.GPU-Z",
                        "CPUID.HWMonitor",
                        "Inkscape.Inkscape",
                        "Oracle.JavaRuntimeEnvironment",
                        "Oracle.JDK.20",
                        "Facebook.Messenger",
                        "Microsoft.Office",
                        "Microsoft.PowerToys",
                        "9WZDNCRFJB3H",
                        "Microsoft.VisualStudioCode",
                        "Microsoft.VisualStudio.2022.Enterprise",
                        "Mojang.MinecraftLauncher",
                        "Guru3D.Afterburner",
                        "9N7R5S6B0ZZH",
                        "OpenJS.NodeJS",
                        "Notepad++.Notepad++",
                        "Insecure.Nmap",
                        "Nvidia.Broadcast",
                        "OBSProject.OBSStudio",
                        "Plex.Plex",
                        "qBittorrent.qBittorrent",
                        "Prusa3D.PrusaSlicer",
                        "9PCTGDFXVZLJ",
                        "Rainmeter.Rainmeter",
                        "RaspberryPiFoundation.RaspberryPiImager",
                        "9P98T77876KZ",
                        "Unigine.HeavenBenchmark",
                        "Unigine.SuperpositionBenchmark",
                        "Unigine.ValleyBenchmark",
                        "Valve.Steam",
                        "Surfshark.Surfshark",
                        "VideoLAN.VLC",
                        "RARLab.WinRAR",
                        "yt-dlp.yt-dlp"
                    };

                    string tempFolderPath = Path.GetTempPath();
                    string filePath = Path.Combine(tempFolderPath, "ProgramsToInstall.txt");
                    Console.WriteLine("Temporary File Path: " + filePath);
                    File.WriteAllLines(filePath, programsToInstall);
                    RunPowerShellScript();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RunPowerShellScript()
        {
            // Get the path to the PowerShell script
            string scriptPath = Path.Combine(Path.GetTempPath(), "InstallApps.ps1");

            // Write the script content to a temporary file
            File.WriteAllText(scriptPath, scriptContent);

            // Start PowerShell process to execute the temporary script
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "powershell.exe";
            psi.Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\"";
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = psi;
                process.Start();

                // Capture output and errors
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();
            }
        }

        private void buttonDownloadABBRobotstudio_Click(object sender, EventArgs e)
        {
            string url = "https://portal.academicsoftware.com/software/robotstudio~db9115c2-980a-436e-875d-a0c0e34cf9f7";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadAsusAura_Click(object sender, EventArgs e)
        {
            string url = "https://dlcdnets.asus.com/pub/ASUS/mb/14Utilities/Lighting_Control_1.07.84_v2.zip";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadAutodesk_Click(object sender, EventArgs e)
        {
            string url = "https://manage.autodesk.com/products";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadCODESYS_Click(object sender, EventArgs e)
        {
            string url = "https://store.codesys.com/de/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadDCS_Click(object sender, EventArgs e)
        {
            string url = "https://www.digitalcombatsimulator.com/en/downloads/world/beta/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadEPLAN_Click(object sender, EventArgs e)
        {
            string url = "https://www.eplan-software.com/solutions/eplan-for-educational-institutions/eplan-education-for-students/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadFluidsim_Click(object sender, EventArgs e)
        {
            string url = "https://portal.academicsoftware.com/software/fluidsim-pneumatics~ac6162e1-cafd-4315-8687-2710d2b53d97";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadFurMark_Click(object sender, EventArgs e)
        {
            string url = "https://geeks3d.com/furmark/downloads/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadGPUTweakIII_Click(object sender, EventArgs e)
        {
            string url = "https://www.asus.com/campaign/GPU-Tweak-III/us/index.php";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadHitfilm_Click(object sender, EventArgs e)
        {
            string url = "https://account.fxhome.com/install";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadInteXTU_Click(object sender, EventArgs e)
        {
            string url = "https://www.intel.com/content/www/us/en/download/17881/intel-extreme-tuning-utility-intel-xtu.html";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadRevoUninstaller_Click(object sender, EventArgs e)
        {
            string url = "https://www.revouninstaller.com/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadRidnacs_Click(object sender, EventArgs e)
        {
            string url = "https://www.splashsoft.de/ridnacs-download/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }

        private void buttonDownloadWinAeroTweaker_Click(object sender, EventArgs e)
        {
            string url = "https://winaerotweaker.com/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Error handling
                Console.WriteLine("Error opening the link: " + ex.Message);
            }
        }


        string scriptContent =
@"# Specify the path to ProgramsToInstall.txt in the default temp folder
$programsToInstallFilePath = Join-Path $env:TEMP ""ProgramsToInstall.txt""

# Validate the path
if (-not (Test-Path -Path $programsToInstallFilePath -PathType Leaf)) {
    Write-Host ""Error: The specified file path '$programsToInstallFilePath' is incorrect or does not exist.""
    Exit
}

# Read the list of programs from the specified file location
$programsToInstall = Get-Content $programsToInstallFilePath | Where-Object { $_.Trim() -ne """" }

# Function to check if the script is running with admin rights
function Test-AdminRights {
    $currentUser = New-Object Security.Principal.WindowsPrincipal([Security.Principal.WindowsIdentity]::GetCurrent())
    $adminRole = [Security.Principal.WindowsBuiltInRole]::Administrator
    return $currentUser.IsInRole($adminRole)
}

# Check if the script is running with admin rights
if (-Not (Test-AdminRights)) {
    # Relaunch the script with admin rights
    Start-Process powershell.exe -ArgumentList ""-NoProfile -ExecutionPolicy Bypass -File `""$($MyInvocation.MyCommand.Path)`"""" -Verb RunAs
    Exit
}

# Function to install a program using winget
function Install-Program {
    param (
        [string]$packageId
    )

    # Check if the program is already installed using winget
    $installed = (winget list -n | Select-String $packageId)

    if ($installed) {
        Write-Host ""$packageId is already installed.""
        return ""Already installed""
    } else {
        # Install the program using winget with agreement parameters
        Write-Host ""Installing $packageId...""
        $installResult = Start-Process -FilePath ""winget"" -ArgumentList ""install -e --id $packageId --accept-package-agreements --accept-source-agreements"" -Wait -PassThru
        if ($installResult.ExitCode -eq 0) {
            Write-Host ""$packageId has been installed.""
            return ""Installed""
        } elseif ($installResult.ExitCode -eq -1978335189) {
            Write-Host ""$packageId is already installed.""
            return ""Already installed""
        } else {
            Write-Host ""Failed to install $packageId. Exit Code:"" $installResult.ExitCode
            return ""Failed (Exit Code: $($installResult.ExitCode))""
        }
    }
}

# Array to store installation results
$installationResults = @()

# Install each program in the list
foreach ($program in $programsToInstall) {
    $result = Install-Program -packageId $program
    $installationResults += $result
}

# Display installation summary
Write-Host ""Installation Summary:""
foreach ($result in $installationResults) {
    Write-Host $result
}

# Pause to keep the window open
Read-Host -Prompt ""Press Enter to exit.""";
    }
}
