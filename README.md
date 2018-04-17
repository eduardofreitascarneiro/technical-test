Cousine

GET /api/v1/Cousine
GET /api/v1/Cousine/search/{searchText}
GET /api/v1/Cousine/{cousineId}/stores

Curl
curl -X GET "http://api-vanhack-event-sp.azurewebsites.net/api/v1/Cousine" -H "accept: application/json"

Url
http://api-vanhack-event-sp.azurewebsites.net/api/v1/Cousine
Resposta
[
  {
    "id": 1,
    "name": "Chinese"
  },
  {
    "id": 2,
    "name": "Pizza"
  },
  {
    "id": 3,
    "name": "Vietnamese"
  },
  {
    "id": 4,
    "name": "Sushi"
  }
]

Cabeçalho
 content-encoding: gzip 
 content-type: application/json; charset=utf-8 
 date: Sat, 24 Mar 2018 13:38:17 GMT 
 server: Kestrel 
 transfer-encoding: chunked 
 vary: Accept-Encoding 
 x-powered-by: ASP.NET

