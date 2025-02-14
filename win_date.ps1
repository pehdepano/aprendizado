$os = get-wmiobject win32_operatingsystem
Write-Host "Windows instalado em:"
[Management.ManagementDateTimeConverter]::ToDateTime($os.InstallDate).ToString("dd/MM/yyyy HH:mm:ss")
