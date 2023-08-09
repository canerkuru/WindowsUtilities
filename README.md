# WindowsUtilities

RSA Key Containers App

Sample Command Prompt Commands

Exporting an RSA Key Container
aspnet_regiis -px NetFrameworkConfigurationKey C:\rsaKeys\RSA_NetFrameworkConfigurationKey.xml -pri


aspnet_regiis -pef "system.net/mailSettings/smtp" "C:\test\webconfig_sifre" -prov "MyKeys"

aspnet_regiis -pdf "system.net/mailSettings/smtp" "C:\test\webconfig_sifre"


aspnet_regiis -pe "system.net/mailSettings/smtp" -app "C:\test\webconfig_sifre" -prov "MyKeys"


aspnet_regiis -px RsaProtectedConfigurationProvider C:\test\webconfig_sifre\RSA_configkey.xml -pri

aspnet_regiis -pc "MyKeys" -exp

aspnet_regiis -px NetFrameworkConfigurationKey C:\test\webconfig_sifre\RSA_configkey1.xml -pri

aspnet_regiis -pc "SampleKeys"–exp

aspnet_regiis -px RsaProtectedConfigurationProvider C:\test\webconfig_sifre\RSA_configkey1.xml -pri

