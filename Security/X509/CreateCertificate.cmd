REM Script automatically creates a new certificate in a specified store and adds NETWORK SERVICE permissions to be consumed from a web app hosted in IIS
REM Create certificate for specified certificate store
makecert -r -pe -n "CN=SigningCertificate" -b 12/29/2017 -e 01/01/2049 -sky signature -a sha256 -len 2048 -ss my -sr LocalMachine
REM BE sure to install required tools https://www.microsoft.com/en-us/download/confirmation.aspx?id=19801
REM Grant Provate Key access for Network Service
"c:\Program Files (x86)\Windows Resource Kits\Tools\winhttpcertcfg.exe" -g -c LOCAL_MACHINE\My -s OrthobulletsSigning -a "NETWORK SERVICE"