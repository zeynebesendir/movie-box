# Movie Box




## About The Project

Movie Box is a simplified version of The Movie Database (TMDB) (https://www.themoviedb.org/)
</br></br>
It is developed to demonstrate:
 * Developing a WPF application using OOP principles
 * Consuming a REST API,
 * Displaying fetched data with custom styles


### Features
* Fetch data from the Movie Database API
* List movies from four different categories
* Display movie detail
* Seach movies


### Built With
* C#
* XAML
* <a href="https://developers.themoviedb.org/3/getting-started/introduction"> The Movie Database</a> API is consumed to develop this application.

## Getting Started

* To get a local copy up and running please get an API Key from <a href="https://developers.themoviedb.org/3/getting-started/introduction">here</a>
* Create an app.config file in the project and copy these:
</br>

```
<!-- App.config-->

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="APIKey" value="paste_your_key_here" />
  </appSettings>
</configuration> 
```
