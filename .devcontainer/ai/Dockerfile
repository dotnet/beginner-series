FROM mcr.microsoft.com/dotnet/sdk:10.0
RUN apt update && apt upgrade -y && apt install unzip curl -y
RUN dotnet tool install -g mlnet-linux-x64 --allow-roll-forward
ENV PATH="$PATH:/root/.dotnet/tools"