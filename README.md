# Selenium-Template

## Project Structure

This solution is divided into several projects, each with a specific purpose:

- **Configuration**  
  Contains general configuration settings such as URLs and application ports. If your tests are part of the same solution as the application, this project can include app-specific configurations. Config files (e.g., `appconfig.json`) are automatically copied to the test output directory during the build for easy access during test execution.

- **Specification**  
  Includes SpecFlow files (Gherkin format) that describe automated business scenarios. Files are organized to reflect the application's structure. This project also includes a package to automatically add ChromeDriver to the build output, removing the need for manual copying.

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