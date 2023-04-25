
## Worker Salary API

I originally only had two endpoints, so I ended up adding the "PublicInfo" GET method to act as the third.

## API HTTP Methods

* GET
* POST
* PUT
* DELETE

## API Endpoints

* https://localhost:7124/api/Worker (GET, POST)
* https://localhost:7124/api/Worker/{id} (GET, PUT, DELETE)
* https://localhost:7124/api/Public (GET)

## Example Schema

```
{
  "workerId": 8,
  "workerName": "Squilliam Fancyson",
  "age": 39,
  "jobTitle": "Clarinet Player",
  "currentPay": 999999999,
  "publicInfo": {
    "personId": 8,
    "phoneNumber": "257-981-1398",
    "address": "Bikini Bottom Stadium",
    "workerId": 8
  }
}
```

## Example Response Body

```
{
  "statusCode": 0,
  "statusDescription": "string",
  "worker": [
    {
      "workerId": 0,
      "workerName": "string",
      "age": 0,
      "jobTitle": "string",
      "currentPay": 0,
      "publicInfo": {
        "personId": 0,
        "phoneNumber": "string",
        "address": "string",
        "workerId": 0
      }
    }
  ]
}
```
