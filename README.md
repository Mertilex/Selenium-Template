# Selenium-Template
This repository provides a comprehensive Selenium template designed to streamline the automation process for web applications. Built with flexibility and scalability in mind, the template adheres to best practices like the Page Object Model (POM) and test isolation, ensuring clean and maintainable test code.

The solution is equipped with pre-configured tools and libraries to support efficient test development, including browser interactions, test reporting, and reusable utilities. Whether you are automating UI workflows, performing cross-browser testing, or validating application behavior, this template serves as a solid foundation to accelerate your testing efforts.


## Key features

### Unified interaction with the page
Interaction with page components is managed through properties in classes that define the page map (`TestBase.Containers.Map`). Each property is initialized by the WebDriver when the class object is created.  

Key rules:  
- Each property must have exactly one supported attribute (e.g., `ID`, `XPATH`, etc.).  
- Classes defining page maps should be split into two partial class files: one for the page map and one for the actions that can be performed on the page. This keeps the map and actions separate while sharing the same class name.  

### Specflow scenarios
The solution supports a Specflow markup language that is understandable for both business and technical people. It allows you to work more effectively with automated tests starting from the design phase.

![image](https://github.com/user-attachments/assets/d420f778-4e8c-48c5-adb9-3589495d3fd4)

### Multiple environments supports
One of the key features of this solution is the support of an unlimited number of environments. Therefore, it is possible to execute the same test suit among all environments where it is necessary.

### Custom setup via Test Directives
Sometimes it is necessary to prepare a wider set of initial data which might take a lot of time. To avoid necessity to generate it everytime, a concept of Test Directives was inplemented in this solution. It is possible to decide what data and when will be generated without changing the implementation of any test.

### Multiple browsers support
The solution supports 3 browsers that are independent on each other: Chrome, Firefox, Gecko. All settings that control the browser can be found in the settings file.


## Project Structure

This solution is divided into several projects, each with a specific purpose:

- **Configuration**  
  Contains general configuration settings such as URLs and application ports. If your tests are part of the same solution as the application, this project can include app-specific configurations. Config files (e.g., `appconfig.json`) are automatically copied to the test output directory during the build for easy access during test execution.

- **Specification**  
  Includes SpecFlow files (Gherkin format) that describe automated business scenarios. Files are organized to reflect the application's structure. This project also includes a package to automatically add ChromeDriver to the build output, removing the need for manual copying.
  
![image](https://github.com/user-attachments/assets/6f3437c0-7b5d-44e6-a17d-a55d405d08c7)

  

- **StepsImplementation**  
  Implements high-level steps from the Specification project. Files in this project should follow a naming convention ending with `Steps`, ensuring the separation of high-level logic from implementation details. This project also handles `before` and `after` test actions, such as WebDriver initialization and cleanup.

- **TestBase**  
  Facilitates interactions between the WebDriver and the browser. This project includes object maps for the application's pages and methods for performing actions on the pages (e.g., `SetLoginTextBox`).

- **Tools**  
  Provides utilities like extension methods and helper functions for consistent operations throughout the test lifecycle, such as date conversions or custom utilities.

This modular structure ensures maintainability and clarity, making the solution adaptable for various testing scenarios.


## Configuration Parameters

This solution describes several configurable parameters to tailor the automation framework to your project's needs. Below is a description of the adjustable settings available in the `AppSettings` file:

- **EnableWebDriverLogging**  
  - **true/false**: Enables or disables WebDriver logging.

- **WebDriverLogFileWithExtension**  
  - The file name (with extension) where WebDriver logs will be stored.

- **ScreenshotsDirectory**  
  - The full path to the directory where screenshots taken during tests will be saved. Ensure the WebDriver has permissions to create this directory and write files to it.

- **EnableVerboseLogging**  
  - **true/false**: Enables or disables detailed logging in the WebDriver log file. This setting applies only to ChromeDriver.

- **WebDriverTimeout**  
  - The default timeout value for WebDriver operations. Used during the driver's initialization.

- **WebDriverChromeOptions**  
  - A list of options to be passed to Chrome WebDriver during initialization. These parameters can enforce specific browser behaviors, such as disabling pop-up blocking. Multiple options are supported, and an empty list is valid.

- **WebDriverFirefoxOptions**  
  - A list of options to be passed to Firefox WebDriver (GeckoDriver) during initialization. These parameters can enforce specific behaviors, such as launching the browser in headless mode. Multiple options are supported, and an empty list is valid.

- **BrowserWindowSize**  
  - The dimensions of the browser window controlled by the WebDriver. Note: the maximized window option is not supported.

- **WebDriverType**  
  - Specifies the type of WebDriver to use for testing. Currently supported values are `Chrome` and `Firefox` (case-sensitive).

These settings provide flexibility to adapt the framework to various scenarios and requirements, ensuring a customizable and efficient test automation process.


## How to start
1. Clone repository
2. Install SpecFlow for Visual Studio 202X (where x is version of your Visual Studio)
3. Rebuild SpecFlow Bindings in the Specification project.
