FROM microsoft/dotnet

# clone application repository
RUN cd / && mkdir warner && cd warner && git clone https://github.com/shukanov-artyom/Warner.git .

# restore packages in application
RUN cd /warner/Warner && dotnet restore

# build application
RUN cd /warner/Warner && dotnet build

# set environment variable
ENV ASPNETCORE_URLS http://*:83

# expose port
EXPOSE 83/tcp

# run application
ENTRYPOINT /bin/bash -c "cd /warner/Warner && dotnet run"