# Adding extra stuff

```console
$ dotnet run
Thing1 did it
$ dotnet run -p:AddExtra=true
Extra initialized
Thing1 did it
Thing 2 did it
```

Also works with `publish -p:PublishAot=true`

## Details

Add a `[ModuleInitializer]` method to the main assembly that calls a predetermined method in the extra assembly which augments some stuff in a singleton.
