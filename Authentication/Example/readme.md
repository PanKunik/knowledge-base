## Authentication with JWT 

This is my minimal example for adding authorization and authentication to the application. It was created for practicing use of JWT bearer token for authorizing and authenticating the users. For now, there aren't any roles and claims. In this application we have simple controller that can list products and add new products to the static list.

```c#
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return _productRepository.GetAll();
    }

    [HttpPost]
    [Authorize]
    public IActionResult Post(Product product)
    {
        _productRepository.AddProduct(product);
        return Ok();
    }
}
```

## Product listing
Lisitng doesn't need authorization, anyone can list the products. To display list of products simply go to the route:

```
[GET] /api/product
```

You will get a response like:
```json
[
  {
    "id": 1,
    "name": "Mleko 3.2% UHT",
    "price": 3.99
  },
  {
    "id": 2,
    "name": "Pasta do zębów",
    "price": 14.98
  },
  {
    "id": 3,
    "name": "Chleb pszenny",
    "price": 4.85
  }
]
```

## Product adding
Second enpoint is capable of adding new products to this static in-memory list. You can add products by executing http request like this:
```
[POST] /api/product

Content-Type: application/json
{
    "id": 4,
    "name": "name-of-product",
    "price": 1
}
```

Without adding token you will get `401 Not Authorized` response.

To obtain the token, you have to login under the resource:
```
[POST] /api/authentication/login

Content-Type: application/json
{
    "email": "admin@example.com",
    "password": "pwd1234"
}
```

## Login
To keep this example *very* simple the application checks if the email is equal to `admin@example.com` and the password `pwd1234`. Then you will get a access token in response:

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhZG1pbkBleGFtcGxlLmNvbSIsImp0aSI6ImU0OTBjZDlkLWMzN2ItNGUwMC04YTdlLTliNTI3NWNlMzU5OSIsImVtYWlsIjoiYWRtaW5AZXhhbXBsZS5jb20iLCJ1aWQiOiIzYzExNThjZS0yNDU3LTQwNTgtOWQ3MS1jMmM0ZDQxMTQ0ZmUiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhZG1pbiIsImV4cCI6MTY1OTc4ODk5NSwiaXNzIjoiand0LXRva2VuLWV4YW1wbGUiLCJhdWQiOiJqd3QtdG9rZW4tYXVkaWVuY2UifQ.IAymu-R3VPObxsiVTVSgEZd66bDy6inTClfI9wHRpts"
}
```

Then, you can add this token to the `add product` resource. IF the token is valid, the product will be added.

```
[POST] /api/product

Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhZG1pbkBleGFtcGxlLmNvbSIsImp0aSI6IjgwOWMxZjM5LWMxY2UtNGMwZC1hZjBmLWRhODRmNmIyNzIzNiIsImVtYWlsIjoiYWRtaW5AZXhhbXBsZS5jb20iLCJ1aWQiOiI4MTk5YjExMC0yMGRjLTRmODItODg4Yy01MzIxZmNhOTI3NjMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhZG1pbiIsImV4cCI6MTY1OTc4ODQwNCwiaXNzIjoiand0LXRva2VuLWV4YW1wbGUiLCJhdWQiOiJqd3QtdG9rZW4tYXVkaWVuY2UifQ.TXFzPiBoiTcFtW-B9Lv1frWFoqOLOVT09Nsfar2KOM0

Content-Type: application/json
{
    "id": 4,
    "name": "Parówki",
    "price": 6.98
}
```
