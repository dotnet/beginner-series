FROM mcr.microsoft.com/dotnet/sdk:7.0
RUN wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN rm packages-microsoft-prod.deb
RUN apt update && apt upgrade -y && apt install unzip curl dotnet-sdk-6.0 -y
RUN dotnet tool install -g mlnet-linux-x64
ENV PATH="$PATH:/root/.dotnet/tools"