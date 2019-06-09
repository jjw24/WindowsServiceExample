Example using Windows Services to run batch files

Note:
Windows Service is not running in the context of any particular user so it cannot start any additional applications. Starting from Vista and later OS Windows Services are running in an isolated session and are disallowed to interact with a user or desktop.

This means any applications or commands need to be able to run and complete in the background. If using Windows Service to call a batch file which in turn runs application installs, the applications need to be able to complete the installs in the background, ones that pop up with interactive window for users to click through will just sits as a background process without any interactive window.
