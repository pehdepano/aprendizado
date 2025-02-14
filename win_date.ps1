$os = get-wmiobject win32_operatingsystem
$os.ConvertToDateTime($os.InstallDate) -f "dd/MM/yyyy"