# Maussoft.Mvc VB.net example

High speed web framework built in VB.net that runs on .NET 6

### Build single executable

You can run the following in the project directory:

    dotnet publish \
        /p:Configuration=Release \
        /p:PublishSingleFile=true \
        /p:RuntimeIdentifier=linux-x64 \
        /p:DebugType=None \
        /p:DebugSymbols=false
    
You end up with two files in `bin/Release/net6.0/linux-x64/publish`:

- appsettings.json
- Acme.Example

One is the config file, the other one the executable.

### Links

- https://tqdev.com/2022-web-development-in-visual-basic-net-6
