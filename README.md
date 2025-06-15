# C# Scripting Examples

This workspace contains simple C# scripts demonstrating basic file operations, NuGet package usage, and console output. You can run each script individually using:

```sh
dotnet run <filename>.cs
```

## Files

- **[SimpleHello.cs](SimpleHello.cs)**  
  Prints a welcome message to the console.

- **[ReadWriteToFile.cs](ReadWriteToFile.cs)**  
  Demonstrates how to check for a file's existence, create it if missing, write text to it, and read its contents.

- **[ReferencingNuget.cs](ReferencingNuget.cs)**  
  Shows how to reference and use a NuGet package (`Humanizer`) in a C# script to transform string casing.

- **[SAMPLETEXTFILE.txt](SAMPLETEXTFILE.txt)**  
  A sample text file used for file read/write demonstrations.

- **[SAMPLETEXTFILE2.txt](SAMPLETEXTFILE2.txt)**  
  Another sample text file used in file operations.

## How to Run

To execute a script, use:

```sh
dotnet run <filename>.cs
```

For example:

```sh
dotnet run SimpleHello.cs
```

> Note: Some scripts may create or modify the sample text files in the workspace.