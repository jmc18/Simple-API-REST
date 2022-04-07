# Simple-API-REST for GO Bootcamp

## This project is made in ASP.NET code with the dotnet 5 version.

###

## You can use **Visual Studio 2022** to run the app and run it with the tools it provides.

### The url that will open will be the following: **https://localhost:44371/swagger/index.html**, it will display an interface with the Swagger tool with the two endpoints

###

## You can also use **Visual Studio Code** and run the following command

```
cd .\SimpleRestApi.EndPoint\

dotnet run
```

### You can see the Swagger tool at the following URL: **https://localhost:5001/swagger/index.html**

# The Endpoints are as follows

## HelloWorld

```
Method GET

https://localhost:5001/api/HelloWorl or https://localhost:44371/api/HelloWorl
```

## Pokemon

```
Method POST

https://localhost:5001/pokemon-data/{pokemonName} or https://localhost:44371/pokemon-data/{pokemonName}
```

### The PokemonName attribute must be string, here follows a list of pokemon names

```
Bulbasaur
Ivysaur
Venusaur
Charmander
Charmeleon
Charizard
Squirtle
Wartortle
Blastoise
Caterpie
Metapod
Butterfree
```

# Unit test

## I Added a unit test project called **SimpleRestApi.Test** with xUnit Tool
