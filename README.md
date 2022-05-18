# Roman
Roman is an app which takes an integer num and converts it to its equivalent roman.

## Installation on Ubuntu/Linux
First, we have to add the Microsoft packages to the trusted keys in the system.
For it, we should do the next steps:

~~~
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
~~~

Then we must install the SDK .Net or dotnet
We do the following steps to install the SDK:

~~~
sudo apt-get update
sudo apt-get install -y apt-transport-https
sudo apt-get update
sudo apt-get install -y dotnet-sdk-6.0
~~~

For more information, you can consult on the official Microsoft documentation [documentation]
[documentation](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu)

## Usage
To run the program we need to use the command 'dotnet run'
And to run the unit tests we use 'dotnet xunit'