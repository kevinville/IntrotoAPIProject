
## Worker Salary API

hello

## API HTTP Methods

* GET
* POST
* PUT
* DELETE

## API Endpoints

* /api/Worker (GET, POST)
* /api/Worker/{id} (GET, PUT, DELETE)

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
