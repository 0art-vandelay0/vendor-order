# 🇫🇷 **Pierre's Order Management System** 🇫🇷

#### **By Casey Hill**

#### A simple web application that allows you to add Vendors to a vendor page and add orders assocatied with the Vendors. &#x1F4C1; &#x1F4C5; &#x1F4CB;

#### ...._"Organize your thoughts, focus on the essentials, and simplify everything."_ - Haruki Murakami

## **Technologies Used**

-   C#
-   MVC
-   ASP.NET
-   .NET 6.0.402
-   dontnet CLI
-   MSBuild
-   MSTest
-   VS Code
-   git
-   GitHub

## **Description**

This is a web app that allows a buiness owner to organize orders and vendors and those associated with each other. On the splash page, you can add a Vendor to add to the running list of vendors. When a Vendor is created, Orders can be created for said Vendor and stored within that Vendor's information.

## **Setup/Installation Requirements** &#x1F4BB;

### **In IDE** (this serves as instructions for VS Code)

-   Clone this repository to your local machine.
-   Open VS Code.
-   Open the top level directory you just cloned.
-   In your terminal:

    -   Change directory (cd) to Pierres.
    -   Enter `dotnet build` into your terminal.
    -   Enter `dotnet watch run` into your terminal.
    -   If you would like to run the test files.
        -   cd to Pierre.Tests.
        -   enter `dotnet build` into your terminal.
        -   enter `dotnet test` into your terminal.
    -   cd back to Pierres dir and enter `dotnet watch run`.
    -   The program should start and you will see the splash page open at localhost port 5000 or 5001.
    -   Add a new Vendor and go from there.

    That's it!

#### Debugging

If the program does not run, try the following:

-   Check that you have the appropriate .NET packages installed to run dotnet
-   Make sure the port needed to run is not currently already in use.
-   Try creating a `global.json` file in the Pierres.Tests dir that contains the following code to override the default version:<br>
    {<br>
    &emsp;&emsp; "sdk": {<br>
    &emsp;&emsp;&emsp;&emsp;"version": "6.0.402"<br>
    &emsp;&emsp;}<br>
    }

## **Known Bugs**

-   There is not a Delete option to delete Vendors or Orders yet but is forthcoming.

## License

Please contact [caseyfhill1@gmail.com](mailto:caseyfhill1@gmail.com?subject=Hello%20Casey,&body=You%20are%20amazing...) with any the following:

-   Found bugs &#x1F41E;
-   Alterations and improvements
-   General Questions
-   Any contributions you would like to make! &#x1F5DD;

Copyright (c) 06/16/2023 Casey Hill
