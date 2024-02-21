curl -o vc_redistx64.exe https://aka.ms/vs/17/release/vc_redistx64.exe
Start-Process -Wait -FilePath "C:\test\vc_redistx64.exe" -ArgumentList "/install /passive /norestart"

curl -o ODBC.msi https://go.microsoft.com/fwlink/?linkid=2249006
msiexec.exe /i ODBC.msi  /norestart /qn /quiet /passive IACCEPTMSODBCSQLLICENSETERMS=YES /l*v "C:\test\odbc-install-log.txt"

curl -o SQLServerClientTools.msi https://go.microsoft.com/fwlink/?linkid=2230791
setx ACCEPT_EULA 'Y' /M

Start-Process -Wait -FilePath "msiexec.exe" -ArgumentList "/i", "C:\test\SQLServerClientTools.msi", "/qn", "/l*v", "C:\test\msi-install-log.txt"

















powershell -Command Start-Process -Wait -FilePath msiexec -ArgumentList '/i', 'C:\test\SQLServerClientTools.msi', '/qn', '/l*v', 'C:\test\msi-install-log.txt'
