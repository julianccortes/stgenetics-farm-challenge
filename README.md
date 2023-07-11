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

![image](https://github.com/julianccortes/stgenetics-farm-challenge/assets/12352975/84496417-921d-457c-bae9-ddf13a83f0dc)

You can browse to WASS application with the next link: 

http://localhost:8095/

You can find the lateral navbat where you can access to animal option

![image](https://github.com/julianccortes/stgenetics-farm-challenge/assets/12352975/79f35b18-0cda-4cca-a3df-b8e4d5cc66a9)

In first time you can find the animals criteria filters, where you can select any criteria for search animals.

![image](https://github.com/julianccortes/stgenetics-farm-challenge/assets/12352975/bcb70c6a-0a53-4965-a1bd-b6f793063628)

After you click in Filter button, show all animals with search criteria, you can add to shopping cart

![image](https://github.com/julianccortes/stgenetics-farm-challenge/assets/12352975/8841f0f3-cd68-48a7-9e8d-6a0dda03b2ac)

Additional, you can order by search criteria in each column in table result

After add animal to cart, below this table you can look the Cart where all animals has been grouping by breed.

![image](https://github.com/julianccortes/stgenetics-farm-challenge/assets/12352975/3bb7d587-4718-4edf-a40c-cad584748ac9)

You can select how many animals quantity want add to final shopping

![image](https://github.com/julianccortes/stgenetics-farm-challenge/assets/12352975/013c55d0-8f67-49b8-b6d5-03046805db97)

Any time you change the animal quantity, change the final price detail and resumen has been change.

![image](https://github.com/julianccortes/stgenetics-farm-challenge/assets/12352975/f7098288-2fd2-4f8b-b561-dfb6c4cb69df)


Enjoy....





