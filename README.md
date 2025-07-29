# .NET DevContainer Demo

A simple C# Hello World application demonstrating .NET 9.0 development in a DevContainer environment.

## Requirements

- .NET 9.0 SDK
- Docker (for DevContainer)

## Running the Application

```bash
cd HelloWorldApp/ && dotnet run . && cd -
```

## Project Structure

- `.devcontainer/` - DevContainer configuration for VS Code
- `HelloWorldApp/` - C# console application
- `.gitignore` - Comprehensive .NET gitignore file

## DevContainer Features

- Based on `mcr.microsoft.com/devcontainers/dotnet:1-9.0-bookworm`
- Includes Docker-outside-of-docker support
- Pre-configured with C# Dev Kit extension
- Excludes core dumps from version control

## Output

The application displays system information:
```
Hello, World from .NET on Linux!
Running on: Unix 6.14.10.0
.NET Version: 9.0.7
```
