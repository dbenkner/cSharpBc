
using System.Text.Json;
using TestBankingApiCli;

const string baseURL = "http://localhost:5555";

JsonSerializerOptions joptions = new JsonSerializerOptions() {
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    WriteIndented = true
};

HttpClient _http = new HttpClient();

 
var jsonresponse = await GetUsersAsync(_http, joptions);
var users = jsonresponse.DataReturned as IEnumerable<User>;

foreach (var user in users)
{
    Console.WriteLine($"{user.Firstname} {user.Lastname} {user.Phone}");
}

var oneUser = await GetUserAsync(_http, joptions, 2);
Console.WriteLine($"{oneUser.Firstname} {oneUser.Lastname}");
//get all users
async Task<JsonResponse> GetUsersAsync(HttpClient http, JsonSerializerOptions jsonOptions)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/api/users");
    HttpResponseMessage response = await _http.SendAsync(req);
    Console.WriteLine($"HTTP ErrorCode is {response.StatusCode}");
    if (response.StatusCode != System.Net.HttpStatusCode.OK)
    {
    }
    var json = await response.Content.ReadAsStringAsync();
    var users = (IEnumerable<User>?)JsonSerializer.Deserialize(json, typeof(IEnumerable<User>), jsonOptions);
    if(users is null)
    {
        throw new Exception();
    }
    return new JsonResponse()
    {
        HttpStatusCode = (int) response.StatusCode,
        DataReturned = users
    };
}
//get user by PK
async Task<User> GetUserAsync (HttpClient http, JsonSerializerOptions jsonOptions, int id)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/api/users/{id}");
    HttpResponseMessage response = await _http.SendAsync(req);
    Console.WriteLine($"HTTP ErrorCode is {response.StatusCode}");
    var json = await response.Content.ReadAsStringAsync();
    var user = (User?)JsonSerializer.Deserialize(json, typeof (User), jsonOptions);
    return user;
}
var upUser = new User()
{
    Id = 2,
    Username = "hsimpson",
    Password = "Beerforme",
    Firstname = "Homer", Lastname = "Simpson",
    Phone = "6265553226", Email = "notvandnobeermakeshomersomethingsomething@yahoo.com",
    IsReviewer = false, IsAdmin = false
};
await UpdateUser(upUser, joptions);
async Task<JsonResponse> UpdateUser(User user, JsonSerializerOptions options)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Put, $"{baseURL}/api/users/{user.Id}");
    var json = JsonSerializer.Serialize<User>(user, options);
    req.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _http.SendAsync(req);
    Console.WriteLine($"HTTP ErrorCode: {response.StatusCode}");
    return new JsonResponse()
    {
        HttpStatusCode = (int) response.StatusCode
    };
}
oneUser = await GetUserAsync(_http, joptions, 3);
var newUser = new User()
{
    Id = 0,
    Username = "testing",
    Password = "testing",
    Firstname = "testing",
    Lastname = "testing",
    Phone = "50509235432",
    Email = "test@yahoo.com",
    IsReviewer = false,
    IsAdmin = false
};
jsonresponse = await NewUser(newUser, joptions);

// adds a new user
async Task<JsonResponse> NewUser(User user, JsonSerializerOptions options)
{
    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"{baseURL}/api/users"); // calls the HTTP POST Method and URL
    var json = JsonSerializer.Serialize<User>(user, options); // sets json content
    request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json"); // calls teh JSON application
    HttpResponseMessage response = await _http.SendAsync(request); // calls the API 
    Console.WriteLine($"HTTP ERROR CODE: {response.StatusCode}"); // if all goes well should be EC 200
    return new JsonResponse()
    {
        HttpStatusCode = (int)response.StatusCode
    };
}
jsonresponse = await GetUsersAsync(_http, joptions);
users = (IEnumerable<User>?)jsonresponse.DataReturned;

foreach(var user in users)
{
    Console.WriteLine($"{user.Firstname} {user.Lastname}");
}

async Task<JsonResponse> DeleteUser(User user, JsonSerializerOptions options)
{
    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, $"{baseURL}/api/users/{user.Id}");
    var json = JsonSerializer.Serialize<User>(user, options);
    request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _http.SendAsync(request);
    Console.WriteLine($"HTTP ERROR CODE: {response.StatusCode}");
    return new JsonResponse()
    {
        HttpStatusCode = (int)response.StatusCode
    };
}



jsonresponse = await GetUsersAsync(_http, joptions);
users = (IEnumerable<User>?)jsonresponse.DataReturned;

foreach (var user in users)
{
    Console.WriteLine($"{user.Firstname} {user.Lastname}");
}
