Rhyming Words API
============

Word Rhymes is a simple tool for getting word rhymes. It returns a list of rhyming words.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Rhyming Words API](https://apiverve.com/marketplace/api/wordrhymes)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.RhymingWords
```

Using the Package Manager:
```
nuget install APIVerve.API.RhymingWords
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.RhymingWords
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.RhymingWords".
5. Click on the APIVerve.API.RhymingWords package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the wordrhymes API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Rhyming Words API documentation is found here: [https://docs.apiverve.com/api/wordrhymes](https://docs.apiverve.com/api/wordrhymes).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Rhyming Words API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new RhymingWordsAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new RhymingWordsQueryOptions {
  word = "blue"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "word": "blue",
    "rhymeCount": 20,
    "rhymes": [
      {
        "score": 3,
        "pron": "D EH2 B L UW1",
        "word": "deblois"
      },
      {
        "score": 2,
        "pron": "B AH0 L UW1",
        "word": "ballou"
      },
      {
        "score": 2,
        "pron": "B IH0 L UW1",
        "word": "bellew"
      },
      {
        "score": 2,
        "pron": "K EH2 R AH0 L UW1",
        "word": "carilou"
      },
      {
        "score": 2,
        "pron": "SH AH0 L UW1",
        "word": "chaloux"
      },
      {
        "score": 2,
        "pron": "K L UW1",
        "word": "clue"
      },
      {
        "score": 2,
        "pron": "F L UW1",
        "word": "flew"
      },
      {
        "score": 2,
        "pron": "F L UW1",
        "word": "flu"
      },
      {
        "score": 2,
        "pron": "F L UW1",
        "word": "flue"
      },
      {
        "score": 2,
        "pron": "G L UW1",
        "word": "glew"
      },
      {
        "score": 2,
        "pron": "G L UW1",
        "word": "glue"
      },
      {
        "score": 2,
        "pron": "HH AH2 L AH0 B AH0 L UW1",
        "word": "hullabaloo"
      },
      {
        "score": 2,
        "pron": "K L UW1",
        "word": "klu"
      },
      {
        "score": 2,
        "pron": "L UW1",
        "word": "leu"
      },
      {
        "score": 2,
        "pron": "L UW1",
        "word": "lew"
      },
      {
        "score": 2,
        "pron": "L UW1",
        "word": "lieu"
      },
      {
        "score": 2,
        "pron": "L UW1",
        "word": "loo"
      },
      {
        "score": 2,
        "pron": "L UW1",
        "word": "lou"
      },
      {
        "score": 2,
        "pron": "L UW1",
        "word": "louw"
      },
      {
        "score": 2,
        "pron": "L UW1",
        "word": "loux"
      }
    ]
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.