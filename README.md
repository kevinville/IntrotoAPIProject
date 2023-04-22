
## Worker Salary API

hello

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
