# Movie Box

<img src="/Images/readme.gif"  height="300"/>


## About The Project

Movie Box (WPF Application) is a simplified version of The Movie Database (https://www.themoviedb.org/)
</br>
It is developed to demonstrate:
 * Applying OOP principles
 * Implementing MVVM Pattern
 * Consuming a REST API,
 * Displaying fetched data using customized styles
 * Data binding


### Features
* Lists movies on four categories
* Displays movie detail
* Search Movies

### Built With
* C#
* XAML
* Visual Studio
* Blend
* <a href="https://www.themoviedb.org/"> The Movie Database (TMDb)</a> API is consumed to develop this application.


## Getting Started

To get a local copy up and running please follow these simple steps.
</br>

* An API Key is required to access TMDb API. (follow the steps 
<a href="https://developers.themoviedb.org/3/getting-started/introduction">here</a> to get the key)

* Add an App.config file to the Project and save the API Key in here.
</br>

 ```xaml
  <!-- App.config-->
  <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
      <appSettings>
        <add key="APIKey" value="paste-your-api-key-here" />
      </appSettings>
    </configuration>
```







