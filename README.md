# MVCWebApplicationSolution
This MVC application in .NET Framework (4.7.2) has Bootstrap 3.4.1 installed by default and is invoked in the _Layout.cshtml page (global) and it has a partial page (~\MVCWebApplication\Views\Shared\IsolatedBootstrap5Partial.cshtml) with Bootstrap 5 features (data-bs-theme). We desire to isolate this partial from the rest of the application which uses the older version of Bootstrap. The desire is to have the Bootstrap 5 features working in isolation from the rest of the App that uses Bootstrap 3.

Bootstrap 5.3.2 -> ~\MVCWebApplication\wwwroot\lib\bootstrap-5.3.2-dist\bootstrap-5.3.2-dist
