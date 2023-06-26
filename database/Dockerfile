FROM mcr.microsoft.com/mssql/server
COPY ScriptDb.sql .
COPY start.sh .
COPY entrypoint.sh .
ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=QwErTy9317/*
CMD /bin/bash entrypoint.sh