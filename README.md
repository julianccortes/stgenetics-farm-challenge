# stgenetics-farm-challenge
Technical challenge for Frontend developer

## Technologies
- .Net 7
- Sql Server
- REST Standards
- Docker
- Blazor

## Features
- [x] Onion Architecture``
- [x] CQRS with MediatR Library
- [x] Entity Framework Core 
- [x] Repository Pattern - Generic
- [x] MediatR Pipeline Logging & Validation
- [x] Serilog
- [x] Swagger UI
- [x] Custom Exception Handling Middlewares
- [x] Fluent Validation
- [x] Automapper

## Considerations before start (Previous requirements)
- You need has installed, Docker and docker compose , if you want run solution in local mode. For more information go to the docker website

https://docs.docker.com/engine/install/ubuntu/

## Let's start in local mode..
The first step is clone the git repository in your local machine. For this, run the command:
```
git clone https://github.com/julianccortes/stgenetics-farm-challenge.git
```
After cloning the repository, we must navigate to the ** stgenetics-farm-challenge ** directory, and from there, run the Docker compose.
For this run the next command:

```
docker compose -f docker-compose.yml up
```
When docker compose has been succesfully up, you can browse to swagger api, that contain the api detail from each endpoint.

http://localhost:5555/swagger/index.html
