### Firebase Authentication Service

The repository contains the source code for a Firebase-based authentication service. This code was written to accompany the tutorial [Integrare l'autenticazione di Firebase nel tuo progetto .NET](https://cosminirimescu.com/integrare-l-autenticazione-di-firebase-nel-tuo-progetto-dotnet/) (Italian language).

The service is implemented using ASP.NET Core and offers the following functionality:

- Registration of new users
- Login for existing users
- Obtaining user information
- Logout functionality

Before running the application, you will need to configure a Firebase project and obtain the necessary credentials.

The configuration of the Firebase authentication service is done via the `appsettings.json` file, where the web API keys and the Firebase project ID are specified.

The `AuthController` handles HTTP requests for authentication operations and uses the `AuthService` to interact with Firebase.

The Swagger interface has been integrated to simplify API testing directly from the browser, allowing you to send requests and verify results in an intuitive manner.

This repository provides a starting point for the development of a Firebase-based authentication service using ASP.NET Core.