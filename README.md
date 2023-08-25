# SoftServe REST Countries Implementation

## Application Description:

This application is a service designed to provide users with detailed country information. This API simplifies tasks like searching countries by name, population, filtering results, and offers flexible sorting and pagination options. This application is built using .NET 6.

## How to Run Locally:

1. Make sure you have .NET 6 SDK installed on your machine. If not, download and install it from [here](https://dotnet.microsoft.com/download/dotnet/6.0).
2. Clone the repository to your local machine using `git clone https://github.com/kymeza/SoftServe-Investigation`.
3. Run `dotnet restore` to install all necessary dependencies.
4. Start the application using `dotnet run`.
5. Open a browser and navigate to `http://localhost:5000/swagger` to access the Swagger UI.

## Enpoint Usage:
The available endpoint `/country` allows to:
- Get all available countries
- Filter countries by name
- Filter countries by population (get countries with less or equal input)
- Sort results in ascending or descending order
- Paginate the results to limit the number of items recieved
- Only **HTTP GET** is implemented

**The parameters are:**
- `population`:
It can accept raw numbers, such as "5000000", or numbers with a 'k' or 'm' notation to represent thousands and millions, respectively. For instance, both "5m" and "5000k" would represent 5,000,000.

- `name`:
Searchs for countries based on a substring of their name. It conducts a case-insensitive search.

- `pagination`:
Is utilized to limit the number of results returned.

- `sort`:
To order the countries based on their names. The accepted values are "asc" (ascending) or "desc" (descending), with "ascending" and "descending" also being valid values.

**All of wich are optional**

## Examples:

01. **Retrieve All Countries**:  
   `/country`
   
02. **Search Countries by Name**:  
   `/country?name=Canada`
   `/country?name=CHI`
   `/country?name=cHiLE`

03. **Filter Countries by Population**:  
   `/country?population=10m`
   `/country?population=500k`
   `/country?population=390720`

04. **Sort Countries by Name Ascending**:  
   `/country?sort=asc`

05. **Sort Countries by Name Descending**:  
   `country?sort=desc`

06. **Paginate Results**:  
   `/country?pagination=10`

07. **Filter and Sort**:  
   `/country?name=Canada&sort=desc`

08. **Filter by Multiple Parameters**:  
   `/country?name=CHI&population=20m`

09. **Retrieve First 5 Countries**:  
    `/country?pagination=5&sort=asc`

10. **Retrieve Last 5 Countries**:  
   `/country?pagination=5&sort=desc`
